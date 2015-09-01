using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class SBSBufferZone
    {
        public int SBSBufferZonesId { get; set; }
        public string ZoneName { get; set; }
        public System.DateTime ValidFrom { get; set; }
        public System.DateTime ValidTo { get; set; }
        public decimal BorderMaxEnergyAmount { get; set; }
        public decimal BorderMinEnergyAmount { get; set; }
        public int AccountableSBSId { get; set; }
        public virtual AccountableSB AccountableSB { get; set; }
    }
}
