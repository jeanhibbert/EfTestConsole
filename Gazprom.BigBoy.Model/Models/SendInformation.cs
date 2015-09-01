using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class SendInformation
    {
        public int SendInformationId { get; set; }
        public Nullable<int> NominationsSystemTypeId { get; set; }
        public int SendTypeId { get; set; }
        public string LiveFileShare { get; set; }
        public string GeminiRoot { get; set; }
        public string GeminiLogin { get; set; }
        public string GeminiPassword { get; set; }
        public string LiveEmailAddress { get; set; }
        public string FromEmailAddress { get; set; }
        public Nullable<System.DateTime> LastPasswordResetUtc { get; set; }
        public string CopyFileShare { get; set; }
        public string SendInformationName { get; set; }
        public string GeminiServiceIdBuy { get; set; }
        public string GeminiServiceIdSell { get; set; }
        public virtual NominationSystemType NominationSystemType { get; set; }
        public virtual SendType SendType { get; set; }
    }
}
