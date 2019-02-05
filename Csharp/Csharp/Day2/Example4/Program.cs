
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Csharp.Day2.Example4
{
    class Program
    {
        static void Main1(string[] args)
        {
            

            //////////////////////////////
            ///
            Animal cat = new Animal();
            Animal cat2 = new Animal();

            cat.SatName("cat4Name");

            Console.WriteLine("Animal name is   {0}",
                cat.getName());

            // Console.WriteLine("Animal caption is   {0}",
            //    cat.caption);

            cat.Sound = "cat4Sound";
            Console.WriteLine("Animal name is   {0}",
                cat.Sound);


            Console.WriteLine("Animal owner is   {0}",
                cat.Owner);
            cat.Owner = "BAddi";
            Console.WriteLine("Animal owner is   {0}",
               cat.Owner);

            // readonly

            Console.WriteLine("Animal {0} id is  {1} ",
               cat.getName(), cat.IdAnimal);

            // static proprity

            Console.WriteLine("Animal {0} number is  {1} ",
               cat.getName(), Animal.NumAnimal);
            Console.WriteLine("Animal {0} number is  {1} ",
               cat.getName(), Animal.NumAnimal);


            Console.ReadLine();
        }
    }
}