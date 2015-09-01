using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class TransitRouteLeg
    {
        public int TransitRouteLegId { get; set; }
        public int TransitRouteId { get; set; }
        public int LegNumber { get; set; }
        public Nullable<int> FromShipperId { get; set; }
        public Nullable<int> ToShipperId { get; set; }
        public string FromCapacityInstrumentType { get; set; }
        public string ToCapacityInstrumentType { get; set; }
        public string FromLineName { get; set; }
        public string ToLineName { get; set; }
        public Nullable<int> PipelineId { get; set; }
        public virtual GasPipeline GasPipeline { get; set; }
        public virtual InternalShipping InternalShipping { get; set; }
        public virtual InternalShipping InternalShipping1 { get; set; }
        public virtual TransitRoute TransitRoute { get; set; }
    }
}