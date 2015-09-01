using System;
using System.Collections.Generic;

namespace Gazprom.BigBoy.Model.Models
{
    public partial class User
    {
        public User()
        {
            this.UserRoles = new List<UserRole>();
        }

        public int UserId { get; set; }
        public string NTLogin { get; set; }
        public string Username { get; set; }
        public bool Disabled { get; set; }
        public string EmailAddress { get; set; }
        public string MobileNumber { get; set; }
        public string WindowTitleCustomisation { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
