using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Csharp.Day3
{
    abstract class Shape
    {
        public String Name { get; set; }

        public virtual void GetInfo()
        {
            Console.WriteLine($"this is area {Name}");
        }

        public abstract double Area();

    }
}