using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class AutoFlow
    {
        public int AutoFlowId { get; set; }
        public int GasPipelineId { get; set; }
        public bool Disable { get; set; }
        public virtual GasPipeline GasPipeline { get; set; }
    }
}
