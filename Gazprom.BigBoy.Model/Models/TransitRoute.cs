using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class TransitRoute
    {
        public TransitRoute()
        {
            this.TransitRouteLegs = new List<TransitRouteLeg>();
        }

        public int TransitRouteId { get; set; }
        public string Name { get; set; }
        public bool IsDisabled { get; set; }
        public System.DateTime EditedOn { get; set; }
        public string EditedBy { get; set; }
        public virtual ICollection<TransitRouteLeg> TransitRouteLegs { get; set; }
    }
}
