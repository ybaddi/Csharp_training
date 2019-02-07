using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Day4.Example2
{
    class Program
    {
        static void Main1(string[] args)
        {
            AnimalContenair myAnimalContenaire = new AnimalContenair();

            // add animals
            myAnimalContenaire[0] = new Animal("cat1");
            myAnimalContenaire[1] = new Animal("cat2");
            myAnimalContenaire[2] = new Animal("cat3");
            myAnimalContenaire[3] = new Animal("cat4");

            foreach ( Animal i in myAnimalContenaire)
            {
                Console.WriteLine(i.Name);
            }

            // AnimalContenair

            //AnimalNotContenaire'

            AnimalNotContenaire c1 = new AnimalNotContenaire(1, 2, 3);
            AnimalNotContenaire c2 = new AnimalNotContenaire(3, 4, 5);
            AnimalNotContenaire c3 = c1 + c2;

            Console.WriteLine(c3.Length);
            Console.WriteLine(c3.Width);
            Console.WriteLine(c3.Poind);

            // example to overload ToString operator
            Console.WriteLine($"c3 is {c3}");


            // convert to int 
            Console.WriteLine($"c3 is {(int)c3}");

            AnimalNotContenaire c4 = (AnimalNotContenaire) 3;
            Console.WriteLine($"c4 is {c4}");


            // we can try to build a simple class 
            // that contains fields and anonymous types 
            var anonymous = new { Name = " anonymous", length = 4.55 };
            Console.WriteLine($" {anonymous.Name}");

            Console.WriteLine($" {anonymous.GetType()}");

            var anonymousArray = new[] {
                new { Name = " anonymous", length = 4.55 },
                new { Name = " anonymous", length = 4.55 }
                };
            foreach (var i in anonymousArray)
            {
                Console.WriteLine($" {i.Name} with length {i.length}");
            }


            Console.ReadLine();
        }
    }
}
