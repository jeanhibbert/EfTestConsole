using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class PositionAdjustView
    {
        public int GasTradePositionAdjustId { get; set; }
        public System.DateTime StartDateUtc { get; set; }
        public System.DateTime EndDateUtc { get; set; }
        public decimal Volume { get; set; }
        public string Counterparty { get; set; }
        public Nullable<System.DateTime> ProfileStartDateUtc { get; set; }
        public Nullable<System.DateTime> ProfileEndDateUtc { get; set; }
        public Nullable<decimal> ProfileVolume { get; set; }
        public string Unit { get; set; }
        public string ContractReference { get; set; }
        public int GasLocationId { get; set; }
        public string CapacityInstrumentType { get; set; }
        public Nullable<int> InternalShippingId { get; set; }
        public string InternalShippingCode { get; set; }
    }
}
