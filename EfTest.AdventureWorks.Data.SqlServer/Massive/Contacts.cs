namespace EfTest.AdventureWorks.Data.SqlServer.Massive
{
    using System;

    using VanillaMassive;

    public class Contacts : DynamicModel
    {
        #region Constructors and Destructors

        public Contacts()
            : base("AdventureWorks", "Person.Contact", "ContactID")
        {
        }

        #endregion

        #region Public Methods and Operators

        public override bool BeforeSave(dynamic item)
        {
            Console.WriteLine("About to save...");
            return true;
        }

        public override void Inserted(dynamic item)
        {
            Console.WriteLine("Just inserted: {0} {1}", item.FirstName, item.LastName);
        }

        public override void Updated(dynamic item)
        {
            Console.WriteLine("Just updated: {0} {1}", item.FirstName, item.LastName);
        }

        public override void Validate(dynamic item)
        {
            this.ValidatesPresenceOf(item.FirstName);
            this.ValidatesPresenceOf(item.LastName);
        }

        #endregion
    }
}