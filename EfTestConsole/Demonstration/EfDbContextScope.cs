namespace EfTestConsole.Demonstration
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;

    using EfTest.AdventureWorks.Data.SqlServer.EntityFramework;
    using EfTest.AdventureWorks.Data.SqlServer.EntityFramework.UnitOfWork;
    using EfTest.AdventureWorks.Model.Models;

    using EfTestConsole.Helpers;

    public static class EfDbContextScope
    {
        public static void EfDbContextScopeTest()
        {
            using (
                IDbContextScope<AdventureWorksContext> contextScope =
                    DbContextScopeFactory<AdventureWorksContext>.CreateWithTransaction(IsolationLevel.Serializable))
            {
                Department dept = contextScope.Context.Departments.Find(1);
                dept.Name += ": Test";
                Console.WriteLine(contextScope.Context.ChangeTracker.Entries().Count());
                Console.WriteLine(contextScope.Context.ChangeTracker.Entries().First().State);
                Console.WriteLine(contextScope.Context.ChangeTracker.HasChanges());
                contextScope.SaveChanges();
                Console.WriteLine(contextScope.Context.ChangeTracker.Entries().Count());
                Console.WriteLine(contextScope.Context.ChangeTracker.Entries().First().State);
                Console.WriteLine(contextScope.Context.ChangeTracker.HasChanges());
            }

            using (new MeasureUtil("ContextScopeFactory Performance Test 1000 Contacts"))
            using (
                IDbContextScope<AdventureWorksContext> contextScope =
                    DbContextScopeFactory<AdventureWorksContext>.CreateReadOnly())
            {
                List<Contact> contacts = contextScope.Context.Contacts.Take(10000).ToList();
                Console.WriteLine(contextScope.Context.Set<Contact>().Local.Any(e => e == contacts[0]));
            }

            // Will throw an exception
            using (
                IDbContextScope<AdventureWorksContext> contextScope =
                    DbContextScopeFactory<AdventureWorksContext>.CreateReadOnly())
            {
                Department dept = contextScope.Context.Departments.Find(1);
                dept.Name += ": Test";
                contextScope.SaveChanges();
            }
        }
    }
}