using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackOfficeService.Models
{
    public class EnqueueResult
    {
        public EnqueueResult()
        {

        }

        public EnqueueResult(string backgroundJobId)
        {
            BackgroundJobId = backgroundJobId;
        }

        /// <summary>
        /// Unique identifier of a background job.
        /// </summary>
        public string BackgroundJobId { get; set; }
    }
}
