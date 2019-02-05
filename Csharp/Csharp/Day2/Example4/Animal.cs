
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Csharp.Day2.Example4
{
    class Animal
    {
        
        private string name;
        private string sound;

        public readonly int IdAnimal;


        // difie a constat value
        public const string caption = "this is a caption";



        public Animal()
        {
            name = "sans nom";
            sound = "sans son";
            numAnimal++;

            Random rdm = new Random();
            IdAnimal = rdm.Next(int.MinValue, int.MaxValue);
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

        public void SatName(string v)
        {
            // i dont accept name with number

            if (!v.Any(char.IsDigit))
            {
                this.name = v;
            }
            else
            {
                this.name = " No Name";
                Console.WriteLine("given Name contains number");
            }

        }

        public static int numAnimal = 0;

        public static int NumAnimal
        {
            get { return numAnimal; }
            set { numAnimal += value; }
        }

        public string getName()
        {
            return this.name;
        }


        // the recommanded way is to use getter and setter with properities

        public string Sound
        {
            get { return sound; }
            set
            {
                if (value.Length > 10)
                {
                    this.name = " No Sound";
                    Console.WriteLine("given sound contains more then 10 digits");
                }
                else
                {
                    sound = value;
                }
            }
        }

        public string Owner { get; set; } = "No Owner";





        public void MakeSound()
        {
            Console.WriteLine("{0} say {1}", name, sound);
        }


        internal static int GetNum()
        {
            return numAnimal;
        }
    }
}