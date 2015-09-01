using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class GasTradePositionEndurExclusion
    {
        public int GasTradePositionEndurExclusionId { get; set; }
        public int EndurInstrumentTypeId { get; set; }
        public int EndurVolumeTypeId { get; set; }
        public virtual EndurInstrumentType EndurInstrumentType { get; set; }
        public virtual EndurVolumeType EndurVolumeType { get; set; }
    }
}
