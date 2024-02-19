using System.Diagnostics;

namespace Async_Await_ConsoleApp
{
    public class AsynchronousProcessor
    {
        public static async void Start(Stopwatch sw)
        {
            Console.WriteLine("Started Tasks!!!");
            Task t1 = WashAndDryClothes();
            Task t2 = CleanHouse();
            Task t3 = CookFood();

            await Task.WhenAll(t1, t2, t3);
            TasksCompleted(sw);

            ConsoleUi.DashLine();
            Console.WriteLine("Press any key to exit.");
        }

        public static async Task WashAndDryClothes()
        {
            string clothes = await WashingClothes();
            await DryClothes(clothes);
        }

        public static async Task<string> WashingClothes()
        {
            Console.WriteLine("-Started Washing Clothes...");
            await Task.Delay(1000);
            Console.WriteLine("*Completed Washing Clothes.");
            string clothes = "Wet Clothes.";
            return clothes;
        }

        public static async Task DryClothes(string clothes)
        {
            Console.WriteLine("-Started Drying Clothes...");
            await Task.Delay(3000);
            Console.WriteLine("*Completed Drying Clothes.");
        }

        public static async Task CleanHouse()
        {
            Console.WriteLine("-Started Cleaning House...");
            await Task.Delay(500);
            Console.WriteLine("*Completed Cleaning House.");
        }

        public static async Task CookFood()
        {
            Console.WriteLine("-Started Cooking Food...");
            await Task.Delay(1000);
            Console.WriteLine("*Completed Cooking Food.");
        }

        private static void TasksCompleted(Stopwatch sw)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("**All tasks completed!!");
            sw.Stop();
            Console.WriteLine($"Execution Time: {Convert.ToInt32(sw.Elapsed.TotalMilliseconds)} milliseconds.");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
