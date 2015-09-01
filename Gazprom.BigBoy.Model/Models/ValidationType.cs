using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class ValidationType
    {
        public ValidationType()
        {
            this.NominationValidations = new List<NominationValidation>();
        }

        public int ValidationTypeId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<NominationValidation> NominationValidations { get; set; }
    }
}
