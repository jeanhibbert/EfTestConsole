namespace EfTest.AdventurWorks.Model.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using EfTest.AdventureWorks.Model.Models;

    public class TestEntity1
    {
        #region Public Properties

        public int TestEntity1Id { get; set; }

        public virtual ICollection<Contact> Contact { get; set; }

        [Index(IsUnique = true, IsClustered = false)]
        [MaxLength(100)]
        public string Name { get; set; }

        #endregion
    }
}