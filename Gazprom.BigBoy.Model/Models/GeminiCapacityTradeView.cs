using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class GeminiCapacityTradeView
    {
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public System.DateTime CapacityDay { get; set; }
        public Nullable<decimal> NetFirmCapacity { get; set; }
        public Nullable<decimal> NetInterruptibleCapacity { get; set; }
        public bool IsEntry { get; set; }
        public string ContractReference { get; set; }
        public int GasLocationId { get; set; }
        public string PipelineName { get; set; }
        public string ExternalSource { get; set; }
    }
}
