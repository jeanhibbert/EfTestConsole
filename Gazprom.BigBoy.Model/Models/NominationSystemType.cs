using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class NominationSystemType
    {
        public NominationSystemType()
        {
            this.NominationParameters = new List<NominationParameter>();
            this.SendInformations = new List<SendInformation>();
            this.ShipperPreliminaryBalances = new List<ShipperPreliminaryBalance>();
        }

        public int NominationSystemTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<NominationParameter> NominationParameters { get; set; }
        public virtual ICollection<SendInformation> SendInformations { get; set; }
        public virtual ICollection<ShipperPreliminaryBalance> ShipperPreliminaryBalances { get; set; }
    }
}
