using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class ShipperPreliminaryBalance
    {
        public int ShipperPreliminaryBalanceId { get; set; }
        public System.DateTime DeliveryDay { get; set; }
        public decimal SumRequestedDailyMetered { get; set; }
        public decimal SumRequestedNonDailyMetered { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public int NominationsSystemTypeId { get; set; }
        public virtual NominationSystemType NominationSystemType { get; set; }
    }
}
