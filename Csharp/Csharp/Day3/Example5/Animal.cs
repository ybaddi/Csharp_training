using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Day3.Example5
{
    class Animal
    {
        public string Name { get; set; }
        

        public Animal(string name = "No Name")
        {
            Name = name;
        }

        public  static void GetSum<T>(ref T x, ref T y)
        {
            double dblX = Convert.ToDouble(x);
            double dblY = Convert.ToDouble(y);
            Console.WriteLine($"{dblX} + {dblY} = {dblX + dblY}");
        }
    }
}
