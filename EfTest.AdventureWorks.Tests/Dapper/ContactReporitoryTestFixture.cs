namespace EfTest.AdventureWorks.Tests.Dapper
{
    using System.Collections.Generic;

    using EfTest.AdventureWorks.Data;
    using EfTest.AdventureWorks.Data.SqlServer.Dapper.Repositories;
    using EfTest.AdventureWorks.Model.Models;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ContactRepositoryTests
    {
        #region Static Fields

        private static int id;

        #endregion

        #region Public Methods and Operators

        [TestMethod]
        public void Delete_should_remove_entity()
        {
            // arrange
            IContactRepository repository = this.CreateRepository();

            var contact = new Contact { ContactID = id };

            // act
            repository.Delete(contact);

            // create a new repository for verification purposes
            IContactRepository repository2 = this.CreateRepository();
            Contact deletedEntity = repository2.Get(id);

            // assert
            Assert.IsNull(deletedEntity);
        }

        [TestMethod]
        public void Find_should_retrieve_existing_entity()
        {
            // arrange
            IContactRepository repository = this.CreateRepository();

            // act
            //var contact = repository.Find(id);
            Contact contact = repository.Get(id);

            // assert
            Assert.IsNotNull(contact);
        }

        [TestMethod]
        public void Get_all_should_return_6_results()
        {
            // arrange
            IContactRepository repository = this.CreateRepository();

            // act
            List<Contact> contacts = repository.GetAll();

            // assert
            Assert.IsNotNull(contacts);
            Assert.AreEqual(contacts.Count, 19972);
        }

        [TestMethod]
        public void Modify_should_update_existing_entity()
        {
            // arrange
            IContactRepository repository = this.CreateRepository();

            // act
            //var contact = repository.Find(id);
            Contact contact = repository.Get(id);
            contact.FirstName = "Bob";
            repository.Update(contact, id);

            // create a new repository for verification purposes
            IContactRepository repository2 = this.CreateRepository();
            //var modifiedContact = repository2.Find(id);
            Contact modifiedContact = repository2.Get(id);

            // assert
            Assert.AreEqual(modifiedContact.FirstName, "Bob");
        }


        //[TestMethod]
        //public void Bulk_insert_should_insert_3_rows()
        //{
        //    // arrange
        //    var repository = new Dapper.ContactRepository();
        //    var contacts = new List<Contact> {
        //        new Contact { FirstName = "Charles", LastName = "Barkley" },
        //        new Contact { FirstName = "Scottie", LastName = "Pippen" },
        //        new Contact { FirstName = "Tim", LastName = "Duncan" },
        //        new Contact { FirstName = "Patrick", LastName = "Ewing" }
        //    };

        //    // act
        //    var rowsAffected = repository.BulkInsertContacts(contacts);

        //    // assert
        //    rowsAffected.Should().Be(4);
        //}

        //[TestMethod]
        //public void List_support_should_produce_correct_results()
        //{
        //    // arrange
        //    var repository = new Dapper.ContactRepository();

        //    // act
        //    var contacts = repository.GetContactsById(1, 3, 4);

        //    // assert
        //    contacts.Count.Should().Be(3);
        //}

        //[TestMethod]
        //public void Dynamic_support_should_produce_correct_results()
        //{
        //    // arrange
        //    var repository = new Dapper.ContactRepository();

        //    // act
        //    var contacts = repository.GetDynamicById(1, 3, 4);

        //    // assert
        //    contacts.Count.Should().Be(3);
        //    Assert.AreEqual("Michael", contacts.First().FirstName);
        //    Assert.AreEqual("Jordan", contacts.First().LastName);
        //}

        #endregion

        #region Methods

        private IContactRepository CreateRepository()
        {
            return new ContactRepository();
        }

        #endregion
    }
}