using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class Status
    {
        public Status()
        {
            this.ConfirmationAnomolies = new List<ConfirmationAnomoly>();
            this.Nominations = new List<Nomination>();
            this.NominationShippers = new List<NominationShipper>();
        }

        public int StatusId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<ConfirmationAnomoly> ConfirmationAnomolies { get; set; }
        public virtual ICollection<Nomination> Nominations { get; set; }
        public virtual ICollection<NominationShipper> NominationShippers { get; set; }
    }
}
