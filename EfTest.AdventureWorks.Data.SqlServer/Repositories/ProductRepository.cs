using System;
using System.Collections.Generic;
using System.Linq;

namespace EfTest.AdventureWorks.Data.SqlServer.Repositories
{
    using EfTest.AdventureWorks.Model.Models;

    public class ProductRepository: BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IEnumerable<Product> GetGetProductsForSubCategory(int productSubCategoryId)
        {
            return this.FindAll(p => p.ProductSubcategoryID == productSubCategoryId);
        }
    }
}
