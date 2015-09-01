using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class NominationMessagesView
    {
        public int NominationId { get; set; }
        public int NomiantionShipperId { get; set; }
        public int GasNetworkId { get; set; }
        public string LocationCode { get; set; }
        public string ShipperCode { get; set; }
        public string EnomToNad { get; set; }
        public string EnomContractRef { get; set; }
    }
}
