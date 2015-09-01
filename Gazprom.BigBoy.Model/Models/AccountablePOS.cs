using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class AccountablePOS
    {
        public int AccountablePOSId { get; set; }
        public int GasNetworkId { get; set; }
        public decimal EnergyVolume { get; set; }
        public int EnergyUnit { get; set; }
        public System.DateTime PosDateTimeInCET { get; set; }
        public System.DateTime DownloadTime { get; set; }
        public string PortfolioGasId { get; set; }
        public virtual GasNetwork GasNetwork { get; set; }
        public virtual Unit Unit { get; set; }
    }
}
