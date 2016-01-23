namespace EfTest.AdventureWorks.Tests.Massive
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    using EfTest.AdventureWorks.Data.SqlServer.Massive.Repositories;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ContactRepositoryTestFixture
    {
        #region Public Methods and Operators

        [TestMethod]
        public void Aggregate_count_should_return_correct_result()
        {
            var repository = new ContactRepository();

            int result = repository.GetCount();

            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void Aggregate_max_should_return_correct_result()
        {
            var repository = new ContactRepository();

            int result = repository.GetMaxId();

            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void Aggregate_sum_should_return_correct_result()
        {
            var repository = new ContactRepository();

            int result = repository.GetSum();

            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void Get_schema_should_produce_metadata()
        {
            var repository = new ContactRepository();

            IEnumerable<dynamic> schema = repository.GetSchema();

            Assert.IsNotNull(schema);

            foreach (dynamic item in schema)
            {
                Debug.WriteLine(item.COLUMN_NAME + " - " + item.DATA_TYPE);
            }
        }

        [TestMethod]
        public void Named_arguments_should_produce_correct_results()
        {
            var repository = new ContactRepository();

            List<dynamic> contacts = repository.GetAllSortedByLastName();

            Assert.IsNotNull(contacts);
            Assert.IsTrue(contacts.Count > 0);
        }

        [TestMethod]
        public void Paging_should_return_correct_results()
        {
            var repository = new ContactRepository();

            dynamic pagedResult = repository.GetAllPaged(1000, 10);
            List<dynamic> items = (pagedResult.Items as IEnumerable<dynamic>).ToList();

            Assert.IsNotNull(pagedResult);
            Assert.AreEqual(10, items.Count);
            Assert.IsTrue(pagedResult.TotalRecords > 0);
            Assert.IsTrue(pagedResult.TotalPages > 0);
        }

        #endregion
    }
}