using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class LocationType
    {
        public LocationType()
        {
            this.GasLocations = new List<GasLocation>();
        }

        public int LocationTypeId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<GasLocation> GasLocations { get; set; }
    }
}
