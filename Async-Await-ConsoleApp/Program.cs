using Async_Await_ConsoleApp;
using System.Diagnostics;

namespace Async_Await_ConsoleApp
{
    public class program
    {
        public static void Main(string[] args)
        {
            ConsoleUi.DashLine();
            Console.WriteLine("Choose Operation below (Press 1 or 2 and Press Enter Key.)");
            Console.WriteLine("1.Synchronous Operation.");
            Console.WriteLine("2.Asynchronous Operation.");
            ConsoleUi.DashLine();

            int input = Convert.ToInt32(Console.ReadLine());

            try
            {
                Stopwatch sw = Stopwatch.StartNew();
                if (input == 1)
                {
                    SynchronousProcessor.Start(sw);
                }
                else if (input == 2)
                {
                    AsynchronousProcessor.Start(sw);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong Choice!!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            catch (Exception ex)
            {
                ConsoleUi.Error(ex.Message);
            }

            Console.ReadKey();
        }
    }
}

