using System;
using System.Threading.Tasks;

namespace AsyncAwait
{
    public class Egg
    {
       public static async Task<Egg> FryEggs(int numberOfEggs)
        {
            Console.WriteLine("Warming the egg pan...");
            await Task.Delay(3000);
            Console.WriteLine($"cracking {numberOfEggs} eggs");
            Console.WriteLine("cooking the eggs...");
            await Task.Delay(3000);
            Console.WriteLine("Put the eggs on plate");
            return new Egg();
        }
    }
}
