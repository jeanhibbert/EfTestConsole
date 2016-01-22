namespace EfTestConsole
{
    using System.Configuration;

    public static class Constants
    {
        #region Static Fields

        public static string ConnectionString =
            ConfigurationManager.ConnectionStrings["AdventureWorks"].ConnectionString;

        #endregion
    }
}