using BackOfficeService.Arxivar;
using BackOfficeService.Services;
using Hangfire;
using Microsoft.Extensions.Caching.Memory;
using Nest;

namespace BackOfficeService.HangFireWorkers
{
    public class SearchProfileByDocnumberWorker : BaseWorker
    {
        public SearchProfileByDocnumberWorker(IMemoryCache memoryCache, IAppSettingsService appSettingsService, IElasticClient elasticClient, IArxivarService arxivarService) : base(memoryCache, appSettingsService, elasticClient, arxivarService)
        {
        }

        [Queue("search")]
        public void Work(Hangfire.Server.PerformContext performContext, IJobCancellationToken jobCancellationToken, int docnumber)
        {
            //Hangfire.BackgroundJobClient backgroundJobClient = new BackgroundJobClient(performContext.Storage);
            var chrono = WriteStartChrono(performContext.BackgroundJob.CreatedAt, docnumber.ToString());

            IO.Swagger.Api.UsersApi usersApi = new IO.Swagger.Api.UsersApi(ArxivarService.Configuration);
            usersApi.UsersGet(2);
            //mio codice di ricerca


            WriteEndChrono(chrono);
        }

    }
}
