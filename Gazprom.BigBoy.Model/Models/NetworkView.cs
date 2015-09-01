using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class NetworkView
    {
        public int GasNetworkId { get; set; }
        public string Name { get; set; }
        public bool HourlyCapacityCheck { get; set; }
        public int BalancingTypeId { get; set; }
        public string BalancingTypeName { get; set; }
        public Nullable<int> ParentNetworkId { get; set; }
        public bool PreventSiblingNomination { get; set; }
        public bool PositionNetting { get; set; }
        public bool CodeSwitch { get; set; }
    }
}
