
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Csharp.Day3.Example2
{
    class Program
    {
        static void Main1(string[] args)
        {

            Car audi = new Car("Audi", 4, 300);
            Shape s = new Shape();


            // if thi scar is drivable

            if (audi is Idrivable)
            {
                Console.WriteLine("yes audi is drivable");
            }

            if (s is Idrivable)
            {
                Console.WriteLine("yes s is drivable");
            }
            else
            {
                Console.WriteLine("no s isn't drivable");
            }

            Console.ReadLine();
        }
    }
}