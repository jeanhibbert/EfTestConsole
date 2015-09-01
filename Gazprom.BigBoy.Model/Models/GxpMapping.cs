using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class GxpMapping
    {
        public int GxpMappingsId { get; set; }
        public int GasLocationId { get; set; }
        public string OurLocationCode { get; set; }
        public string GxpLocationCode { get; set; }
        public string OurShipperCode { get; set; }
        public string GxpShipperCode { get; set; }
        public string OurInternalShippingCode { get; set; }
        public string GxpInternalShippingCode { get; set; }
        public virtual GasLocation GasLocation { get; set; }
    }
}
