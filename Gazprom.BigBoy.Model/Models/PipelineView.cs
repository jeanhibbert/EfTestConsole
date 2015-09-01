using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class PipelineView
    {
        public int GasPipelineId { get; set; }
        public string Name { get; set; }
        public int FromLocationId { get; set; }
        public int ToLocationId { get; set; }
        public string FromLocationExitLineName { get; set; }
        public string ToLocationEntryLineName { get; set; }
        public bool CheckExit { get; set; }
        public bool CheckEntry { get; set; }
        public bool IsExternal { get; set; }
        public string FromLocationDisplayName { get; set; }
        public string ToLocationDisplayName { get; set; }
        public decimal FuelGas { get; set; }
        public decimal UpliftFactor { get; set; }
        public Nullable<int> FromInternalShippingId { get; set; }
        public Nullable<int> ToInternalShippingId { get; set; }
        public bool RedeliveryTransitItem { get; set; }
        public bool IsVirtual { get; set; }
        public string FromInternalShipperCode { get; set; }
        public string ToInternalShipperCode { get; set; }
        public Nullable<bool> Hide { get; set; }
    }
}
