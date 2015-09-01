using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class Nomination
    {
        public Nomination()
        {
            this.NominationShippers = new List<NominationShipper>();
        }

        public int NominationId { get; set; }
        public int GasNetworkId { get; set; }
        public int Version { get; set; }
        public string Filename { get; set; }
        public System.DateTime SubmissionDateTime { get; set; }
        public System.DateTime DeliveryDate { get; set; }
        public int Status { get; set; }
        public string AcknowledgementFile { get; set; }
        public string ConfirmationFile { get; set; }
        public string AnomalyFile { get; set; }
        public bool Deleted { get; set; }
        public string UpdatedBy { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public int Unit { get; set; }
        public virtual GasNetwork GasNetwork { get; set; }
        public virtual Status Status1 { get; set; }
        public virtual Unit Unit1 { get; set; }
        public virtual ICollection<NominationShipper> NominationShippers { get; set; }
    }
}
