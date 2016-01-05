using EfTest.AdventureWorks.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfTest.AdventurWorks.Model.Models
{
    public class TestEntity1
    {
        public int TestEntity1Id { get; set; }
        public string Name { get; set; }
        public Product Product { get; set; }
    }
}
