namespace EfTest.AdventureWorks.Data.SqlServer.EntityFramework.UnitOfWork
{
    using System;
    using System.Data.Entity;
    using System.Threading;
    using System.Threading.Tasks;

    public interface IDbContextScope<out TDbContext> : IDisposable where TDbContext : DbContext, new()
    {
        #region Public Methods and Operators

        int SaveChanges();

        Task<int> SaveChangesAsync();

        Task<int> SaveChangesAsync(CancellationToken cancelToken);

        TDbContext Context { get; }
                
        #endregion
    }
}