namespace EfTest.AdventureWorks.Data.SqlServer.Massive
{
    using System;

    using VanillaMassive;

    public class TestEntity1s : DynamicModel
    {
        public TestEntity1s()
            : base("AdventureWorks", "TestEntity1", "TestEntity1Id")
        {
        }
        
        public override bool BeforeSave(dynamic item)
        {
            Console.WriteLine("About to save...");
            return true;
        }

        public override void Inserted(dynamic item)
        {
            Console.WriteLine("Just inserted: {0}", item.Name);
        }

        public override void Updated(dynamic item)
        {
            Console.WriteLine("Just updated:  {0}", item.Name);
        }

        public override void Validate(dynamic item)
        {
            this.ValidatesPresenceOf(item.Name);
        }
    }
}