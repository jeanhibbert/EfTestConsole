using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class Entitlement
    {
        public System.DateTime CapacityDay { get; set; }
        public Nullable<int> NetCapacity { get; set; }
        public Nullable<int> NetFirmCapacity { get; set; }
        public Nullable<int> NetInterruptibleCapacity { get; set; }
        public Nullable<int> NetScaledInterruptibleCapacity { get; set; }
        public string Location { get; set; }
        public int RecordNumber { get; set; }
        public bool IsEntry { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
    }
}
