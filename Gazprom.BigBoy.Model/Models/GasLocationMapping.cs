using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class GasLocationMapping
    {
        public int GasLocationMappingId { get; set; }
        public int GasLocationId { get; set; }
        public string Name { get; set; }
        public virtual GasLocation GasLocation { get; set; }
    }
}
