namespace EfTestConsole.Demonstration
{
    using System.Data;

    using EfTest.AdventureWorks.Data.SqlServer.EntityFramework;
    using EfTest.AdventureWorks.Data.SqlServer.EntityFramework.UnitOfWork;

    public static class EfDbContextScope
    {
        public static void EfDbContextScopeTest()
        {
            using (var contextScope = DbContextScopeFactory<AdventureWorksContext>.CreateWithTransaction(IsolationLevel.Serializable))
            {
                var dept = contextScope.Context.Departments.Find(1);
                dept.Name += ": Test";
                contextScope.SaveChanges();
            }

            // Will throw an exception
            using (var contextScope = DbContextScopeFactory<AdventureWorksContext>.CreateReadOnly())
            {
                var dept = contextScope.Context.Departments.Find(1);
                dept.Name += ": Test";
                contextScope.SaveChanges();
            }
        }
    }
}
