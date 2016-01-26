namespace EfTestConsole.Demonstration
{
    using EfTest.AdventureWorks.Data.SqlServer.EntityFramework;
    using EfTest.AdventureWorks.Data.SqlServer.EntityFramework.Repositories;

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
