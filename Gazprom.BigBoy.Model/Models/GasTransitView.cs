using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class GasTransitView
    {
        public int GasTransitId { get; set; }
        public System.DateTime StartDateUtc { get; set; }
        public System.DateTime EndDateUtc { get; set; }
        public decimal Volume { get; set; }
        public bool CheckExit { get; set; }
        public int GasPipelineId { get; set; }
        public string GasPipelineName { get; set; }
        public int GasLocationIdFrom { get; set; }
        public bool CheckEntry { get; set; }
        public int GasLocationIdTo { get; set; }
        public string ContractReferenceFrom { get; set; }
        public string ContractReferenceTo { get; set; }
        public string CapacityInstrumentTypeTo { get; set; }
        public string CapacityInstrumentTypeFrom { get; set; }
        public Nullable<int> TransitRouteId { get; set; }
        public Nullable<int> TransitRouteLegId { get; set; }
        public string TransitRouteLegFromLineName { get; set; }
        public string TransitRouteLegToLineName { get; set; }
        public string TransitRouteLegFromCapacityInstrumentType { get; set; }
        public string TransitRouteLegToCapacityInstrumentType { get; set; }
        public int FromInternalShippingId { get; set; }
        public int ToInternalShippingId { get; set; }
    }
}
