using System;
using System.Collections.Generic;

namespace EfTest.AdventureWorks.Model.Models
{
    public partial class AWBuildVersion
    {
        public byte SystemInformationID { get; set; }
        public string Database_Version { get; set; }
        public System.DateTime VersionDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    }
}
