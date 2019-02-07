using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;


namespace Csharp.Day3.Example5
{
    class Program
    {
        static void Main1(string[] args)
        {
            List<Animal> animalLists = new List<Animal>();

            // we can create a list of standar type
            List<int> intlist = new List<int>();

            intlist.Add(24);

            // add
            animalLists.Add(new Animal() { Name = "cat1" });
            animalLists.Add(new Animal() { Name = "cat2" });
            animalLists.Add(new Animal() { Name = "cat3" });
            animalLists.Add(new Animal() { Name = "cat4" });
            // insert at index
            animalLists.Insert(1, new Animal() { Name = "cat5" });

            // Remove index 1
            animalLists.RemoveAt(2);

            // count the size
            Console.WriteLine($"number of animals is {animalLists.Count}");



            // list<T>, arraylist<T> dictionary<T,T> queue<T> stack<T>
            int x = 4, y = 5;
            Animal.GetSum<int>(ref x, ref y);

            string xstr = "4", ystr = "5";
            Animal.GetSum(ref xstr, ref ystr);

            // example with struct
            Rectangle<int> rect = new Rectangle<int>(20, 50);
            Console.WriteLine(rect.GetArea());

            Rectangle<string> rect1 = new Rectangle<string>("20", "50");
            Console.WriteLine(rect1.GetArea());

            ///
            animalHealt h1 = new animalHealt();
            animalHealt h2 = new animalHealt();
            //Animal.GetSum(ref h1, ref h2);

            // delegate 
            Arithmitic add, sub, addSub;

            add = new Arithmitic(Add);

            sub = new Arithmitic(Sub);

            addSub = add + sub;

            add(4, 5);
            sub(6, 3);
            addSub(2, 7);

            string response = Console.ReadLine();
            /*switch (response)
                {
                case "add"
                    add = Arith ...
            }
            */
            Console.ReadLine();
        }


        struct Rectangle<T>
        {

            private T length;
            private T width;

            public T Length
            {
                get { return length; }
                set { length = value; }
            }


            public T Width
            {
                get { return width; }
                set { width = value; }
            }

            public Rectangle(T l, T w)
            {
                length = l;
                width = w;
            }

            public string GetArea()
            {
                double dblX = Convert.ToDouble(Length);
                double dblY = Convert.ToDouble(Width);
                return $"{dblX} + {dblY} = {dblX * dblY}";
            }

        }

        // call of delegate
        public delegate void Arithmitic(double x, double y);

        public static void Add(double x, double y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public static void Sub(double x, double y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

    }


}
