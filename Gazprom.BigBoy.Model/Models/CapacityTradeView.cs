using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class CapacityTradeView
    {
        public string TradeId { get; set; }
        public string CapacityProduct { get; set; }
        public System.DateTime StartDateUTC { get; set; }
        public System.DateTime EndDateUTC { get; set; }
        public decimal Volume { get; set; }
        public string Unit { get; set; }
        public string Counterparty { get; set; }
        public string ContractReference { get; set; }
        public string BuySell { get; set; }
        public string LineName { get; set; }
        public string CapacityInstrumentType { get; set; }
    }
}
