using System;

namespace StyleCop1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();
            Console.BackgroundColor = ConsoleColor.Red;
            int hr = 2; // SA1121
        }

        private static void Test()
        {
        }
    }
}
