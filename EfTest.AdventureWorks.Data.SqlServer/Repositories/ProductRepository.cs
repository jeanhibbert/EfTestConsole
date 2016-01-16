namespace EfTest.AdventureWorks.Data.SqlServer.Repositories
{
    using System.Collections.Generic;

    using EfTest.AdventureWorks.Model.Models;

    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        #region Constructors and Destructors

        public ProductRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }

        #endregion

        #region Public Methods and Operators

        public IEnumerable<Product> GetGetProductsForSubCategory(int productSubCategoryId)
        {
            return this.FindAll(p => p.ProductSubcategoryID == productSubCategoryId);
        }

        #endregion
    }
}