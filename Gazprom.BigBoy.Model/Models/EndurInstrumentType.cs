using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class EndurInstrumentType
    {
        public EndurInstrumentType()
        {
            this.CapacityRouteLegs = new List<CapacityRouteLeg>();
            this.GasLocationInstrumentMappings = new List<GasLocationInstrumentMapping>();
            this.GasTradePositionEndurExclusions = new List<GasTradePositionEndurExclusion>();
        }

        public int EndurInstrumentTypeId { get; set; }
        public string InstrumentName { get; set; }
        public Nullable<int> CommodityType { get; set; }
        public virtual ICollection<CapacityRouteLeg> CapacityRouteLegs { get; set; }
        public virtual CommodityType CommodityType1 { get; set; }
        public virtual ICollection<GasLocationInstrumentMapping> GasLocationInstrumentMappings { get; set; }
        public virtual ICollection<GasTradePositionEndurExclusion> GasTradePositionEndurExclusions { get; set; }
    }
}
