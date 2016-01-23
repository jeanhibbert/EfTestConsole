namespace EfTest.AdventureWorks.Tests.Dapper
{
    using System.Collections.Generic;

    using EfTest.AdventureWorks.Data.SqlServer.Dapper.Repositories;
    using EfTest.AdventureWorks.Model.Models;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ContactRepositoryTests
    {
        #region Public Methods and Operators

        [TestMethod]
        public void Bulk_insert_should_insert_3_rows()
        {
            ContactRepository repository = this.CreateRepository();
            var contacts = new List<Contact>
                {
                    new Contact { FirstName = "Charles__1", LastName = "Barkley" },
                    new Contact { FirstName = "Scottie__1", LastName = "Pippen" },
                    new Contact { FirstName = "Tim__1", LastName = "Duncan" },
                    new Contact { FirstName = "Patrick__1", LastName = "Ewing" }
                };

            int rowsAffected = repository.BulkInsertContacts(contacts);

            Assert.AreEqual(rowsAffected, 4);
        }

        [TestMethod]
        public void Dynamic_support_should_produce_correct_results()
        {
            ContactRepository repository = this.CreateRepository();

            List<dynamic> contacts = repository.GetDynamicById(1, 3, 4);

            Assert.AreEqual(contacts.Count, 3);
        }

        [TestMethod]
        public void List_support_should_produce_correct_results()
        {
            ContactRepository repository = this.CreateRepository();

            List<Contact> contacts = repository.GetContactsById(1, 3, 4);

            Assert.AreEqual(contacts.Count, 3);
        }

        #endregion

        #region Methods

        private ContactRepository CreateRepository()
        {
            return new ContactRepository();
        }

        #endregion
    }
}