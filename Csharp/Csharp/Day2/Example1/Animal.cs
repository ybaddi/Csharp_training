
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Csharp.Day2.Example1
{
    class Animal
    {
        private static int numAnimal = 0;
        public string name;
        public string sound;

        public Animal()
        {
            name = "sans nom";
            sound = "sans son";
            numAnimal++;
        }

        public Animal(string n = "sans nom1")
        {
            name = n;
            sound = "sans son";
            numAnimal++;
        }
        public Animal(string n = "sans nom2", string s = "sans son2")
        {
            name = n;
            sound = s;
            numAnimal++;
        }

        public void MakeSound()
        {
            Console.WriteLine("{0} say {1}", name,sound);
        }


        internal static int GetNum()
        {
            return numAnimal;
        }
    }
}