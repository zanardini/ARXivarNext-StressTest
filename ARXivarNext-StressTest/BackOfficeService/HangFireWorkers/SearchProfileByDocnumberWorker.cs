using BackOfficeService.Services;
using Hangfire;
using Microsoft.Extensions.Caching.Memory;

namespace BackOfficeService.HangFireWorkers
{
    public class SearchProfileByDocnumberWorker : BaseWorker
    {
        public SearchProfileByDocnumberWorker(IMemoryCache memoryCache, IAppSettingsService appSettingsService) : base(memoryCache, appSettingsService)
        {
        }

        [Queue("search")]
        //public void Work(Hangfire.Server.PerformContext performContext, IJobCancellationToken jobCancellationToken, int docnumber)
        public void Work(int docnumber)
        {
            // Hangfire.BackgroundJobClient backgroundJobClient = new BackgroundJobClient(performContext.Storage);
            System.Threading.Thread.Sleep(100);
        }
    }
}
