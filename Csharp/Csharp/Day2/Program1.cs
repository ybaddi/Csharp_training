
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Csharp.Day2
{
    class Program1
    {
        // Struct
        static void Main1(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.lenght = 200;
            rect.width = 10;

            Console.WriteLine(" le rectangle rec a un legth = {0}", 
                rect.lenght);

            Rectangle rect2 = rect;
            rect2.lenght = 300;

            Console.WriteLine(" le rectangle rec a un legth = {0}",
                rect.lenght);
            Console.WriteLine(" le rectangle rec a un legth = {0}",
                rect2.lenght);

            Rectangle rect3 = new Rectangle(100,400);
            Console.WriteLine(" le rectangle rec a un legth = {0}",
                rect3.lenght);

            Console.WriteLine(" le rectangle rec a un legth = {0}",
                rect3.area());

            Console.ReadLine();
        }
         struct Rectangle
        {
            public double lenght;
            public double width;

            // contructeur
            public Rectangle(double l = 1, double w=1)
            {
                lenght = l;
                width = w;
            }

            internal double area()
            {
                return lenght * width;
            }
        }

    }
}