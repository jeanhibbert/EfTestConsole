using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class NominationValidation
    {
        public int NominationValidationId { get; set; }
        public string ContractRef { get; set; }
        public int ValidationTypeId { get; set; }
        public virtual ValidationType ValidationType { get; set; }
    }
}
