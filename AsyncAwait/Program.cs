using System;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class MainClass
    {
        public static async Task Main(string[] args)
        {
            Coffee coffee = new Coffee();
            coffee.PourCoffee();
            Console.WriteLine("coffee is ready");

            Task<Egg> eggsTask = Egg.FryEggs(2);
            Task<Bacon> baconTask = Bacon.FryBacon(2);
            Task<Toast> toastTask = Toast.MakeToastWithButterAndJam(3);

            await Task.WhenAll(eggsTask, baconTask, toastTask);

            Console.WriteLine("eggs are ready");

            Console.WriteLine("bacon is ready");

            Console.WriteLine("toast is ready");

            Juice juice = new Juice();
            juice.PourJuice("orange");
            Console.WriteLine("juice is ready");

            Console.WriteLine("Breakfast is ready");
        }

    }
}
