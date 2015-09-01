using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class GasTransit
    {
        public int GasTransitId { get; set; }
        public int GasPipelineId { get; set; }
        public int UnitId { get; set; }
        public System.DateTime StartDateUTC { get; set; }
        public System.DateTime EndDateUTC { get; set; }
        public Nullable<int> FromInternalShippingId { get; set; }
        public decimal Volume { get; set; }
        public string UpdatedBy { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public Nullable<int> ToInternalShippingId { get; set; }
        public Nullable<int> TransitRouteId { get; set; }
        public Nullable<int> TransitRouteLegId { get; set; }
        public virtual GasPipeline GasPipeline { get; set; }
        public virtual InternalShipping InternalShipping { get; set; }
        public virtual InternalShipping InternalShipping1 { get; set; }
        public virtual Unit Unit { get; set; }
    }
}
