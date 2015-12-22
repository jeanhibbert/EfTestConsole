using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EfTestConsole.Helpers;
using EfTestConsole.Demonstration;

namespace EfTestConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            //SqlScriptGenerator.GenerateScript();

            HibernatingRhinos.Profiler.Appender.EntityFramework.EntityFrameworkProfiler.Initialize();

            // ------------------------ Lazy vs Deep load EF queries ----------------------------------//
            EfQueryGeneration.ShowSelect();
            

        }
    }
}
