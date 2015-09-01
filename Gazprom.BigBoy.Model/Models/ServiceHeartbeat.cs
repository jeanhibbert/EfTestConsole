using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class ServiceHeartbeat
    {
        public string ServiceName { get; set; }
        public System.DateTime Heartbeat { get; set; }
        public Nullable<System.DateTime> LastRun { get; set; }
    }
}
