using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfTestConsole.Demonstration
{
    using EfTest.AdventureWorks.Model.Models;

    public class EfQueryGeneration
    {
        public static void ShowSelect()
        {
            //Lazy load entity
            using (var context = new AdventureWorksContext())
            {
                var products = context.Products.Take(10)
                    .Select(p => p);

                foreach (var p in products)
                {
                    Console.WriteLine(p.ProductID);
                    Console.WriteLine(p.ProductSubcategory);
                    Console.WriteLine(p.ProductSubcategory.ProductCategoryID); // Causes an additional database hit
                    Console.WriteLine("----------------------------------------------");
                }
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();


            //Deep load entity
            using (var context = new AdventureWorksContext())
            {
                var products = context.Products.Include("ProductSubcategory").Take(10)
                    .Select(s => s);

                foreach (var e in products)
                {
                    Console.WriteLine(e.ProductID);
                    Console.WriteLine(e.ProductSubcategory.ProductCategoryID); // Does not cause an additional database hit
                    Console.WriteLine("----------------------------------------------");
                }
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();


            // ------------------------ Anonymous type EF queries ----------------------------------// 

            //Select with projection using anonymous type
            using (var context = new AdventureWorksContext())
            {
                var products = context.Products.Take(10)
                    .Select(s => new { s.ProductID, s.ProductSubcategory.Name });

                foreach (var e in products)
                {
                    Console.WriteLine(e.ProductID);
                    Console.WriteLine(e.Name); // Does not cause an additional database hit
                    Console.WriteLine("----------------------------------------------");
                }
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();


            //View caching behaviour
            using (var context = new AdventureWorksContext())
            {
                var products = context.Products.Take(10)
                    .Select(p => p);

                foreach (var p in products)
                {
                    Console.WriteLine(p.ProductID);
                    Console.WriteLine(p.ProductSubcategory);
                    Console.WriteLine(p.ProductSubcategory.ProductCategoryID); // Causes an additional database hit
                    Console.WriteLine("----------------------------------------------");
                }
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
