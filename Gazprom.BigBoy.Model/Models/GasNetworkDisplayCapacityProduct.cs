using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class GasNetworkDisplayCapacityProduct
    {
        public int GasNetworkDisplayCapacityProductId { get; set; }
        public int GasNetworkId { get; set; }
        public int EndurCapacityProductId { get; set; }
        public string OverviewAbbreviation { get; set; }
        public virtual EndurCapacityProduct EndurCapacityProduct { get; set; }
        public virtual GasNetwork GasNetwork { get; set; }
    }
}
