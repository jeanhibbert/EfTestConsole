using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class GasLocationGCV
    {
        public int GasLocationGCVId { get; set; }
        public int GasLocationId { get; set; }
        public System.DateTime ValidFrom { get; set; }
        public System.DateTime ValidTo { get; set; }
        public decimal CalorificValue { get; set; }
        public virtual GasLocation GasLocation { get; set; }
    }
}
