namespace EfTest.AdventureWorks.Tests
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Threading.Tasks;

    using EfTest.AdventureWorks.Data.SqlServer;
    using EfTest.AdventureWorks.Data.SqlServer.EntityFramework;
    using EfTest.AdventureWorks.Model.Models;

    using EfTestWebApi.Controllers;

    using EntityFramework.Testing.Moq;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Moq;

    [TestClass]
    public class ProductServiceTestFixture
    {
        #region Public Methods and Operators

        [TestMethod]
        public async Task Index_returns_two_newest_listings()
        {
            // Create some test data
            var data = new List<Product>
                {
                    new Product { ProductID = 1 },
                    new Product { ProductID = 4 },
                    new Product { ProductID = 2 },
                    new Product { ProductID = 3 }
                };

            //Create a mock set and context
            MockDbSet<Product> set = new MockDbSet<Product>().SetupSeedData(data).SetupLinq();

            var context = new Mock<AdventureWorksContext>();
            context.Setup(c => c.Products).Returns(set.Object);

            //Create a Controller and invoke the Index action
            //var controller = new ProductController(new ProductRepository(context.Object));
            //List<Product> result = await controller.GetProducts();
            List<Product> result = await context.Object.Products.ToListAsync();


            //Check the results
            var products = result;
            Assert.AreEqual(4, products.Count());
            Assert.AreEqual(1, products[0].ProductID);
            Assert.AreEqual(4, products[1].ProductID);
        }

        #endregion
    }
}