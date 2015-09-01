using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class ExternalCapacityLocationMappingAudit
    {
        public int ExternalCapacityLocationMappingId { get; set; }
        public int ParentLocationId { get; set; }
        public string LocationName { get; set; }
        public string EndurContractRef { get; set; }
        public string ExitCode { get; set; }
        public string EntryCode { get; set; }
        public string PipelineName { get; set; }
        public bool QueryGeminiForExitCapacity { get; set; }
        public string ExternalSource { get; set; }
        public System.DateTime EditedOn { get; set; }
        public string EditedBy { get; set; }
        public System.DateTime AuditDate { get; set; }
    }
}
