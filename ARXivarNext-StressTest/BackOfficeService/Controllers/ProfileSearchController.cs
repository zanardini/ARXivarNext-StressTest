using System;
using Microsoft.Extensions.Configuration;
using BackOfficeService.Models;
using BackOfficeService.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using System.Linq;
using Microsoft.Extensions.Primitives;
using System.Collections.Generic;
using Hangfire;

namespace BackOfficeService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    // [Authorize] //SECURITY
    public class ProfileSearchController : ControllerBase
    {
        private IMemoryCache _cache;

        private readonly IConfiguration _configuration;

        private readonly IAppSettingsService _appSettingsService;

        public ProfileSearchController(IMemoryCache memoryCache, IConfiguration configuration, IAppSettingsService appSettingsService)
        {
            _cache = memoryCache;
            _configuration = configuration;
            _appSettingsService = appSettingsService;
        }

        /// <summary>
        /// Calculate simulation
        /// </summary>
        /// <param name="docnumber">System ID</param>
        /// <returns></returns>
        [HttpPost("EnqueueSearchByDocnumber")]
        public ActionResult<EnqueueResult> EnqueueSearchByDocnumber(int docnumber)
        {
            try
            {
                //schedulo con hangfire
                EnqueueResult model = new EnqueueResult(BackgroundJob.Enqueue((HangFireWorkers.SearchProfileByDocnumberWorker job) => job.Work(null, JobCancellationToken.Null, docnumber)));

                //var arxivarRestConfiguration = new IO.Swagger.Client.Configuration()
                //{
                //    BasePath = _appSettingsService.ARXivarNextWebApiUrl,
                //    ApiKey = new Dictionary<string, string>() { { "Authorization", Request.Headers["Authorization"] } },
                //    ApiKeyPrefix = new Dictionary<string, string>() { { "Authorization", "" } }
                //};


                //EnqueueResult model;
                //if (_cache.TryGetValue(id, out model))
                //    return model;

                //var engineCount = _engineInfoService.GetCountById(id);
                //if (engineCount == null)
                //    return StatusCode(404);
                //if (engineCount.C < 1)
                //    return StatusCode(404, string.Format("Id '{0}' not found.", id));
                //if (engineCount.C > 1)
                //    return StatusCode(403, string.Format("Id '{0}' found too many times {1}", id, engineCount.C));


                //var engineInfo = _engineInfoService.GetDataById(id);
                //if (engineInfo == null)
                //    return StatusCode(404);

                //model = _engineCalculator.Calculate(id, engineInfo);

                //_cache.Set(id, model, new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromMinutes(_appSettingsService.CacheMin)));

                return model;
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPost("EnqueueSearchCollectionByDocnumber")]
        public ActionResult<EnqueueResult[]> EnqueueSearchCollectionByDocnumber(int docnumber, int repeateCount)
        {
            try
            {
                EnqueueResult[] result = new EnqueueResult[repeateCount];
                for (int i = 0; i < repeateCount; i++)
                    result[i] = new EnqueueResult(BackgroundJob.Enqueue((HangFireWorkers.SearchProfileByDocnumberWorker job) => job.Work(null, JobCancellationToken.Null, docnumber)));
                return result;
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}