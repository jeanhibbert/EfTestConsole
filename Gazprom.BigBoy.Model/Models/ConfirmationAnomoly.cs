using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class ConfirmationAnomoly
    {
        public int ConfirmationAnomolyId { get; set; }
        public int GasNetworkId { get; set; }
        public int GasLocationId { get; set; }
        public string Filename { get; set; }
        public System.DateTime ReceivedDate { get; set; }
        public System.DateTime DeliveryDate { get; set; }
        public int Status { get; set; }
        public string LocationCode { get; set; }
        public string Counterparty { get; set; }
        public string ShipperCode { get; set; }
        public string InternalShipperCode { get; set; }
        public System.DateTime StartDateUtc { get; set; }
        public System.DateTime EndDateUtc { get; set; }
        public decimal Volume { get; set; }
        public int UnitId { get; set; }
        public string UpdatedBy { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public bool Nominated { get; set; }
        public virtual GasLocation GasLocation { get; set; }
        public virtual GasNetwork GasNetwork { get; set; }
        public virtual Status Status1 { get; set; }
        public virtual Unit Unit { get; set; }
    }
}
