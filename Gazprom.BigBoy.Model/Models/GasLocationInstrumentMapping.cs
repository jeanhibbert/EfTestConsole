using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class GasLocationInstrumentMapping
    {
        public int GasLocationInstrumentMappingId { get; set; }
        public int GasLocationId { get; set; }
        public int EndurInstrumentTypeId { get; set; }
        public virtual EndurInstrumentType EndurInstrumentType { get; set; }
        public virtual GasLocation GasLocation { get; set; }
    }
}
