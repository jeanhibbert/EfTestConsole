using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class GasShipper
    {
        public GasShipper()
        {
            this.GasLocations = new List<GasLocation>();
            this.GasLocations1 = new List<GasLocation>();
            this.GasShipper1 = new List<GasShipper>();
        }

        public int GasShipperId { get; set; }
        public int GasLocationId { get; set; }
        public string Counterparty { get; set; }
        public string ShipperCode { get; set; }
        public bool Notify { get; set; }
        public bool IncludeInPosition { get; set; }
        public System.DateTime ValidFrom { get; set; }
        public System.DateTime ValidTo { get; set; }
        public bool Deleted { get; set; }
        public Nullable<int> DuplicateTrades { get; set; }
        public bool InvertDuplicateTrades { get; set; }
        public virtual ICollection<GasLocation> GasLocations { get; set; }
        public virtual ICollection<GasLocation> GasLocations1 { get; set; }
        public virtual GasLocation GasLocation { get; set; }
        public virtual ICollection<GasShipper> GasShipper1 { get; set; }
        public virtual GasShipper GasShipper2 { get; set; }
    }
}
