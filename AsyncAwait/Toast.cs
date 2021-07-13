using System;
using System.Threading.Tasks;

namespace AsyncAwait
{
    public class Toast
    {
       public static async Task<Toast> ToastBread(int slices)
        {
            for(int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("Putting a slice of bread in the toaster");
            }

            Console.WriteLine("Start toasting");
            await Task.Delay(3000);
            Console.WriteLine("Remove toast from toaster");
            return new Toast();
        }

        public static void ApplyJam(Toast toast)
        {
            Console.WriteLine("Applying jam to toast");
        }

        public static void ApplyButter(Toast toast)
        {
            Console.WriteLine("Applying butter to toast");
        }

        public static async Task<Toast> MakeToastWithButterAndJam(int number)
        {
            var toast = await ToastBread(number);
            ApplyJam(toast);
            ApplyButter(toast);

            return toast;

        }
    }
}
