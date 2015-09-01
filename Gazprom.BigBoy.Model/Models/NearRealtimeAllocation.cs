using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class NearRealtimeAllocation
    {
        public int NearRealtimeAllocationsId { get; set; }
        public string NetworkPointName { get; set; }
        public System.DateTime AllocationDateTime { get; set; }
        public decimal EnergyVolume { get; set; }
        public int EnergyUnit { get; set; }
        public decimal ConfirmedEnergyVolume { get; set; }
        public int ConfirmedEnergyUnit { get; set; }
        public decimal CalorificMeasure { get; set; }
        public int CalorificMeasureUnit { get; set; }
        public System.DateTime DownloadDateTime { get; set; }
        public string GasLocation { get; set; }
        public virtual Unit Unit { get; set; }
        public virtual Unit Unit1 { get; set; }
        public virtual Unit Unit2 { get; set; }
    }
}
