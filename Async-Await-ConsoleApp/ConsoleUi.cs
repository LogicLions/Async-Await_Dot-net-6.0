namespace Async_Await_ConsoleApp
{
    public static class ConsoleUi
    {
        public static void Info(string message)
        {
            Console.WriteLine(message);
        }

        public static void Warn(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("**Warning**: " + message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("**Error**: "+message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void DashLine() 
        {
            Console.WriteLine("---------------------------------------------------------");
        }
    }
}
