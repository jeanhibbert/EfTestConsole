using Gazprom.BigBoy.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EfTestConsole.Helpers;

namespace EfTestConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            HibernatingRhinos.Profiler.Appender.EntityFramework.EntityFrameworkProfiler.Initialize();

            // ------------------------ Lazy vs Deep load EF queries ----------------------------------//

            

        }
    }
}
