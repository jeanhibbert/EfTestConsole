using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks.Data
{
    //internal class DropCreateIfModelChangesSqlCeInitializer<TContext> : SqlCeInitializer<TContext>
    //    where TContext : DbContext
    //{
    //    #region Strategy implementation

    //    /// <summary>
    //    /// Executes the strategy to initialize the database for the given context.
    //    /// </summary>
    //    /// <param name="context">The context.</param>
    //    public override void InitializeDatabase(TContext context)
    //    {
    //        if (context == null)
    //        {
    //            throw new ArgumentNullException("context");
    //        }

    //        var replacedContext = ReplaceSqlCeConnection(context);

    //        bool databaseExists;
    //        using (new TransactionScope(TransactionScopeOption.Suppress))
    //        {
    //            databaseExists = replacedContext.Database.Exists();
    //        }

    //        if (databaseExists)
    //        {
    //            if (context.Database.CompatibleWithModel(throwIfNoMetadata: true))
    //            {
    //                return;
    //            }

    //            replacedContext.Database.Delete();
    //        }

    //        // Database didn't exist or we deleted it, so we now create it again.
    //        context.Database.Create();

    //        this.Seed(context);
    //        context.SaveChanges();
    //    }

    //    #endregion
    //}
}
