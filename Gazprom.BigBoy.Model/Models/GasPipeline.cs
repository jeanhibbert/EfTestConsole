using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class GasPipeline
    {
        public GasPipeline()
        {
            this.AutoFlows = new List<AutoFlow>();
            this.CapacityRouteLegs = new List<CapacityRouteLeg>();
            this.GasTransits = new List<GasTransit>();
            this.TransitRouteLegs = new List<TransitRouteLeg>();
        }

        public int GasPipelineId { get; set; }
        public string Name { get; set; }
        public int FromLocationId { get; set; }
        public int ToLocationId { get; set; }
        public bool IsVirtual { get; set; }
        public decimal UpliftFactor { get; set; }
        public decimal FuelGas { get; set; }
        public string FromLocationExitLineName { get; set; }
        public string ToLocationEntryLineName { get; set; }
        public bool CheckExit { get; set; }
        public bool CheckEntry { get; set; }
        public string FromLocationShipperCode { get; set; }
        public string ToLocationShipperCode { get; set; }
        public bool ApplyPipelineCapacity { get; set; }
        public bool IsExternal { get; set; }
        public bool RedeliveryTransitItem { get; set; }
        public Nullable<int> FromInternalShippingId { get; set; }
        public Nullable<int> ToInternalShippingId { get; set; }
        public Nullable<bool> Hide { get; set; }
        public virtual ICollection<AutoFlow> AutoFlows { get; set; }
        public virtual ICollection<CapacityRouteLeg> CapacityRouteLegs { get; set; }
        public virtual GasLocation GasLocation { get; set; }
        public virtual GasLocation GasLocation1 { get; set; }
        public virtual InternalShipping InternalShipping { get; set; }
        public virtual InternalShipping InternalShipping1 { get; set; }
        public virtual ICollection<GasTransit> GasTransits { get; set; }
        public virtual ICollection<TransitRouteLeg> TransitRouteLegs { get; set; }
    }
}
