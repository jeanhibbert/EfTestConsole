﻿namespace EfTest.AdventureWorks.Data.SqlServer.Massive.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ContactRepository : IDisposable
    {
        #region Public Methods and Operators

        public dynamic Add(dynamic contact)
        {
            var table = new Contacts();
            dynamic addedContact = table.Insert(contact);
            return addedContact;
        }

        public dynamic Find(int id)
        {
            //var table = new Contacts();
            //return table.Single(key: id);

            dynamic table = new Contacts();
            return table.GetContact(Id: id);
        }

        public List<dynamic> GetAll()
        {
            //var table = new DynamicModel("AdventureWorks", "Person.Contact", "ContactID");
            var table = new Contacts();
            return table.All().ToList();
            //return table.Query("SELECT * FROM Person.Contact").ToList();

            //dynamic table = new Contacts();
            //return (table.Find() as IEnumerable<dynamic>).ToList();
        }

        public IEnumerable<dynamic> Query(string sql)
        {
            var table = new Contacts();
            return table.Query(sql);
        }

        public dynamic GetAllPaged(int currentPage, int pageSize)
        {
            var table = new Contacts();
            return table.Paged(currentPage: currentPage, pageSize: pageSize);
        }

        public List<dynamic> GetAllSortedByLastName()
        {
            dynamic table = new Contacts();
            return (table.Find(OrderBy: "LastName DESC") as IEnumerable<dynamic>).ToList();
        }

        public int GetCount()
        {
            dynamic table = new Contacts();
            return table.Count();
        }

        public int GetMaxId()
        {
            dynamic table = new Contacts();
            return table.Max(columns: "ContactID");
        }

        public IEnumerable<dynamic> GetSchema()
        {
            var table = new Contacts();
            return table.Schema;
        }

        public int GetSum()
        {
            dynamic table = new Contacts();
            return table.Sum(columns: "ContactID");
        }

        public void Remove(int id)
        {
            var table = new Contacts();
            table.Delete(id);
        }

        public dynamic Update(dynamic contact)
        {
            var table = new Contacts();
            table.Update(contact, contact.Id);
            return contact;
        }

        #endregion

        public void Dispose()
        {}
    }
}