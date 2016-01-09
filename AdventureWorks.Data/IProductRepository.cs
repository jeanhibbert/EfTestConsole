namespace EfTest.AdventureWorks.Data
{
    using System.Collections.Generic;

    using EfTest.AdventureWorks.Model.Models;

    public interface IProductRepository
    {
        #region Public Methods and Operators

        IEnumerable<Product> GetGetProductsForSubCategory(int categoryId);

        #endregion
    }
}