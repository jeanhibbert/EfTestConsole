using EfTest.AdventureWorks.Data.SqlServer.Repositories;

namespace EfTestConsole.Demonstration
{
    using EfTest.AdventureWorks.Data.SqlServer;

    public static class EfProductRepositoryTest
    {
        public static void TestProductRepository()
        {
            using (var repository = new ProductRepository(new AdventureWorksContext()))
            {
                var productsBySubCategory = repository.GetGetProductsForSubCategory(1);
            }
        }
    }
}
