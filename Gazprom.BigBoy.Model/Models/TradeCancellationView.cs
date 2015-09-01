using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class TradeCancellationView
    {
        public int TradeCancellationId { get; set; }
        public System.DateTime StartDateUtc { get; set; }
        public System.DateTime EndDateUtc { get; set; }
        public decimal ActionIndicator { get; set; }
        public string Counterparty { get; set; }
        public int GasLocationId { get; set; }
    }
}
