using Gazprom.BigBoy.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfTestConsole.Demonstration
{
    public class EfQueryGeneration
    {
        public static void ShowSelect()
        {
            //Lazy load entity
            using (GasNominations_Endur_prodContext context = new GasNominations_Endur_prodContext())
            {
                var shipperPreliminaryBalances = context.ShipperPreliminaryBalances.Take(10)
                    .Select(s => s);

                foreach (var spb in shipperPreliminaryBalances)
                {
                    Console.WriteLine(spb.ShipperPreliminaryBalanceId);
                    Console.WriteLine(spb.SumRequestedDailyMetered);
                    Console.WriteLine(spb.NominationSystemType.Name); // Causes an additional database hit
                    Console.WriteLine("----------------------------------------------");
                }
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();


            //Deep load entity
            using (GasNominations_Endur_prodContext context = new GasNominations_Endur_prodContext())
            {
                var shipperPreliminaryBalances = context.ShipperPreliminaryBalances.Include("NominationSystemType").Take(10)
                    .Select(s => s);

                foreach (var spb in shipperPreliminaryBalances)
                {
                    Console.WriteLine(spb.ShipperPreliminaryBalanceId);
                    Console.WriteLine(spb.SumRequestedDailyMetered);
                    Console.WriteLine(spb.NominationSystemType.Name); // Does not cause an additional database hit
                    Console.WriteLine("----------------------------------------------");
                }
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();


            // ------------------------ Anonymous type EF queries ----------------------------------// 

            //Select with projection using anonymous type
            using (GasNominations_Endur_prodContext context = new GasNominations_Endur_prodContext())
            {
                var shipperPreliminaryBalances = context.ShipperPreliminaryBalances.Take(10)
                    .Select(s => new { s.ShipperPreliminaryBalanceId, s.SumRequestedDailyMetered });

                foreach (var spb in shipperPreliminaryBalances)
                {
                    Console.WriteLine(spb.ShipperPreliminaryBalanceId);
                    Console.WriteLine(spb.SumRequestedDailyMetered);
                    Console.WriteLine("----------------------------------------------");
                }
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();


            //Deep load select into anonymous type
            using (GasNominations_Endur_prodContext context = new GasNominations_Endur_prodContext())
            {
                var shipperPreliminaryBalances = context.ShipperPreliminaryBalances.Take(10)
                    .Select(s => new { s.ShipperPreliminaryBalanceId, s.SumRequestedDailyMetered, s.NominationSystemType });

                foreach (var spb in shipperPreliminaryBalances)
                {
                    Console.WriteLine(spb.ShipperPreliminaryBalanceId);
                    Console.WriteLine(spb.SumRequestedDailyMetered);
                    Console.WriteLine(spb.NominationSystemType.Name);
                    Console.WriteLine("----------------------------------------------");
                }
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            //Deep load select in anonymous type with specifying referenced entity fields
            using (GasNominations_Endur_prodContext context = new GasNominations_Endur_prodContext())
            {
                var shipperPreliminaryBalances = context.ShipperPreliminaryBalances.Take(10)
                    .Select(s => new { s.ShipperPreliminaryBalanceId, s.SumRequestedDailyMetered, s.NominationSystemType.Name });

                foreach (var spb in shipperPreliminaryBalances)
                {
                    Console.WriteLine(spb.ShipperPreliminaryBalanceId);
                    Console.WriteLine(spb.SumRequestedDailyMetered);
                    Console.WriteLine(spb.Name);
                    Console.WriteLine("----------------------------------------------");
                }
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
