using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class UserRolesView
    {
        public string Rolename { get; set; }
        public string UserLogin { get; set; }
        public int UserRoleId { get; set; }
        public bool Disabled { get; set; }
    }
}
