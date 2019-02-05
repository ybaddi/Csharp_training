
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Csharp.Day2.Example2
{
    class ShapsMath
    {
        public static double GetArea(string v1, int v2, int v3)
        {

            if(String.Equals("Rectangle",v1,
                StringComparison.OrdinalIgnoreCase))
            {
                return v2 * v3;
            }
            else if (String.Equals("Triangle", v1,
                StringComparison.OrdinalIgnoreCase))
            {
                return v2 * (v3 /2);
            }
            else if (String.Equals("Circle", v1,
                StringComparison.OrdinalIgnoreCase))
            {
                return 3.14159 * Math.Pow(v2,2);
            }
            else
            {
                return -1;
            }

            
        }
    }
}