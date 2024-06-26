using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public  class Kitchen
    {
        //Sync
        public static void MakeTea()
        {
            var water = BoilWater();

            Console.WriteLine("take the cup out");
            Console.WriteLine("put tea in cup");
            Console.WriteLine("put sugar in cup");
            Console.WriteLine($"pour{water} in cup");
        }

        private static string BoilWater() 
        {
            Console.WriteLine("Start the kattle");

            Console.WriteLine("Waiting for  the kattle");

            Task.Delay(5000).GetAwaiter().GetResult();

            Console.WriteLine("kattel  finished boiling");

            return "Water";

        }

        //Async
        public static async Task MakeTeaAsync()
        {
            var boilingwater = BoilWaterAsync();

            Console.WriteLine("take the cup out");
            Console.WriteLine("put tea in cup");
            Console.WriteLine("put sugar in cup");

            var water = await boilingwater;

            Console.WriteLine($"pour {water} in cup");
        }

        private static async Task<string> BoilWaterAsync()
        {
            Console.WriteLine("Start the kattle");

            Console.WriteLine("Waiting for  the kattle");

           await Task.Delay(5000);

            Console.WriteLine("kattel  finished boiling");

            return "Water";

        }

    }
}
