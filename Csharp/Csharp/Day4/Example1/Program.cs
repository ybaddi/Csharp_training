using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Day4.Example1
{
    class Program
    {
        delegate double DoubleIt(double val);
        static void Main1(string[] args)
        {
            // lambda
            DoubleIt db = x => x * 2;
            Console.WriteLine($"4*2 = {db(4)}");

            #region Where

            // lambda  with list 
            List<int> nlist = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var impaireList = nlist.Where(x => x % 2 != 0).ToList();

            foreach (var v in impaireList)
            {
                Console.WriteLine(v);
            }

            // get a rang of value with lambda    x<3>8
            var rangList = nlist.Where(x => (x > 2) && (x < 8)).ToList();

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
                i++;
            }

            Console.WriteLine("equal to 1 : {0}", intlist.Where(x => x == 1).ToList().Count);
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

            #endregion

            #region Select 
            // select on each element in a list  with a lambda function
            Console.WriteLine("##########################");
            // add a list from 1 to 10
            var blist = new List<int>();
            blist.AddRange(Enumerable.Range(1,10));

            var bsquareList = blist.Select(x => Math.Pow(x, 2));
            foreach (var v in bsquareList)
            {
                Console.WriteLine(v);
            }

            #endregion

            #region Zip

            // ZIP
            var clist = new List<int>() { 1, 3, 4 , 8 , 4, 3 };
            // List<int> dlist = null // fire argumnentNullException
            var dlist = new List<int>() { 5, 6, 7,4,8 };
            var sumList = clist.Zip(dlist, (x, y) => x + y).ToList();
            foreach (var v in sumList)
            {
                Console.WriteLine(v);
            }

            var c1list = new List<string>() { "1", "3", "4" };
            var d1list = new List<string>() { "5", "6", "7" };
            var sum1List = clist.Zip(dlist, (x, y) => $"{x}  {y}").ToList();
            foreach (var v in sum1List)
            {
                Console.WriteLine(v);
            }

            var sum2List = clist.Where(x => dlist.Contains(x)).ToList().Select(x => x * x);   //  .Zip(c1list, (x, y) => x + y).ToList();
            foreach (var v in sum2List)
            {
                Console.WriteLine(v);
            }

            // zip entre les deux list where les element sont

            // Aggregation
            // an operation on each item in a list and forward the result
            Console.WriteLine(" Aggregation : {0}", 
                clist.Aggregate( (a,b) => a+b ));

            // AVG
            Console.WriteLine(" AVG : {0}", clist.AsQueryable().Average());

            // ALL
            Console.WriteLine(" All : {0}", clist.All(x => x >3));
            Console.WriteLine(" All : {0}", clist.All(x => x < 9));
            // 

            // Any
            Console.WriteLine(" All : {0}", clist.Any(x => x > 3));
            Console.WriteLine(" All : {0}", clist.Any(x => x > 9));

            // Distinct
            Console.WriteLine(" Dist : {0}", string.Join(",", clist.Distinct()));
            clist = clist.Distinct().ToList();
            foreach (var v in clist)
            {
                Console.WriteLine(v);
            }

            //Expect
            // receive two list and return veluess not found in the second list
            Console.WriteLine(" Dist : {0}", 
                string.Join(",", clist.Except(clist)));

            // INTERSEC
            // receive two list and return velues
            // found in the second list
            Console.WriteLine(" Dist : {0}",
                string.Join(",", clist.Intersect(dlist)));
            
            #endregion

            Console.ReadLine();
        }
    }
}
