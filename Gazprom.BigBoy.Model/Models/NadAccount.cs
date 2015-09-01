using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class NadAccount
    {
        public NadAccount()
        {
            this.InternalShippings = new List<InternalShipping>();
        }

        public int NadAccountId { get; set; }
        public int NominationsParametersId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<InternalShipping> InternalShippings { get; set; }
        public virtual NominationParameter NominationParameter { get; set; }
    }
}
