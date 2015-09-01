using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class GasTradeAdjustProfile
    {
        public int GasTradeAdjustProfileId { get; set; }
        public int GasTradePositionAdjustId { get; set; }
        public System.DateTime StartDateUTC { get; set; }
        public System.DateTime EndDateUTC { get; set; }
        public decimal Volume { get; set; }
        public string UpdatedBy { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public virtual GasTradePositionAdjust GasTradePositionAdjust { get; set; }
    }
}
