using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class InternalShipping
    {
        public InternalShipping()
        {
            this.GasPipelines = new List<GasPipeline>();
            this.GasPipelines1 = new List<GasPipeline>();
            this.GasTradePositionAdjusts = new List<GasTradePositionAdjust>();
            this.GasTransits = new List<GasTransit>();
            this.GasTransits1 = new List<GasTransit>();
            this.TransitRouteLegs = new List<TransitRouteLeg>();
            this.TransitRouteLegs1 = new List<TransitRouteLeg>();
        }

        public int InternalShippingId { get; set; }
        public int GasLocationId { get; set; }
        public string GazpromTransitCode { get; set; }
        public string InternalShippingCode { get; set; }
        public string ContractReference { get; set; }
        public string EndurContractRef { get; set; }
        public Nullable<int> NadAccountId { get; set; }
        public Nullable<int> EndurCapacityProductId { get; set; }
        public bool OverrideEnomAdjacentTransitCode { get; set; }
        public string OverrideEnomAdjacentLocation { get; set; }
        public string LineContractReference { get; set; }
        public virtual EndurCapacityProduct EndurCapacityProduct { get; set; }
        public virtual GasLocation GasLocation { get; set; }
        public virtual ICollection<GasPipeline> GasPipelines { get; set; }
        public virtual ICollection<GasPipeline> GasPipelines1 { get; set; }
        public virtual ICollection<GasTradePositionAdjust> GasTradePositionAdjusts { get; set; }
        public virtual ICollection<GasTransit> GasTransits { get; set; }
        public virtual ICollection<GasTransit> GasTransits1 { get; set; }
        public virtual NadAccount NadAccount { get; set; }
        public virtual ICollection<TransitRouteLeg> TransitRouteLegs { get; set; }
        public virtual ICollection<TransitRouteLeg> TransitRouteLegs1 { get; set; }
    }
}
