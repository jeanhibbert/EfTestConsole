using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class SendType
    {
        public SendType()
        {
            this.SendInformations = new List<SendInformation>();
        }

        public int SendTypeId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<SendInformation> SendInformations { get; set; }
    }
}
