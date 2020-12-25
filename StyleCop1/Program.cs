using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using ConsoleApp;
using Lol = System;

namespace ConsoleApp
{

    public class Program
    {

        internal static void Main(string[] args)

        {
            // Violation of SA1500BracesForMultiLineStatementsMustNotShareLine
            if (true) {
                int number = 5;
                Console.WriteLine(number);
            }
        }
    }
}