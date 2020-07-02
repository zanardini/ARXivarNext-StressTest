using BackOfficeService.Services;
using Microsoft.Extensions.Caching.Memory;

namespace BackOfficeService.HangFireWorkers
{
    public class BaseWorker
    {
        private readonly IMemoryCache _cache;
        private readonly IAppSettingsService _appSettingsService;

        public IMemoryCache Cache { get => _cache; }
        public IAppSettingsService AppSettingsService { get => _appSettingsService; }

        public BaseWorker(IMemoryCache memoryCache, IAppSettingsService appSettingsService)
        {
            _cache = memoryCache;
            _appSettingsService = appSettingsService;

        }
    }
}