using System;
using static System.Console;

namespace ConsoleApp
{
    internal class Program32
    {
        public class Test : IDisposable
        {
            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }

        internal static int Main(string[] args)
        {
            using (var xz = new Test())
            using (var x = new Test())
                return 3;
        }
    }
}