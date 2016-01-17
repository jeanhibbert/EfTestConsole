namespace EfTest.AdventureWorks.Data
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    using EfTest.AdventureWorks.Model.Models;

    public interface IProductRepository : IBaseRepository<Product>
    {
        #region Public Methods and Operators

        IEnumerable<Product> GetGetProductsForSubCategory(int categoryId);

        DbSet<Product> GetDbSet();
        DbContextConfiguration DbContextConfiguration { get; }

        #endregion
    }
}