using BackOfficeService.ElasticWriter;
using BackOfficeService.Services;
using Microsoft.Extensions.Caching.Memory;
using Nest;
using System;

namespace BackOfficeService.HangFireWorkers
{
    public class BaseWorker
    {
        private readonly IMemoryCache _cache;
        private readonly IAppSettingsService _appSettingsService;
        private readonly IElasticClient _elasticClient;

        public IMemoryCache Cache { get => _cache; }
        public IAppSettingsService AppSettingsService { get => _appSettingsService; }

        public BaseWorker(IMemoryCache memoryCache, IAppSettingsService appSettingsService, IElasticClient elasticClient)
        {
            _cache = memoryCache;
            _appSettingsService = appSettingsService;
            _elasticClient = elasticClient;
        }

        protected ChronoModel WriteStartChrono(DateTime createdAt, string parameters)
        {
            ChronoModel chrono = new ChronoModel()
            {
                ActionDescription = this.GetType().FullName,
                ScheduledTime = createdAt,
                StartTime = DateTime.Now,
                Parameters = parameters,
            };

            var indexResponse = _elasticClient.Index(chrono, i => i.Index("mioindice"));
            if (!indexResponse.IsValid)
                throw new Exception(string.Format("Error during save in Elastic Chrono", indexResponse.ServerError));
            chrono.StartTime = DateTime.Now; //non mi interessa la latenza della insert
            return chrono;
        }

        protected ChronoModel WriteEndChrono(ChronoModel chrono)
        {
            chrono.EndTime = DateTime.Now;
            chrono.MSecDuration =  (chrono.EndTime - chrono.StartTime).TotalMilliseconds;
            var indexResponse = _elasticClient.Index(chrono, i => i.Index("mioindice"));
            if (!indexResponse.IsValid)
                throw new Exception(string.Format("Error during save in Elastic Chrono", indexResponse.ServerError));
            return chrono;
        }

    }
}