using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class GeminiDataUpdatedView
    {
        public System.DateTime CapacityDay { get; set; }
        public bool IsEntry { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
    }
}
