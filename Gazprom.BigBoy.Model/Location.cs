using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gazprom.BigBoy.Model
{
    public class Location
    {
        public long LocationId { get; set; }

        public long TimezoneId { get; set; }
        public virtual Timezone Timezone { get; set; }

    }
}
