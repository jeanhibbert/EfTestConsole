using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class Unit
    {
        public Unit()
        {
            this.AccountablePOS = new List<AccountablePOS>();
            this.AccountableSBS = new List<AccountableSB>();
            this.ConfirmationAnomolies = new List<ConfirmationAnomoly>();
            this.GasNetworks = new List<GasNetwork>();
            this.GasTradePositionAdjusts = new List<GasTradePositionAdjust>();
            this.GasTransits = new List<GasTransit>();
            this.NearRealtimeAllocations = new List<NearRealtimeAllocation>();
            this.NearRealtimeAllocations1 = new List<NearRealtimeAllocation>();
            this.NearRealtimeAllocations2 = new List<NearRealtimeAllocation>();
            this.Nominations = new List<Nomination>();
            this.PositionChecks = new List<PositionCheck>();
        }

        public int UnitId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public bool IsRate { get; set; }
        public int RoundDecimalPlaces { get; set; }
        public bool ApplyHourlyBalancing { get; set; }
        public bool Deleted { get; set; }
        public virtual ICollection<AccountablePOS> AccountablePOS { get; set; }
        public virtual ICollection<AccountableSB> AccountableSBS { get; set; }
        public virtual ICollection<ConfirmationAnomoly> ConfirmationAnomolies { get; set; }
        public virtual ICollection<GasNetwork> GasNetworks { get; set; }
        public virtual ICollection<GasTradePositionAdjust> GasTradePositionAdjusts { get; set; }
        public virtual ICollection<GasTransit> GasTransits { get; set; }
        public virtual ICollection<NearRealtimeAllocation> NearRealtimeAllocations { get; set; }
        public virtual ICollection<NearRealtimeAllocation> NearRealtimeAllocations1 { get; set; }
        public virtual ICollection<NearRealtimeAllocation> NearRealtimeAllocations2 { get; set; }
        public virtual ICollection<Nomination> Nominations { get; set; }
        public virtual ICollection<PositionCheck> PositionChecks { get; set; }
    }
}
