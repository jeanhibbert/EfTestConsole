using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class PositionCheck
    {
        public int PositionCheckId { get; set; }
        public Nullable<int> GasNetworkId { get; set; }
        public Nullable<int> GasLocationId { get; set; }
        public int UnitId { get; set; }
        public string Abbreviation { get; set; }
        public Nullable<int> Rounding { get; set; }
        public string TimezoneName { get; set; }
        public string TimezoneCode { get; set; }
        public virtual GasNetwork GasNetwork { get; set; }
        public virtual Unit Unit { get; set; }
    }
}
