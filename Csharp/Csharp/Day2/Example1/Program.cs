
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Csharp.Day2.Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal();
            Animal a2 = new Animal("cat");
            Animal a3 = new Animal("cat","meao");
            Animal a4 = new Animal()
            {
                name = "cat",
                sound = "meao"
            };

            Console.WriteLine("Animal est  {0}",
                Animal.GetNum());

            Console.WriteLine("Animal est  {0}",
                a1.name);
            a1.MakeSound();
            a4.MakeSound();

            Console.ReadLine();
        }
    }
}