using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class KeyPerformanceIndicator
    {
        public int KPI_ID { get; set; }
        public string KeyPerformanceIndicator1 { get; set; }
        public System.DateTime StartTime { get; set; }
        public System.DateTime EndTime { get; set; }
        public string User { get; set; }
        public string Machine { get; set; }
        public int ElapsedMilliseconds { get; set; }
        public int ElapsedTicks { get; set; }
    }
}
