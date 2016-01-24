namespace EfTest.AdventureWorks.Data.SqlServer.EntityFramework.UnitOfWork
{
    using System.Data;
    using System.Data.Entity;
    
    public static class DbContextScopeFactory<TDbContext> where TDbContext : DbContext, new()
    {
        public static IDbContextScope<TDbContext> CreateWithTransaction(IsolationLevel isolationLevel)
        {
            return new DbContextScope<TDbContext>(
                readOnly: false,
                isolationLevel: isolationLevel);
        }

        public static IDbContextScope<TDbContext> CreateReadOnly(IsolationLevel? isolationLevel = null)
        {
            return new DbContextScope<TDbContext>(
                readOnly: true,
                isolationLevel: isolationLevel);
        }
    }
}