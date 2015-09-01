using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class NominationParameter
    {
        public NominationParameter()
        {
            this.NadAccounts = new List<NadAccount>();
        }

        public int NominationsParametersId { get; set; }
        public int GasNetworkId { get; set; }
        public int NominationSystemTypeId { get; set; }
        public Nullable<bool> EnomXML { get; set; }
        public Nullable<bool> EnomEDI { get; set; }
        public string EnomFrom { get; set; }
        public string EnomFromNad { get; set; }
        public string EnomTo { get; set; }
        public string EnomToNad { get; set; }
        public string EnomUnit { get; set; }
        public string EnomContractRef { get; set; }
        public string EnomGCVUnit { get; set; }
        public Nullable<decimal> EnomGCV { get; set; }
        public bool EnomUseQualifiedValues { get; set; }
        public bool EnomAlwaysInputOutput { get; set; }
        public bool IsHourlyNominated { get; set; }
        public bool Enom1MessagePerPoint { get; set; }
        public Nullable<int> EnomVersion { get; set; }
        public decimal EnomShrinkageFactor { get; set; }
        public string ZeroNominationsPoint { get; set; }
        public Nullable<bool> EnomIsHubNotice { get; set; }
        public Nullable<bool> IsStorageNotice { get; set; }
        public string InternalShipperCode { get; set; }
        public string EnomVersionType { get; set; }
        public Nullable<bool> RemoveEnomTags { get; set; }
        public bool EnomBDRMessage { get; set; }
        public bool CapacityNomination { get; set; }
        public bool UseEICCodeForConnectedNetwork { get; set; }
        public Nullable<bool> ContractRefAndInternalShipperPair { get; set; }
        public Nullable<short> EnomOverrideGasDayStartHour { get; set; }
        public virtual GasNetwork GasNetwork { get; set; }
        public virtual ICollection<NadAccount> NadAccounts { get; set; }
        public virtual NominationSystemType NominationSystemType { get; set; }
    }
}
