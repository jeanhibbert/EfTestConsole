namespace EfTestConsole.Demonstration
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Core.Objects;
    using System.Data.Entity.Infrastructure;
    using System.Linq;
    using System.Threading.Tasks;

    using EfTest.AdventurWorks.Model.EfHelpers;
    using EfTest.AdventureWorks.Data.SqlServer.EntityFramework;
    using EfTest.AdventureWorks.Data.SqlServer.EntityFramework.Repositories;
    using EfTest.AdventureWorks.Data.SqlServer.EntityFramework.UnitOfWork;
    using EfTest.AdventureWorks.Model.Models;

    using EfTestConsole.Helpers;

    using ContactRepository = EfTest.AdventureWorks.Data.SqlServer.Dapper.Repositories.ContactRepository;

    public static class EfRawSqlQueries
    {
        #region Public Methods and Operators

        public static void EfVsDapperTest()
        {
            string sql = "Select Top 10000 * from Person.Contact";

            while (true)
            {
                Console.WriteLine("-----------------------------------------------------");

                GeneratePerformanceOutput(TestDatabaseSqlQuery, "Database.SqlQuery", sql);

                GeneratePerformanceOutput(TestObjectContextExecuteStoreQuery, "ObjectContext.ExecuteStoreQuery", sql);

                GeneratePerformanceOutput(TestDbSetSqlQuery, "DbSet.SqlQuery", sql);

                GeneratePerformanceOutput(TestDbSetSqlQueryWithTransaction, "DbSet.SqlQuery.WithTransaction-ReadUncommitted", sql);

                GeneratePerformanceOutput(TestDbSetSqlQueryAsNoTracking, "DbSet.SqlQuery.AsNoTracking()", sql);

                using (new MeasureUtil("Custom rolled DbContext Scope"))
                using (var scope = DbContextScopeFactory<AdventureWorksContext>.CreateReadOnly())
                {
                    IEnumerable<Contact> contacts = scope.Context.Contacts.Take(10000);
                    DisplayContactListDetails(contacts.ToList());
                }

                using (new MeasureUtil("Dapper Serialisation"))
                using (var contactRepository = new ContactRepository())
                {
                    IEnumerable<Contact> contacts = contactRepository.Execute(sql);
                    DisplayContactListDetails(contacts.ToList());
                }

                using (new MeasureUtil("Massive Serialisation"))
                using (var contactRepository = new EfTest.AdventureWorks.Data.SqlServer.Massive.Repositories.ContactRepository())
                {
                    IEnumerable<dynamic> contacts = contactRepository.Query(sql);
                    DisplayContactListDetails(contacts.ToList());
                }

                Console.ReadKey();
            }
        }

        private static void DisplayContactListDetails(List<Contact> contactsList)
        {
            Console.WriteLine(contactsList.Count());
            Console.WriteLine(contactsList.First().ToString());
        }

        private static void DisplayContactListDetails(List<object> contactsList)
        {
            Console.WriteLine(contactsList.Count());
            Console.WriteLine(contactsList.First().ToString());
        }

        public static async Task<Product> FindProductAsync()
        {
            // Create and execute raw SQL query.
            using (var repository = new ProductRepository(new AdventureWorksContext()))
            {
                Product product =
                    await
                    repository.GetDbSet()
                              .SqlQuery("SELECT * FROM Production.Product WHERE ProductID = @p0", 1)
                              .SingleOrDefaultAsync();

                return product;
            }
        }

        public static void GeneratePerformanceOutput(
            Func<AdventureWorksContext, string, List<Contact>> dbCall, string outputMessage, string sql)
        {
            using (new MeasureUtil("Entity Framework Serialisation - " + outputMessage))
            using (var context = new AdventureWorksContext())
            {
                List<Contact> contactsList = dbCall(context, sql).ToList();
                DisplayContactListDetails(contactsList);
            }
        }

        public static List<Contact> TestDatabaseSqlQuery(AdventureWorksContext context, string sql)
        {
            DbRawSqlQuery<Contact> contacts = context.Database.SqlQuery<Contact>(sql);
            return contacts.ToList();
        }

        public static List<Contact> TestDbSetSqlQuery(AdventureWorksContext context, string sql)
        {
            DbSqlQuery<Contact> contacts = context.Contacts.SqlQuery(sql);
            return contacts.ToList();
        }

        public static List<Contact> TestDbSetSqlQueryAsNoTracking(AdventureWorksContext context, string sql)
        {
            DbSqlQuery<Contact> contacts = context.Contacts.SqlQuery(sql).AsNoTracking();
            return contacts.ToList();
        }

        public static List<Contact> TestDbSetSqlQueryWithTransaction(AdventureWorksContext context, string sql)
        {
            List<Contact> contacts = context.Contacts.SqlQuery(sql).ToListReadUncommitted();
            return contacts.ToList();
        }

        public static List<Contact> TestObjectContextExecuteStoreQuery(AdventureWorksContext context, string sql)
        {
            ObjectResult<Contact> contacts =
                ((IObjectContextAdapter)context).ObjectContext.ExecuteStoreQuery<Contact>(sql);
            return contacts.ToList();
        }

        #endregion
    }
}