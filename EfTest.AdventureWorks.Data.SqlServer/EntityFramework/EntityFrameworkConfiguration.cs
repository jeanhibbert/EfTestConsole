namespace EfTest.AdventureWorks.Data.SqlServer.EntityFramework
{
    using System.Data.Entity;

    using EfTest.AdventurWorks.Model.EfHelpers;

    public class EntityFrameworkConfiguration : DbConfiguration
    {
        public EntityFrameworkConfiguration()
        {
            //AddInterceptor(new SoftDeleteInterceptor());
        }
    }
}
