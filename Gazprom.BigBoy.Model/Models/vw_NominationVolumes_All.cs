using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class vw_NominationVolumes_All
    {
        public int NominationVolumesId { get; set; }
        public int NominationShipperId { get; set; }
        public int Hour { get; set; }
        public System.DateTime StartTime { get; set; }
        public System.DateTime EndTime { get; set; }
        public decimal VolumeNominated { get; set; }
        public decimal CounterpartyNominated { get; set; }
        public Nullable<decimal> AllocatedVolume { get; set; }
        public bool IsExitFlow { get; set; }
        public bool IsEntryFlow { get; set; }
        public string UpdatedBy { get; set; }
        public System.DateTime UpdatedOn { get; set; }
    }
}
