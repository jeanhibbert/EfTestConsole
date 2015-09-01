using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class EndurCapacityProduct
    {
        public EndurCapacityProduct()
        {
            this.GasNetworkDisplayCapacityProducts = new List<GasNetworkDisplayCapacityProduct>();
            this.InternalShippings = new List<InternalShipping>();
        }

        public int EndurCapacityProductId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<GasNetworkDisplayCapacityProduct> GasNetworkDisplayCapacityProducts { get; set; }
        public virtual ICollection<InternalShipping> InternalShippings { get; set; }
    }
}
