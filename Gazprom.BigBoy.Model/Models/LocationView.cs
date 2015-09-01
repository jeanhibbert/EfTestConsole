using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class LocationView
    {
        public int GasLocationId { get; set; }
        public string DisplayName { get; set; }
        public string TimeZoneCode { get; set; }
        public string TimezoneName { get; set; }
        public bool CapacityNetting { get; set; }
        public int GasNetworkId { get; set; }
        public string CapacityTimeZoneCode { get; set; }
        public string CapacityTimeZoneName { get; set; }
        public bool IsNominated { get; set; }
        public int LocationTypeId { get; set; }
        public string GazpromTransitCode { get; set; }
    }
}
