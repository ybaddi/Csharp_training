
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Csharp.Day2.Example3
{
    class ProgramNullable
    {
        static void Main1(string[] Main)
        {
            int num = 0;
            int? num1 = null;

            // classic test 
            if ( num1 == null)
            {
                Console.WriteLine("num2 is null");
            }

            if (! num1.HasValue)
            {
                Console.WriteLine("num2 is null");
            }

            Console.ReadLine();
        }
    }
}