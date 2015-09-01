using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class BalancingType
    {
        public BalancingType()
        {
            this.GasNetworks = new List<GasNetwork>();
        }

        public int BalancingTypeId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<GasNetwork> GasNetworks { get; set; }
    }
}
