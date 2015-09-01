using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class GasTradePositionEndur
    {
        public int TradeId { get; set; }
        public string InstrumentType { get; set; }
        public int TranNum { get; set; }
        public int InstrumentNum { get; set; }
        public int VersionNumber { get; set; }
        public string TranStatus { get; set; }
        public string Trader { get; set; }
        public System.DateTime TradeDate { get; set; }
        public string Location { get; set; }
        public string Counterparty { get; set; }
        public string BuySell { get; set; }
        public System.DateTime StartDateUTC { get; set; }
        public System.DateTime EndDateUTC { get; set; }
        public decimal Volume { get; set; }
        public string Unit { get; set; }
        public string VolumeType { get; set; }
        public decimal Price { get; set; }
        public decimal Spread { get; set; }
        public string Currency { get; set; }
        public string DenominationPriceUnitName { get; set; }
        public string PriceType { get; set; }
        public string ServiceType { get; set; }
        public string LineName { get; set; }
        public string WthInj { get; set; }
        public string UpdatedByEngine { get; set; }
        public string UpdatedBy { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public string ContractRef { get; set; }
    }
}
