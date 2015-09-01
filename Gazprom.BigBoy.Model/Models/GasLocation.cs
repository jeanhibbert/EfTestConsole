using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class GasLocation
    {
        public GasLocation()
        {
            this.CapacityRouteLegs = new List<CapacityRouteLeg>();
            this.ConfirmationAnomolies = new List<ConfirmationAnomoly>();
            this.ExternalCapacityLocationMappings = new List<ExternalCapacityLocationMapping>();
            this.FlowLineNameMappings = new List<FlowLineNameMapping>();
            this.GasLocationGCVs = new List<GasLocationGCV>();
            this.GasLocationInstrumentMappings = new List<GasLocationInstrumentMapping>();
            this.GasLocationMappings = new List<GasLocationMapping>();
            this.GasPipelines = new List<GasPipeline>();
            this.GasPipelines1 = new List<GasPipeline>();
            this.GasShippers = new List<GasShipper>();
            this.GasTradePositionAdjusts = new List<GasTradePositionAdjust>();
            this.GxpMappings = new List<GxpMapping>();
            this.InternalShippings = new List<InternalShipping>();
            this.NominationShippers = new List<NominationShipper>();
        }

        public int GasLocationId { get; set; }
        public int GasNetworkId { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public int LocationTypeId { get; set; }
        public string GazpromTransitCode { get; set; }
        public string LocationCode { get; set; }
        public bool IsNominated { get; set; }
        public bool IsBalancing { get; set; }
        public bool ZeroNominated { get; set; }
        public double PointX { get; set; }
        public double PointY { get; set; }
        public string GazpromReference { get; set; }
        public decimal MatchingTolerance { get; set; }
        public bool ByHour { get; set; }
        public bool Hide { get; set; }
        public string GeminiNetworkId { get; set; }
        public bool IsLocationLevelBalancing { get; set; }
        public bool ConfirmationBeforeNomination { get; set; }
        public bool CapacityNetting { get; set; }
        public bool DisplayPendingOnZeroPosition { get; set; }
        public string GeminiExitNetwork { get; set; }
        public bool DoNotNominateHistoric { get; set; }
        public Nullable<int> DailyMeteredShipper { get; set; }
        public Nullable<int> NonDailyMeteredShipper { get; set; }
        public string TimezoneName { get; set; }
        public string CapacityTimezoneName { get; set; }
        public string TimezoneCode { get; set; }
        public string CapacityTimezoneCode { get; set; }
        public virtual ICollection<CapacityRouteLeg> CapacityRouteLegs { get; set; }
        public virtual ICollection<ConfirmationAnomoly> ConfirmationAnomolies { get; set; }
        public virtual ICollection<ExternalCapacityLocationMapping> ExternalCapacityLocationMappings { get; set; }
        public virtual ICollection<FlowLineNameMapping> FlowLineNameMappings { get; set; }
        public virtual GasShipper GasShipper { get; set; }
        public virtual GasNetwork GasNetwork { get; set; }
        public virtual LocationType LocationType { get; set; }
        public virtual GasShipper GasShipper1 { get; set; }
        public virtual ICollection<GasLocationGCV> GasLocationGCVs { get; set; }
        public virtual ICollection<GasLocationInstrumentMapping> GasLocationInstrumentMappings { get; set; }
        public virtual ICollection<GasLocationMapping> GasLocationMappings { get; set; }
        public virtual ICollection<GasPipeline> GasPipelines { get; set; }
        public virtual ICollection<GasPipeline> GasPipelines1 { get; set; }
        public virtual ICollection<GasShipper> GasShippers { get; set; }
        public virtual ICollection<GasTradePositionAdjust> GasTradePositionAdjusts { get; set; }
        public virtual ICollection<GxpMapping> GxpMappings { get; set; }
        public virtual ICollection<InternalShipping> InternalShippings { get; set; }
        public virtual ICollection<NominationShipper> NominationShippers { get; set; }
    }
}
