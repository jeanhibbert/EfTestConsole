using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gazprom.BigBoy.Model.Models
{
    public class Permission
    {
        public int PermissionId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
