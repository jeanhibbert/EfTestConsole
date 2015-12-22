using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfTestConsole.Demonstration
{
    using EfTest.AdventureWorks.Model.Models;

    public class EfQueryGeneration
    {
        public static void ShowSelect()
        {
            //Lazy load entity
            using (var context = new AdventureWorksContext())
            {
                var contacts = context.Contacts.Take(10)
                    .Select(s => s);

                foreach (var c in contacts)
                {
                    Console.WriteLine(c.ContactID);
                    Console.WriteLine(c.EmailAddress);
                    Console.WriteLine(c.Individuals.Any()); // Causes an additional database hit
                    Console.WriteLine("----------------------------------------------");
                }
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();


            //Deep load entity
            using (var context = new AdventureWorksContext())
            {
                var employees = context.Contacts.Include("Employees").Take(10)
                    .Select(s => s);

                foreach (var e in employees)
                {
                    Console.WriteLine(e.Employees.Count);
                    //Console.WriteLine(e.Employees.Name); // Does not cause an additional database hit
                    Console.WriteLine("----------------------------------------------");
                }
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();


            // ------------------------ Anonymous type EF queries ----------------------------------// 

            //Select with projection using anonymous type
            using (var context = new AdventureWorksContext())
            {
                //var shipperPreliminaryBalances = context.ShipperPreliminaryBalances.Take(10)
                //    .Select(s => new { s.ShipperPreliminaryBalanceId, s.SumRequestedDailyMetered });

                //foreach (var spb in shipperPreliminaryBalances)
                //{
                //    Console.WriteLine(spb.ShipperPreliminaryBalanceId);
                //    Console.WriteLine(spb.SumRequestedDailyMetered);
                //    Console.WriteLine("----------------------------------------------");
                //}
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();


            //Deep load select into anonymous type
            using (var context = new AdventureWorksContext())
            {
                //var shipperPreliminaryBalances = context.ShipperPreliminaryBalances.Take(10)
                //    .Select(s => new { s.ShipperPreliminaryBalanceId, s.SumRequestedDailyMetered, s.NominationSystemType });

                //foreach (var spb in shipperPreliminaryBalances)
                //{
                //    Console.WriteLine(spb.ShipperPreliminaryBalanceId);
                //    Console.WriteLine(spb.SumRequestedDailyMetered);
                //    Console.WriteLine(spb.NominationSystemType.Name);
                //    Console.WriteLine("----------------------------------------------");
                //}
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            //Deep load select in anonymous type with specifying referenced entity fields
            using (var context = new AdventureWorksContext())
            {
                //var shipperPreliminaryBalances = context.ShipperPreliminaryBalances.Take(10)
                //    .Select(s => new { s.ShipperPreliminaryBalanceId, s.SumRequestedDailyMetered, s.NominationSystemType.Name });

                //foreach (var spb in shipperPreliminaryBalances)
                //{
                //    Console.WriteLine(spb.ShipperPreliminaryBalanceId);
                //    Console.WriteLine(spb.SumRequestedDailyMetered);
                //    Console.WriteLine(spb.Name);
                //    Console.WriteLine("----------------------------------------------");
                //}
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
