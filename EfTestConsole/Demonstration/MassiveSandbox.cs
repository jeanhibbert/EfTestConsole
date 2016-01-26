namespace EfTestConsole.Demonstration
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using EfTest.AdventureWorks.Data.SqlServer.Massive;

    public static class MassiveSandbox
    {
        public static void MassiveApiTests()
        {
            
            var testEntity1Table = new TestEntity1s();
            dynamic testEntity1 = new { Name = "New Name" + Guid.NewGuid().ToString() };
            dynamic addedTestEntity1 = testEntity1Table.Insert(testEntity1);
            //Console.WriteLine(addedTestEntity1.TestEntity1Id);

            Console.WriteLine("====");
            var contactsTable = new Contacts();
            IEnumerable<dynamic> contacts = contactsTable.All(limit: 10000, orderBy: "FirstName ASC").ToList();
            foreach (dynamic contact in contacts.Take(10))
            {
                Console.WriteLine(contact.FirstName);
            }

            Console.WriteLine("====");
            IEnumerable<dynamic> contactNames =
                contactsTable.All(columns: "FirstName as FirstName1", where: "WHERE FirstName like '@0%'", args: "h").ToList();
            foreach (dynamic contactName in contactNames.Take(10))
            {
                Console.WriteLine(contactName.FirstName1);
            }

            Console.WriteLine("====");
            var result = contactsTable.Paged(columns: "FirstName", where: "ContactID < 20", currentPage: 100, pageSize: 10);
            foreach (dynamic item in result)
            {
                Console.WriteLine(item.FirstName);
            }


            Console.ReadKey();
        }
    }
}