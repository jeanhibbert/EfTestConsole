using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class GasTradePositionAdjust
    {
        public GasTradePositionAdjust()
        {
            this.GasTradeAdjustProfiles = new List<GasTradeAdjustProfile>();
        }

        public int GasTradePositionAdjustId { get; set; }
        public string Counterparty { get; set; }
        public Nullable<int> InternalShippingId { get; set; }
        public int GasLocationId { get; set; }
        public System.DateTime StartDateUTC { get; set; }
        public System.DateTime EndDateUTC { get; set; }
        public System.DateTime TradeDate { get; set; }
        public int UnitId { get; set; }
        public decimal Volume { get; set; }
        public bool Cancel { get; set; }
        public string UpdatedBy { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public virtual GasLocation GasLocation { get; set; }
        public virtual ICollection<GasTradeAdjustProfile> GasTradeAdjustProfiles { get; set; }
        public virtual InternalShipping InternalShipping { get; set; }
        public virtual Unit Unit { get; set; }
    }
}
