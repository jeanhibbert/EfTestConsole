using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class LocationMappingView
    {
        public int GasLocationId { get; set; }
        public string EndurLocationName { get; set; }
        public string EndurInstrumentName { get; set; }
    }
}
