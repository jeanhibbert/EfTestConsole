using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class AccountableSB
    {
        public AccountableSB()
        {
            this.SBSBufferZones = new List<SBSBufferZone>();
        }

        public int AccountableSBSId { get; set; }
        public decimal EnergyData { get; set; }
        public int EnergyUnit { get; set; }
        public System.DateTime SBSDateTime { get; set; }
        public decimal SumHelpersEnergyAmount { get; set; }
        public decimal SumCausersEnergyAmount { get; set; }
        public virtual Unit Unit { get; set; }
        public virtual ICollection<SBSBufferZone> SBSBufferZones { get; set; }
    }
}
