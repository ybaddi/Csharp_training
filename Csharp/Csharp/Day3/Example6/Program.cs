using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Day3.Example6
{
    class Program
    {
        delegate double DoubleIt(double val);
        static void Main1(string[] args)
        {
            // lambda
            DoubleIt db = x => x * 2;
            Console.WriteLine($"4*2 = {db(4)}");


            // lambda  with list 
            List<int> nlist = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var impaireList = nlist.Where(x => x % 2 != 0).ToList();

            foreach(var v in impaireList)
            {
                Console.WriteLine(v);
            }

            // get a rang of value with lambda    x<3>8
            var rangList = nlist.Where(x => (x >2) &&  (x < 8 )).ToList();

            foreach (var v in rangList)
            {
                Console.WriteLine(v);
            }


            // random add element to list 
            List<int> intlist = new List<int>();
            int i = 0;
            Random rdn = new Random();
            while (i < 100)
            {
                intlist.Add(rdn.Next(1, 4));
                   i ++;
            }

            Console.WriteLine("equal to 1 : {0}", intlist.Where(x => x==1).ToList().Count);
            Console.WriteLine("equal to 2 : {0}", intlist.Where(x => x == 2).ToList().Count);
            Console.WriteLine("equal to 3 : {0}", intlist.Where(x => x == 3).ToList().Count);
            Console.WriteLine("equal to 4 : {0}", intlist.Where(x => x == 4).ToList().Count);


            // lambda with string type
            List<string> stringlist = new List<string> { "baddi", " youssef", "Adil", " Aymen" };
            var aNameStrList = stringlist.Where(x => x.ToLower().Trim().StartsWith("a")).ToList();

            foreach (var v in aNameStrList)
            {
                Console.WriteLine(v);
            }

            Console.ReadLine();
        }
    }
}
