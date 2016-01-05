using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfTestConsole.Demonstration
{
    using EfTest.AdventureWorks.Model.Models;

    public class EfCaching
    {
        public static void DemonstrateCaching()
        {
            using (var context1 = new AdventureWorksContext())
            {

                var product = context1.Products.Single(p => p.ProductID == 1);
                product.Name = product.Name += " - Test";
                context1.SaveChanges();

                var product2 = context1.Products.Find(1); // Will not hit the database

            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }

        
    }
}
