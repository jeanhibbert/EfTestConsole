namespace EfTestConsole.Demonstration
{
    using System;
    using System.Linq;

    using EfTest.AdventureWorks.Data.SqlServer;
    using EfTest.AdventureWorks.Data.SqlServer.EntityFramework;
    using EfTest.AdventureWorks.Model.Models;

    public class EfCaching
    {
        #region Public Methods and Operators

        public static void DemonstrateCaching()
        {
            using (var context1 = new AdventureWorksContext())
            {
                Product product = context1.Products.Single(p => p.ProductID == 1);
                product.Name = product.Name += " - Test";
                context1.SaveChanges();

                Product product2 = context1.Products.Find(1); // Will not hit the database
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        #endregion
    }
}