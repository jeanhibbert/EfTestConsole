using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class UkLocationMappingView
    {
        public int ParentLocationId { get; set; }
        public string LocationName { get; set; }
        public string EndurContractRef { get; set; }
        public string PipelineName { get; set; }
    }
}
