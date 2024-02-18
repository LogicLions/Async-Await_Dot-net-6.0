using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async_Await_ConsoleApp
{
    public class AsynchronousProcessor
    {
        public static void Start()
        {
            Console.WriteLine("Started Tasks!!!");
            string clothes = WashingClothes();
            DryClothes(clothes);
            CleanHouse();
            CookFood();
        }

        public static string WashingClothes()
        {
            Console.WriteLine("-Washing Clothes...");
            Task.Delay(1000).Wait();
            Console.WriteLine("*Clothes washed.");
            string clothes = "Wet Clothes.";
            return clothes;
        }

        private static void DryClothes(string clothes)
        {
            Console.WriteLine("-Clothes Drying...");
            Task.Delay(3000).Wait();
            Console.WriteLine("*Clothes Dried.");
        }

        private static void CleanHouse()
        {
            Console.WriteLine("-Cleaning House...");
            Task.Delay(500).Wait();
            Console.WriteLine("*House Cleaned.");
        }

        private static void CookFood()
        {
            Console.WriteLine("-Cooking food...");
            Task.Delay(1000).Wait();
            Console.WriteLine("*Food Cooked.");
        }
    }
}
