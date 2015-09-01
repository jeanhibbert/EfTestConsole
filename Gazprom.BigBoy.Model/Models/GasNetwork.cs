using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class GasNetwork
    {
        public GasNetwork()
        {
            this.AccountablePOS = new List<AccountablePOS>();
            this.CapacityDayChecks = new List<CapacityDayCheck>();
            this.ConfirmationAnomolies = new List<ConfirmationAnomoly>();
            this.GasLocations = new List<GasLocation>();
            this.GasNetworkDisplayCapacityProducts = new List<GasNetworkDisplayCapacityProduct>();
            this.GasNetwork1 = new List<GasNetwork>();
            this.Nominations = new List<Nomination>();
            this.NominationParameters = new List<NominationParameter>();
            this.PositionChecks = new List<PositionCheck>();
        }

        public int GasNetworkId { get; set; }
        public string Name { get; set; }
        public int BalancingTypeId { get; set; }
        public int BalancingUnitId { get; set; }
        public bool PositionNetting { get; set; }
        public int NetworkTypeId { get; set; }
        public Nullable<int> ParentNetworkId { get; set; }
        public Nullable<bool> ParentNominates { get; set; }
        public bool CodeSwitch { get; set; }
        public bool EntryExitNetwork { get; set; }
        public bool TransitNetwork { get; set; }
        public bool IncludeFutures { get; set; }
        public bool ProgramBalance { get; set; }
        public bool PreventSiblingNomination { get; set; }
        public double PointX { get; set; }
        public double PointY { get; set; }
        public bool IsNetworkLevelBalancing { get; set; }
        public bool Hide { get; set; }
        public bool CounterpartyMatches { get; set; }
        public bool OneFilePerContractRef { get; set; }
        public bool HourlyCapacityCheck { get; set; }
        public bool ExcludeFromParentTotal { get; set; }
        public string EICCode { get; set; }
        public bool UseBasicNominationAggregation { get; set; }
        public virtual ICollection<AccountablePOS> AccountablePOS { get; set; }
        public virtual BalancingType BalancingType { get; set; }
        public virtual ICollection<CapacityDayCheck> CapacityDayChecks { get; set; }
        public virtual ICollection<ConfirmationAnomoly> ConfirmationAnomolies { get; set; }
        public virtual ICollection<GasLocation> GasLocations { get; set; }
        public virtual ICollection<GasNetworkDisplayCapacityProduct> GasNetworkDisplayCapacityProducts { get; set; }
        public virtual Unit Unit { get; set; }
        public virtual ICollection<GasNetwork> GasNetwork1 { get; set; }
        public virtual GasNetwork GasNetwork2 { get; set; }
        public virtual NetworkType NetworkType { get; set; }
        public virtual ICollection<Nomination> Nominations { get; set; }
        public virtual ICollection<NominationParameter> NominationParameters { get; set; }
        public virtual ICollection<PositionCheck> PositionChecks { get; set; }
    }
}
