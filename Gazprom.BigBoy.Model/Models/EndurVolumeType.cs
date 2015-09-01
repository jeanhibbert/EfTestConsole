using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class EndurVolumeType
    {
        public EndurVolumeType()
        {
            this.GasTradePositionEndurExclusions = new List<GasTradePositionEndurExclusion>();
        }

        public int EndurVolumeTypeId { get; set; }
        public string EndurVolumeTypeName { get; set; }
        public virtual ICollection<GasTradePositionEndurExclusion> GasTradePositionEndurExclusions { get; set; }
    }
}
