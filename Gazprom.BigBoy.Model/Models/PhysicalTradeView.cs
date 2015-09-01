using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class PhysicalTradeView
    {
        public int TradeId { get; set; }
        public System.DateTime StartDateUtc { get; set; }
        public System.DateTime EndDateUtc { get; set; }
        public decimal Volume { get; set; }
        public string Unit { get; set; }
        public string ContractReference { get; set; }
        public string BuySell { get; set; }
        public string Counterparty { get; set; }
        public string EndurLocation { get; set; }
        public string CapacityInstrumentType { get; set; }
    }
}
