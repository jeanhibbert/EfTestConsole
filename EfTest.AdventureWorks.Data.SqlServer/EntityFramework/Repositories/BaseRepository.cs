namespace EfTest.AdventureWorks.Data.SqlServer.EntityFramework.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading.Tasks;

    using EfTest.AdventureWorks.Data.SqlServer.EntityFramework;

    public class BaseRepository<T> : IBaseRepository<T>
        where T: class
    {
        #region Constructors and Destructors

        public BaseRepository(IUnitOfWork unitOfWork)
        {
            if (unitOfWork == null)
            {
                throw new ArgumentNullException("unitOfWork");
            }
            this.UnitOfWork = unitOfWork;
        }

        #endregion

        #region Properties

        private AdventureWorksContext _context
        {
            get
            {
                return (AdventureWorksContext)this.UnitOfWork;
            }
        }

        protected IUnitOfWork UnitOfWork { get; set; }

        public DbContextConfiguration DbContextConfiguration
        {
            get
            {
                return this._context.Configuration;
            }
        }

        #endregion

        #region Methods

        public List<T> GetAll()
        {
            return this._context.Set<T>().ToList();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await this._context.Set<T>().ToListAsync();
        }

        public T Get(int id)
        {
            return this._context.Set<T>().Find(id);
        }

        public async Task<T> GetAsync(int id)
        {
            return await this._context.Set<T>().FindAsync(id);
        }

        public T Find(Expression<Func<T, bool>> match)
        {
            return this._context.Set<T>().SingleOrDefault(match);
        }

        public async Task<T> FindAsync(Expression<Func<T, bool>> match)
        {
            return await this._context.Set<T>().SingleOrDefaultAsync(match);
        }

        public List<T> FindAll(Expression<Func<T, bool>> match)
        {
            return this._context.Set<T>().Where(match).ToList();
        }

        public async Task<List<T>> FindAllAsync(Expression<Func<T, bool>> match)
        {
            return await this._context.Set<T>().Where(match).ToListAsync();
        }

        public T Add(T t)
        {
            this._context.Set<T>().Add(t);
            this._context.SaveChanges();
            return t;
        }

        public async Task<T> AddAsync(T t)
        {
            this._context.Set<T>().Add(t);
            await this._context.SaveChangesAsync();
            return t;
        }

        public T Update(T updated, int key)
        {
            if (updated == null)
                return null;

            T existing = this._context.Set<T>().Find(key);
            if (existing != null)
            {
                this._context.Entry(existing).CurrentValues.SetValues(updated);
                this._context.SaveChanges();
            }
            return existing;
        }

        public async Task<T> UpdateAsync(T updated, int key)
        {
            if (updated == null)
                return null;

            T existing = await this._context.Set<T>().FindAsync(key);
            if (existing != null)
            {
                this._context.Entry(existing).CurrentValues.SetValues(updated);
                await this._context.SaveChangesAsync();
            }
            return existing;
        }

        public void Delete(T t)
        {
            this._context.Set<T>().Remove(t);
            this._context.SaveChanges();
        }

        public async Task<int> DeleteAsync(T t)
        {
            this._context.Set<T>().Remove(t);
            return await this._context.SaveChangesAsync();
        }

        public int Count()
        {
            return this._context.Set<T>().Count();
        }

        public async Task<int> CountAsync()
        {
            return await this._context.Set<T>().CountAsync();
        }

        public DbSet<T> GetDbSet()
        {
            return this._context.Set<T>();
        }

        #endregion

        public void Dispose()
        {
            this._context.Dispose();
        }
    }
}