using EfTest.AdventureWorks.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfTestConsole.Demonstration
{
    using System.Data.Entity.Core.Objects;

    using EfTest.AdventureWorks.Data.SqlServer;
    using EfTest.AdventureWorks.Data.SqlServer.Dapper.Repositories;
    using EfTest.AdventureWorks.Data.SqlServer.EntityFramework;
    using EfTest.AdventureWorks.Data.SqlServer.EntityFramework.Repositories;

    using EfTestConsole.Helpers;
    using System.Data.Entity.Infrastructure;

    public static class EfRawSqlQueries
    {
        public static async Task<Product> FindProductAsync()
        {
            // Create and execute raw SQL query.
            using (var repository = new ProductRepository(new AdventureWorksContext()))
            {
                Product product = await 
                    repository.GetDbSet()
                              .SqlQuery("SELECT * FROM Production.Product WHERE ProductID = @p0", 1)
                              .SingleOrDefaultAsync();

                return product;
            }
        }

        public static void EfVsDapperTest()
        {
            var sql = "Select Top 10000 * from Person.Contact";

            while (true)
            {
                using (new MeasureUtil("Entity Framework Serialisation - Database.SqlQuery"))
                using (var context = new AdventureWorksContext())
                {
                    DbRawSqlQuery<Contact> contacts = context.Database.SqlQuery<Contact>(sql);
                    List<Contact> contactsList = contacts.ToList();
                    Console.WriteLine(contactsList.Count());
                    Console.WriteLine(contactsList.First().ToString());
                }

                using (new MeasureUtil("Entity Framework Serialisation - Execute Store Query"))
                using (var context = new AdventureWorksContext())
                {
                    ObjectResult<Contact> contacts = ((IObjectContextAdapter)context).ObjectContext.ExecuteStoreQuery<Contact>(sql);
                    List<Contact> contactsList = contacts.ToList();
                    Console.WriteLine(contactsList.Count());
                    Console.WriteLine(contactsList.First().ToString());
                }

                using (new MeasureUtil("Dapper Serialisation"))
                using (
                    var contactRepository =
                        new EfTest.AdventureWorks.Data.SqlServer.Dapper.Repositories.ContactRepository())
                {
                    IEnumerable<Contact> contacts = contactRepository.Execute(sql);
                    List<Contact> contactsList = contacts.ToList();
                    Console.WriteLine(contactsList.Count());
                    Console.WriteLine(contactsList.First().ToString());
                }
                Console.ReadKey();
                //TODO: Test without proxy generation
            }
        }

    }
}
