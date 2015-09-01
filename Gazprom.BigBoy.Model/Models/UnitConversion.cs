using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class UnitConversion
    {
        public int UnitConversionId { get; set; }
        public string Unit { get; set; }
        public bool IsRate { get; set; }
        public bool IsGcvFactor { get; set; }
        public decimal ToKwhFactor { get; set; }
    }
}
