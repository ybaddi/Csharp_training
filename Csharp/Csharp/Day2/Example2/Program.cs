
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Csharp.Day2.Example2
{
    class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("area of the Rectangle : {0}",
                ShapsMath.GetArea("rectangle", 5, 6));

            Console.WriteLine("area of the Triangle : {0}",
                ShapsMath.GetArea("triangle", 5, 6));

            //Console.WriteLine("area of the shap : {0}",
            // ShapsMath.GetArea("shap", 5, 6,7));  
            Console.ReadLine();
        }
    }
}