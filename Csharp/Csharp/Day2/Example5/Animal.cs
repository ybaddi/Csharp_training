
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Csharp.Day2.Example5
{
    class Animal
    {
        protected string name;
        protected string sound;


        //
        protected AnimalInfo animalInfo = new AnimalInfo();

        public void SetAnimalInfo(int num,string owner)
        {
            animalInfo.Num = num;
            animalInfo.Owner = owner;
        }

        public void GetAnimalInfo()
        {
            Console.WriteLine($"{ Name} has the ID of {animalInfo.Num} and is owner is {animalInfo.Owner}");
        }


        //
        public Animal()
            : this("no name", "no sound") { }

        public Animal(string v1)
        {
            this.name = v1;
        }

        public Animal(string v1, string v2)
        {
            this.name = v1;
            this.sound = v2;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (!value.Any(char.IsDigit))
                {
                    this.name = value;
                }
                else
                {
                    this.name = " No Name";
                    Console.WriteLine("given Name contains number");
                }
            }
        }

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


        public virtual  void MakeSound()
        {
            Console.WriteLine("{0} say {1}" , name,sound);
            Console.WriteLine($"{Name} say {Sound}");
        }


        // create inner class that are normally help this classe

        public class AnimalHealth
        {
            public bool HealthWeight(double height, double weight)
            {
                double calc = height / weight;
                if ((calc <= .18) && (calc <= .27))
                { return true; }
                else return false;
            }
        }


    }
}