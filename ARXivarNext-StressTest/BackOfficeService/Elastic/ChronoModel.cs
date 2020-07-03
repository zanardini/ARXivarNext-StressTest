using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackOfficeService.Elastic
{
    public class ChronoModel
    {
        public string ActionDescription { get; set; }
        
        public DateTime ScheduledTime { get; set; }
        
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public double MSecDuration { get; set; }

        public string Parameters { get; set; }


    }
}
