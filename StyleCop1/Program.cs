// Copyright (c) Mateusz Soboń. All rights reserved.

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
        public readonly int MyProperty;
        public int MyProperty2;

#pragma warning disable IDE0060 // Remove unused parameter
        internal static void Main(string[] args)
#pragma warning restore IDE0060 // Remove unused parameter
        {
            var baseClass = new BaseClass("test");
            if (baseClass == null)
            {
              
            }
        }

    }
}