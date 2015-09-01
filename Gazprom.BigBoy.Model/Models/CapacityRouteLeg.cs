using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class CapacityRouteLeg
    {
        public int CapacityRouteLegId { get; set; }
        public int RouteId { get; set; }
        public int LegNumber { get; set; }
        public int InstrumentTypeId { get; set; }
        public int GasLocationId { get; set; }
        public int GasPipelineId { get; set; }
        public virtual CapacityTradeMultiLegRoute CapacityTradeMultiLegRoute { get; set; }
        public virtual EndurInstrumentType EndurInstrumentType { get; set; }
        public virtual GasLocation GasLocation { get; set; }
        public virtual GasPipeline GasPipeline { get; set; }
    }
}
