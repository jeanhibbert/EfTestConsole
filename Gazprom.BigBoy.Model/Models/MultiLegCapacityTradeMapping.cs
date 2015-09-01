using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class MultiLegCapacityTradeMapping
    {
        public int MultiLegCapacityTradeMappingId { get; set; }
        public string ParentEndurLineName { get; set; }
        public string ParentEndurCapacityType { get; set; }
        public int LegNumber { get; set; }
        public int GasLocationId { get; set; }
        public int InstrumentTypeId { get; set; }
        public int GasPipelineId { get; set; }
        public string GasLocationDisplayName { get; set; }
        public string CapacityProduct { get; set; }
        public string LineName { get; set; }
    }
}
