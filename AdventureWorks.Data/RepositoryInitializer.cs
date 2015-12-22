using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks.Data
{
    using EfTest.AdventureWorks.Model.Models;

    public class RepositoryInitializer
    {
        private IUnitOfWork unitOfWork;

        public RepositoryInitializer(IUnitOfWork unitOfWork)
        {
            if (unitOfWork == null)
            {
                throw new ArgumentNullException("unitOfWork");
            }

            this.unitOfWork = unitOfWork;

            Database.DefaultConnectionFactory = new SqlCeConnectionFactory("System.Data.SqlServerCe.4.0");

            // Sets the default database initialization code for working with Sql Server Compact databases
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<AdventureWorksContext>());
        }

        protected AdventureWorksContext Context
        {
            get { return (AdventureWorksContext)this.unitOfWork; }
        }

        public void Initialize()
        {
            this.Context.Set<AdventureWorksContext>().ToList().Count();

            var indexes = this.Context.Database.SqlQuery<string>("SELECT INDEX_NAME FROM INFORMATION_SCHEMA.INDEXES;");

            if (!indexes.Contains("IDX_FillupEntries_FillupEntryId"))
            {
                this.Context.Database.ExecuteSqlCommand("CREATE UNIQUE INDEX IDX_FillupEntries_FillupEntryId ON FillupEntries (FillupEntryId);");
            }

            if (!indexes.Contains("IDX_Reminders_ReminderId"))
            {
                this.Context.Database.ExecuteSqlCommand("CREATE UNIQUE INDEX IDX_Reminders_ReminderId ON Reminders (ReminderId);");
            }

            if (!indexes.Contains("IDX_VehiclePhotos_VehiclePhotoId"))
            {
                this.Context.Database.ExecuteSqlCommand("CREATE UNIQUE INDEX IDX_VehiclePhotos_VehiclePhotoId ON VehiclePhotos (VehiclePhotoId);");
            }
        }
    }
}
