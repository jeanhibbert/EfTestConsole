namespace EfTest.AdventureWorks.Data.SqlServer.EntityFramework.Repositories
{
    using EfTest.AdventureWorks.Model.Models;

    public class ContactRepository : BaseRepository<Contact>, IContactRepository
    {
        #region Constructors and Destructors

        public ContactRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }

        #endregion
    }
}