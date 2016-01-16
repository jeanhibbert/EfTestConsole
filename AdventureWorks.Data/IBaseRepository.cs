namespace EfTest.AdventureWorks.Data
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Linq.Expressions;
    using System.Threading.Tasks;

    public interface IBaseRepository<T> : IDisposable
        where T : class
    {
        List<T> GetAll();
        Task<List<T>> GetAllAsync();
        T Get(int id);
        Task<T> GetAsync(int id);
        
        T Find(Expression<Func<T, bool>> match);
        Task<T> FindAsync(Expression<Func<T, bool>> match);
        List<T> FindAll(Expression<Func<T, bool>> match);
        Task<List<T>> FindAllAsync(Expression<Func<T, bool>> match);
        
        T Add(T t);
        Task<T> AddAsync(T t);
        
        T Update(T updated, int key);
        Task<T> UpdateAsync(T updated, int key);

        void Delete(T t);
        Task<int> DeleteAsync(T t);

        int Count();
        Task<int> CountAsync();

        DbSet<T> GetDbSet();
        DbContextConfiguration DbContextConfiguration { get; }
    }
}