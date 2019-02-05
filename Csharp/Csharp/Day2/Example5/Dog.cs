
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Csharp.Day2.Example5
{
    class Dog : Animal
    {
        // you can add more fields
        public string Sound2 { get; set; } = "dogSound";

        // create a constructor that use parent constructor
        public Dog(string name = "No name",
            string sound = "No Sound ",
            string sound2 = "No Sound 2"
            ): base(name,sound)
        {
            Sound2 = sound2;
        }

        /*
        public new void MakeSound()
        {
            Console.WriteLine("{0} say {1}", name, sound);
            Console.WriteLine($"{Name} say {Sound}");
        }*/

        public override void MakeSound()
        {
            Console.WriteLine("{0} say {1}", name, sound);
            Console.WriteLine($"{Name} say {Sound}");
        }

    }
}