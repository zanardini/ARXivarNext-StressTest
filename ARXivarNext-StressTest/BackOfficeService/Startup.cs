using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Hangfire;
using System.IO;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using BackOfficeService.Dal;
using BackOfficeService.Services;
using IdentityServer4.AccessTokenValidation;
using BackOfficeService.Utilities.BaseExtensions;
using BackOfficeService.Utilities.HangFireFilters;
using Nest;
using Hangfire.MemoryStorage;
using BackOfficeService.Arxivar;
using BackOfficeFramework;

namespace BackOfficeService
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        private IAppSettingsService _appSettingsService;

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.Configure<CookiePolicyOptions>(options =>
            //{
            //    // This lambda determines whether user consent for non-essential cookies is needed for a given request.
            //    options.CheckConsentNeeded = context => true;
            //    options.MinimumSameSitePolicy = SameSiteMode.None;
            //});

            //App Settings application 
            _appSettingsService = new AppSettingsService(Configuration);
            services.AddSingleton<IAppSettingsService>(_appSettingsService);

            //            services.AddAuthentication(IdentityServerAuthenticationDefaults.AuthenticationScheme)
            //              .AddIdentityServerAuthentication(IdentityServerAuthenticationDefaults.AuthenticationScheme,
            //                  jwtOptions =>
            //                  {
            //#warning Dovremmo imporre Https
            //                      jwtOptions.RequireHttpsMetadata = true;
            //                  }, referenceOptions =>
            //                  {
            //                      referenceOptions.Authority = _appSettingsService.ARXivarNextAuthenticationUrl;
            //                      referenceOptions.IntrospectionEndpoint = referenceOptions.Authority.ConcatUrls("api/auth/introspect");
            //                      referenceOptions.ClientId = _appSettingsService.ARXivarNextClientId;
            //                      referenceOptions.ClientSecret = _appSettingsService.ARXivarNextClientSecret;

            //                      // Todo: cache da abilitare
            //                      referenceOptions.EnableCaching = true;
            //                      //referenceOptions.CacheDuration= TimeSpan.FromSeconds(1); // that's the default
            //                  });


            services.AddDbContext<DataContext>(options => options.UseSqlServer(Configuration.GetConnectionString("LocalDB")));

            ////Job service  
            //services.AddScoped<IEngineInfoService, EngineInfoService>();

            //Register dapper in scope  
            services.AddScoped<IDapperHelper, DapperHelper>();

            services.AddScoped<IArxivarService, ArxivarService>(sp => new ArxivarService(_appSettingsService.ARXivarNextWebApiUrl, _appSettingsService.ARXivarNextUserName, _appSettingsService.ARXivarNextPassword, _appSettingsService.ARXivarNextClientId, _appSettingsService.ARXivarNextClientSecret));

            services.AddSingleton<IElasticClient>(new ElasticClient(new ConnectionSettings(_appSettingsService.ElasticSearchApiUrl)));

            services.AddControllers().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
                options.JsonSerializerOptions.PropertyNamingPolicy = null;
            });

            services.AddMvc(option => option.EnableEndpointRouting = false);

            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Version = "v1",
                    Title = "ARXivar Stress Test Project",
                    Description = "BackOffice Service to test ARXivar Next Performance",

                    Contact = new Microsoft.OpenApi.Models.OpenApiContact
                    {
                        Name = "Able Tech s.r.l.",
                        Email = string.Empty,
                        Url = new Uri("https://www.arxivar.it")
                    },
                });

                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);

                c.DisableAdditionalProperties();
                //c.AddSecurityConfiguration(); //SECURITY
                c.AddEnumDocumentation();
                c.AddApiCounters();
                c.SortSchemas();


            });

            //Memory cache
            services.AddMemoryCache();

            //Add Hangfire services
            if (_appSettingsService.HangFireUseMemoryStorage)
                services.AddHangfire(options => options.UseMemoryStorage());
            else
                services.AddHangfire(s => s.UseSqlServerStorage(Configuration.GetConnectionString("HangfireDB"),
                    new Hangfire.SqlServer.SqlServerStorageOptions
                    {
                        CommandBatchMaxTimeout = TimeSpan.FromMinutes(5),
                        SlidingInvisibilityTimeout = TimeSpan.FromMinutes(5),
                        QueuePollInterval = TimeSpan.Zero,
                        UseRecommendedIsolationLevel = true,
                        DisableGlobalLocks = true
                    }));

            GlobalConfiguration.Configuration.UseFilter(new InfiniteExpirationTimeAttribute());
            GlobalConfiguration.Configuration.UseFilter(new LogFilterAttribute());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseSwagger();

            IAppSettingsService appSettingsService = new AppSettingsService(Configuration);

            app.UseSwaggerUI(c =>
            {
                var swaggerUIPage = _appSettingsService.SwaggerUIPage;
                c.SwaggerEndpoint(swaggerUIPage, "Test Engine Service Api V1");
                c.RoutePrefix = string.Empty;

            });

            app.UseHttpsRedirection();
            //app.UseAuthentication(); //SECURITY
            //app.UseAuthorization(); //SECURITY
            //  app.UseCookiePolicy(); //SECURITY

            app.UseMvc();

            //Hangfire
            app.UseHangfireDashboard("/hangfire");
            app.UseHangfireServer(new BackgroundJobServerOptions()
            {
                WorkerCount = 20, //Quanti thread parallelo
                Queues = new string[2] { "archive", "search" } //nomi delle code che sa lavorare il mio server
            });
        }
    }
}
