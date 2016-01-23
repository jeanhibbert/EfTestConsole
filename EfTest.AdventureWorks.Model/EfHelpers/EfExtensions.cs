namespace EfTest.AdventurWorks.Model.EfHelpers
{
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure;
    using System.Linq;
    using System.Transactions;

    public static class EfExtensions
    {
        #region Public Methods and Operators

        public static List<T> ToListReadUncommitted<T>(this IQueryable<T> query)
        {
            using (
                var scope = new TransactionScope(
                    TransactionScopeOption.Required,
                    new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted }))
            {
                List<T> toReturn = query.ToList();
                scope.Complete();
                return toReturn;
            }
        }

        public static List<T> ToListReadUncommitted<T>(this DbSqlQuery<T> query) where T : class 
        {
            using (
                var scope = new TransactionScope(
                    TransactionScopeOption.Required,
                    new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted }))
            {
                List<T> toReturn = query.AsNoTracking().ToList();
                scope.Complete();
                return toReturn;
            }
        }

        #endregion
    }
}