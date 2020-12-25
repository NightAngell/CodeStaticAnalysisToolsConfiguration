using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using ConsoleApp;
using Lol = System;

namespace ConsoleApp
{

    /// <summary>
    /// Violation of SA1506ElementDocumentationHeadersMustNotBeFollowedByBlankLine below
    /// </summary>

    public class Program
    {

#pragma warning disable IDE0060 // Remove unused parameter
        internal static void Main(string[] args) // SA1505OpeningBracesMustNotBeFollowedByBlankLine
#pragma warning restore IDE0060 // Remove unused parameter
        {
            // Violation of SA1500BracesForMultiLineStatementsMustNotShareLine
            if (true) {
                int number = 5;
                Console.WriteLine(number);
            }

            // Violation of SA1503BracesMustNotBeOmitted
            if (true)
                return;
        }



        private bool _enabled = false;
        public bool Enabled
        {
            get { return _enabled; } // Violation of SA1504AllAccessorsMustBeSingleLineOrMultiLine

            set
            {
                _enabled = value; // Violation of SA1508ClosingBracesMustNotBePrecededByBlankLine below

            }
        }

        // Violation of SA1501StatementMustNotBeOnSingleLine
        public object Method()
        {
            lock (this) { return this; }
        }

        // Violation of SA1502ElementMustNotBeOnSingleLine
        public object Method2() { return null; }
    }
}