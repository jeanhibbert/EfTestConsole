using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class FlowLineNameMapping
    {
        public int FlowLineNameMappingId { get; set; }
        public int GasLocationId { get; set; }
        public string ShipperCode { get; set; }
        public string LineName { get; set; }
        public bool IsEntry { get; set; }
        public bool PublishToEndur { get; set; }
        public string InternalShippingCode { get; set; }
        public bool CreateTransitPair { get; set; }
        public virtual GasLocation GasLocation { get; set; }
    }
}
