using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class Timezone
    {
        public int TimezoneId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public short GasDayLocalStartHour { get; set; }
        public System.DateTime StartUtc { get; set; }
        public System.DateTime EndUtc { get; set; }
    }
}
