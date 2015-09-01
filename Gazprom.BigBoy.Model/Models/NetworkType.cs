using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class NetworkType
    {
        public NetworkType()
        {
            this.GasNetworks = new List<GasNetwork>();
        }

        public int NetworkTypeId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<GasNetwork> GasNetworks { get; set; }
    }
}
