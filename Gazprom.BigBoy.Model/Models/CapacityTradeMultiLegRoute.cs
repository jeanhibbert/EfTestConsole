using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class CapacityTradeMultiLegRoute
    {
        public CapacityTradeMultiLegRoute()
        {
            this.CapacityRouteLegs = new List<CapacityRouteLeg>();
        }

        public int CapacityTradeMultiLegRouteId { get; set; }
        public string Name { get; set; }
        public string ParentEndurLineName { get; set; }
        public string ParentEndurCapacityType { get; set; }
        public virtual ICollection<CapacityRouteLeg> CapacityRouteLegs { get; set; }
    }
}
