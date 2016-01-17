using EfTest.AdventureWorks.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfTestConsole.Demonstration
{
    using EfTest.AdventureWorks.Data.SqlServer;
    using EfTest.AdventureWorks.Data.SqlServer.EntityFramework;
    using EfTest.AdventureWorks.Data.SqlServer.EntityFramework.Repositories;

    public static class EfRawSqlQueries
    {
        public static async Task<Product> FindProductAsync()
        {

            // Commenting out original code to show how to use a raw SQL query.
            
            // Create and execute raw SQL query.
            using (var repository = new ProductRepository(new AdventureWorksContext()))
            {
                Product product = await 
                    repository.GetDbSet()
                              .SqlQuery("SELECT * FROM Production.Product WHERE ProductID = @p0", 1)
                              .SingleOrDefaultAsync();

                return product;
            }
            // Talk about serialisation performance in EF vs Dapper
            
        }
    }
}
