using Gazprom.BigBoy.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gazprom.Data
{
    public class EFTestDbContext : DbContext
    {
        public EFTestDbContext() : base("EFTest")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Timezone> Timezones { get; set; }
        public DbSet<Location> Locations { get; set; }
    }
}
