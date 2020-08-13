using System;
using System.Collections.Generic;
using System.Text;

namespace BackOfficeFramework
{
    public class ChronoModel
    {
        public Guid Id { get; set; }
        public Guid ParentId { get; set; }


        public string ActionDescription { get; set; }

        public DateTime ScheduledTime { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public double MSecDuration { get; set; }

        public string Parameters { get; set; }        
    }
}
