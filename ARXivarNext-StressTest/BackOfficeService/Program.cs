using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace BackOfficeService
{
    public class Program
    {
        static IConfigurationRoot configuration = new ConfigurationBuilder()
       .AddJsonFile("appsettings.json")
       .Build();

        public static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration().ReadFrom.Configuration(configuration).CreateLogger();
            try
            {
                Log.Information("Start");
                CreateHostBuilder(args).Build().Run();
            }
            catch (System.Exception ex)
            {
                Log.Fatal(ex, "Error");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
                Host.CreateDefaultBuilder(args)
                    .UseSerilog()
                    .ConfigureWebHostDefaults(webBuilder =>
                    {
                        webBuilder.UseStartup<Startup>();
                    });
    }
}
