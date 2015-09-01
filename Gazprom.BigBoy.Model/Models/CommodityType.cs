using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class CommodityType
    {
        public CommodityType()
        {
            this.EndurInstrumentTypes = new List<EndurInstrumentType>();
        }

        public int CommodityTypeId { get; set; }
        public string CommodityName { get; set; }
        public virtual ICollection<EndurInstrumentType> EndurInstrumentTypes { get; set; }
    }
}
