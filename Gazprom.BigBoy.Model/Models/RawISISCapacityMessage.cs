using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class RawISISCapacityMessage
    {
        public int RawISISCapacityMessageId { get; set; }
        public System.DateTime MessageReceivedAt { get; set; }
        public string MessageContents { get; set; }
    }
}
