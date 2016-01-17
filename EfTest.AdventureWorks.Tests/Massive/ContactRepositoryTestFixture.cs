namespace EfTest.AdventureWorks.Tests.Massive
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using EfTest.AdventureWorks.Data.SqlServer.Massive;
    using EfTest.AdventureWorks.Data.SqlServer.Massive.Repositories;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    internal class ContactRepositoryTestFixture
    {
        #region Public Methods and Operators

        [TestMethod]
        public void Aggregate_count_should_return_correct_result()
        {
            // arrange
            var repository = new ContactRepository();

            // act
            int result = repository.GetCount();

            // assert
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void Aggregate_max_should_return_correct_result()
        {
            // arrange
            var repository = new ContactRepository();

            // act
            int result = repository.GetMaxId();

            // assert
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void Aggregate_sum_should_return_correct_result()
        {
            // arrange
            var repository = new ContactRepository();

            // act
            int result = repository.GetSum();

            // assert
            Assert.AreEqual(21, result);
        }

        [TestMethod]
        public void Get_schema_should_produce_metadata()
        {
            // arrange
            var repository = new ContactRepository();

            // act
            IEnumerable<dynamic> schema = repository.GetSchema();

            // assert
            Assert.IsNotNull(schema);
            Assert.AreEqual(6, schema.Count());

            foreach (dynamic item in schema)
            {
                Console.WriteLine(item.COLUMN_NAME + " - " + item.DATA_TYPE);
            }
        }

        [TestMethod]
        public void Named_arguments_should_produce_correct_results()
        {
            // arrange
            var repository = new ContactRepository();

            // act
            List<dynamic> contacts = repository.GetAllSortedByLastName();

            // assert
            Assert.IsNotNull(contacts);
            Assert.AreEqual(6, contacts.Count);
            Assert.AreEqual("Bryant", contacts.Last().LastName);
            Assert.AreEqual("Paul", contacts.First().LastName);
        }

        [TestMethod]
        public void Paging_should_return_correct_results()
        {
            // arrange
            var repository = new ContactRepository();

            // act
            dynamic pagedResult = repository.GetAllPaged(2, 2);
            List<dynamic> items = (pagedResult.Items as IEnumerable<dynamic>).ToList();

            // assert
            Assert.IsNotNull(pagedResult);
            Assert.AreEqual(2, items.Count);
            Assert.AreEqual("Bryant", items[0].LastName);
            Assert.AreEqual("Durant", items[1].LastName);
            Assert.AreEqual(6, pagedResult.TotalRecords);
            Assert.AreEqual(3, pagedResult.TotalPages);
        }

        #endregion
    }
}