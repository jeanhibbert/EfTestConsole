namespace EfTest.AdventureWorks.Data.SqlServer.EntityFramework.UnitOfWork
{
    using System;
    using System.Data;
    using System.Data.Entity;
    using System.Reflection;
    using System.Threading;
    using System.Threading.Tasks;

    public class DbContextScope<TDbContext> : IDbContextScope<TDbContext>
        where TDbContext : DbContext, new()
    {
        #region Fields

        private readonly TDbContext _dbContext;

        private readonly IsolationLevel? _isolationLevel;

        private readonly bool _readOnly;

        private readonly DbContextTransaction _transaction;

        #endregion

        #region Constructors and Destructors
        
        public DbContextScope(bool readOnly = false, IsolationLevel? isolationLevel = IsolationLevel.ReadCommitted)
        {
            this._readOnly = readOnly;
            this._isolationLevel = isolationLevel;

            this._dbContext = new TDbContext();

            if (this._readOnly)
            {
                this._dbContext.Configuration.AutoDetectChangesEnabled = false;
                this._dbContext.Configuration.ProxyCreationEnabled = false;
                //this.SetAsNoTrackingOnDbSets();
            }

            if (this._isolationLevel.HasValue)
            {
                this._transaction = this._dbContext.Database.BeginTransaction(this._isolationLevel.Value);
            }
        }

        #endregion

        #region Public Properties

        public TDbContext Context
        {
            get
            {
                return this._dbContext;
            }
        }

        #endregion

        #region Public Methods and Operators

        public void Dispose()
        {
            this._dbContext.Dispose();
            if (this._transaction != null)
            {
                this._transaction.Dispose();
            }
        }

        public int SaveChanges()
        {
            this.VerifyNotReadOnly();

            int c = this._dbContext.SaveChanges();

            this.CommitTransaction();

            return c;
        }

        public async Task<int> SaveChangesAsync()
        {
            this.VerifyNotReadOnly();

            int c = await this._dbContext.SaveChangesAsync();

            this.CommitTransaction();

            return c;
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancelToken)
        {
            this.VerifyNotReadOnly();

            int c = await this._dbContext.SaveChangesAsync(cancelToken).ConfigureAwait(false);

            this.CommitTransaction();

            return c;
        }

        #endregion

        #region Methods

        private void CommitTransaction()
        {
            if (this._transaction != null)
            {
                this._transaction.Commit();
            }
        }

        private void SetAsNoTrackingOnDbSets()
        {
            PropertyInfo[] dbSetProperties = this.GetType().GetProperties();
            foreach (PropertyInfo pi in dbSetProperties)
            {
                object obj = pi.GetValue(this, null);
                if (obj.GetType().IsGenericType && obj.GetType().GetGenericTypeDefinition() == typeof(DbSet<>))
                {
                    MethodInfo mi = obj.GetType().GetMethod("AsNoTracking");
                    mi.Invoke(obj, null);
                }
            }
        }

        private void VerifyNotReadOnly()
        {
            if (this._readOnly)
            {
                throw new ArgumentException("Context only allows for readonly operations.");
            }
        }

        #endregion
    }
}