using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class NominationShipper_Archive
    {
        public int NomiantionShipperId { get; set; }
        public string CounterpartyName { get; set; }
        public Nullable<int> ShipperId { get; set; }
        public string ShipperCode { get; set; }
        public Nullable<int> InternalShippingId { get; set; }
        public System.DateTime DeliveryDate { get; set; }
        public int Status { get; set; }
        public int GasLocationId { get; set; }
        public string LocationCode { get; set; }
        public int NominationId { get; set; }
        public int version { get; set; }
        public bool IsLatest { get; set; }
        public bool IsBuy { get; set; }
        public Nullable<System.DateTime> ConfirmCreatedDate { get; set; }
        public Nullable<int> EffectiveHour { get; set; }
    }
}
