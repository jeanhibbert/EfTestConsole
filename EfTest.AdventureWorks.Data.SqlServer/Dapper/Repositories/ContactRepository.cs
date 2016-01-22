namespace EfTest.AdventureWorks.Data.SqlServer.Dapper.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading.Tasks;

    using EfTest.AdventureWorks.Model.Models;

    using global::Dapper;

    public class ContactRepository : IContactRepository
    {
        private IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["AdventureWorks"].ConnectionString);

        public Contact Add(Contact contact)
        {
            var sql =
                "INSERT INTO Contacts (FirstName, LastName, EmailAddress, Title) VALUES(@FirstName, @LastName, @EmailAddress, @Title); " +
                "SELECT CAST(SCOPE_IDENTITY() as int)";
            var id = this.db.Query<int>(sql, contact).Single();
            contact.ContactID = id;
            return contact;
        }

        public void Delete(Contact contact)
        {
            this.db.Execute("DELETE FROM Contacts WHERE Id = @Id", new { contact.ContactID });
        }

        public Contact Get(int id)
        {
            return this.db.Query<Contact>("SELECT * FROM Contacts WHERE Id = @Id", new { id }).SingleOrDefault();
        }

        public List<Contact> GetAll()
        {
            return this.db.Query<Contact>("SELECT * FROM Contacts").ToList();
        }

        public IEnumerable<Contact> Execute(string sql)
        {
            return this.db.Query<Contact>(sql);
        }

        public Contact Update(Contact contact, int key)
        {
            var sql =
                "UPDATE Contacts " +
                "SET FirstName = @FirstName, " +
                "    LastName  = @LastName, " +
                "    Email     = @Email, " +
                "    Company   = @Company, " +
                "    Title     = @Title " +
                "WHERE Id = @Id";
            this.db.Execute(sql, contact);
            return contact;
        }

        
        public int BulkInsertContacts(List<Contact> contacts)
        {
            this.EnsureOpenConnection();
            var sql =
                "INSERT INTO Contacts (FirstName, LastName, Email, Company, Title) VALUES(@FirstName, @LastName, @Email, @Company, @Title); " +
                "SELECT CAST(SCOPE_IDENTITY() as int)";
            return this.db.Execute(sql, contacts);
        }

        public List<Contact> GetContactsById(params int[] ids)
        {
            return this.db.Query<Contact>("SELECT * FROM Contacts WHERE ID IN @Ids", new { Ids = ids }).ToList();
        }

        public List<dynamic> GetDynamicById(params int[] ids)
        {
            return this.db.Query("SELECT * FROM Contacts WHERE ID IN @Ids", new { Ids = ids }).ToList();
        }

        #region Private Methods

        private void EnsureOpenConnection()
        {
            if (this.db.State != ConnectionState.Open)
            {
                this.db.Open();
            }
        }

        #endregion

        public void Dispose()
        {
            if (db != null)
            {
                if (this.db.State != ConnectionState.Closed)
                {
                    this.db.Close();
                }
            }
        }

        #region Not implemented from IBaseRepository

        public Task<Contact> AddAsync(Contact t)
        {
            throw new NotImplementedException();
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(Contact t)
        {
            throw new NotImplementedException();
        }

        public Contact Find(Expression<Func<Contact, bool>> match)
        {
            throw new NotImplementedException();
        }

        public List<Contact> FindAll(Expression<Func<Contact, bool>> match)
        {
            throw new NotImplementedException();
        }

        public Task<List<Contact>> FindAllAsync(Expression<Func<Contact, bool>> match)
        {
            throw new NotImplementedException();
        }

        public Task<Contact> FindAsync(Expression<Func<Contact, bool>> match)
        {
            throw new NotImplementedException();
        }

        public Task<List<Contact>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Contact> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Contact> UpdateAsync(Contact updated, int key)
        {
            throw new NotImplementedException();
        }

        #endregion



        
    }
}