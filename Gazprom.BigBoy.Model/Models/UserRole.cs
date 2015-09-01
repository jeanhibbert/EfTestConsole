using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class UserRole
    {
        public int UserRolesId { get; set; }
        public int User { get; set; }
        public int Role { get; set; }
        public string Comment { get; set; }
        public virtual Role Role1 { get; set; }
        public virtual User User1 { get; set; }
    }
}
