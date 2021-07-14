using System;
using System.Threading.Tasks;

namespace AsyncAwait
{
    public class Bacon
    {
        public static async Task<Bacon> FryBaconAsync(int numberOfBacons)
        {
            Console.WriteLine($"Putting {numberOfBacons} bacons in the pan");
            Console.WriteLine("cooking first side of bacon");
            await Task.Delay(3000);
            Console.WriteLine("cooking the second side of bacon...");
            await Task.Delay(3000);
            Console.WriteLine("Put the bacon on plate");
            return new Bacon();
        }
    }
}
