using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class SecurityRole
    {
        public SecurityRole()
        {
            this.Roles = new List<Role>();
        }

        public int SecurityRolesId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
    }
}
