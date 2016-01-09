namespace EfTest.AdventureWorks.Data
{
    public interface IUnitOfWork
    {
        #region Public Methods and Operators

        void SaveChanges();

        #endregion
    }
}