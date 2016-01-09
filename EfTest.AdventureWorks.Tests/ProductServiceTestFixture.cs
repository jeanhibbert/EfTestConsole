using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EfTest.AdventureWorks.Tests
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using EntityFramework.Testing.Moq;

    using Moq;

    [TestClass]
    public class ProductServiceTestFixture
    {
        [TestMethod]
        public async Task Index_returns_two_newest_listings()
        {
            // Create some test data
            //TODO : COMPLETE

            //var data = new List<Product>
            //{
            //    new Product { ProductId = 1 },
            //    new Product { ProductId = 4 },
            //    new Product { ProductId = 2 },
            //    new Product { ProductId = 3 }
            //};

            //// TODO Create a mock set and context
            //var set = new MockDbSet<Product>()
            //    .SetupSeedData(data)
            //    .SetupLinq();

            //var context = new Mock<AdventureWorksContext>();
            //context.Setup(c => c.Products).Returns(set.Object);

            //// TODO Create a HomeController and invoke the Index action
            //var controller = new HomeController(context.Object);
            //var result = await controller.Index();

            //// TODO Check the results
            //var products = (List<Product>)result.Model;
            //Assert.AreEqual(2, products.Count());
            //Assert.AreEqual(4, products[0].ProductId);
            //Assert.AreEqual(3, products[1].ProductId);
        }
    }
}
