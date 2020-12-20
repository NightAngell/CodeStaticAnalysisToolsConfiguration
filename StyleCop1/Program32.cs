using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using static System.Console;

namespace ConsoleApp
{
    /// <summary>
    /// The main <c>Math</c> class.
    /// Contains all methods for performing basic math functions.
    /// <list type="bullet">
    /// <item>
    /// <term>Add</term>
    /// <description>Addition Operation</description>
    /// </item>
    /// <item>
    /// <term>Subtract</term>
    /// <description>Subtraction Operation</description>
    /// </item>
    /// <item>
    /// <term>Multiply</term>
    /// <description>Multiplication Operation</description>
    /// </item>
    /// <item>
    /// <term>Divide</term>
    /// <description>Division Operation</description>
    /// </item>
    /// </list>
    /// </summary>
    internal class Program32
    {
        /// <value>Gets the value of PI.</value>
        public static Program32 operator +(Program32 a, Program32 b) { return null; }

        public int Xdd
        {
            get;

            set;
        }

        /// <summary>
        ///     Defines the entry point of the application.
        /// 
        /// </summary>
        /// <param name="args">The arguments.</param>
        internal static void Main(string[] args)
        {
            var a = new[] { 1, 10, 100, 1000 };
            var aB = new[] { 1, 10, 100, 1000 };
        }

        public int MyProperty { get; set; }
        public string Sss { get; set; }

        public class Test : IDisposable
        {
            public void Dispose()
            {
                // throw new NotImplementedException();
            }
        }
    }
}