using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class CapacityDayCheck
    {
        public int CapacityDayCheckId { get; set; }
        public int GasNetworkId { get; set; }
        public string DayDescription { get; set; }
        public int Offset { get; set; }
        public virtual GasNetwork GasNetwork { get; set; }
    }
}
