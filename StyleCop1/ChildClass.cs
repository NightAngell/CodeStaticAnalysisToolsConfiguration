using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace ConsoleApp
{
    public class ChildClass : BaseClass
    {
        public ChildClass() : base("test")
        {
            this.Name = ToString();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public string GetHardCodedString(string xd,
                                         int x)
        {
            return string.Empty;
        }

        public int this[int index]
        {
            get => index;
        }
    }
}
