
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Csharp.Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] Shapes = { new Circle(5), new Rectangle(5, 3) };

            foreach (Shape shape in Shapes)
            {
                Console.WriteLine("######################3");
                shape.GetInfo();
                Console.WriteLine("{0} Area : {1:f2}", shape.Name, shape.Area());

                // use as to chech if an object is of a type
                Circle testIsCercle = shape as Circle;
                if(testIsCercle == null)
                {
                    Console.WriteLine("is not a circle");
                }

                // test if is a specific type with is
                if(shape is Circle)
                {
                    Console.WriteLine("is a circle");
                }


            }

            

            // 
            Object circle1 = new Circle(4);

            Circle circle2 = (Circle)circle1;
            Console.WriteLine("{0} Area : {1:f2}", circle2.Name, circle2.Area());


            Console.ReadLine();
        }       

    }
}