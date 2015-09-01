using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class GTSDataSendInformation
    {
        public int GTSDataSendInformationId { get; set; }
        public string POSEmailers { get; set; }
        public string SBAEmailers { get; set; }
        public System.DateTime POSEmailSent { get; set; }
        public System.DateTime SBSEmailSent { get; set; }
    }
}
