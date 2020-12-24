using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsoleApp
{
    public class BaseClass
    {
        public string Name { get; set; }

        public BaseClass(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }
    }
}
