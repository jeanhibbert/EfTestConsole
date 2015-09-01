using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class Role
    {
        public Role()
        {
            this.UserRoles = new List<UserRole>();
        }

        public int Roles { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int SecurityRoleId { get; set; }
        public virtual SecurityRole SecurityRole { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
