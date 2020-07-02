using BackOfficeService.Services;
using Hangfire;
using Microsoft.Extensions.Caching.Memory;
using Nest;

namespace BackOfficeService.HangFireWorkers
{
    public class SearchProfileByDocnumberWorker : BaseWorker
    {
        public SearchProfileByDocnumberWorker(IMemoryCache memoryCache, IAppSettingsService appSettingsService, IElasticClient elasticClient) : base(memoryCache, appSettingsService, elasticClient)
        {
        }

        [Queue("search")]
        public void Work(Hangfire.Server.PerformContext performContext, IJobCancellationToken jobCancellationToken, int docnumber)
        {
            //Hangfire.BackgroundJobClient backgroundJobClient = new BackgroundJobClient(performContext.Storage);
            var chrono = WriteStartChrono(performContext.BackgroundJob.CreatedAt, docnumber.ToString());

            //mio codice di ricerca

            WriteEndChrono(chrono);
        }

    }
}
