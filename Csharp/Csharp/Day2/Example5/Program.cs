
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Csharp.Day2.Example5
{
    class Program
    {
        static void Main1(string[] args)
        {
            Animal anim1 = new Animal()
            {
                Name = " anim1",
                Sound = "Moaw"
            };

            Dog dog1 = new Dog()
            {
                Name = " dog1",
                Sound = "Moaw"
            };

            Animal dog2 = new Dog()
            {
                Name = " dog1",
                Sound = "Moaw"
            };

            anim1.MakeSound();
            dog1.MakeSound();
            dog2.MakeSound();

            Console.WriteLine("dog {0} and sound1 and 2 is {1} et {2} ",
                dog1.Name, dog1.Sound, dog1.Sound2);

            // test of inner class
            Animal.AnimalHealth getHelth = new Animal.AnimalHealth();

            Console.WriteLine("is my animal healty: {0} ",
                getHelth.HealthWeight(11,50));

            // test included class
            anim1.SetAnimalInfo(12345, "baddi");
            anim1.GetAnimalInfo();

            dog1.SetAnimalInfo(123456, "baddi1");
            dog1.GetAnimalInfo();


            Console.ReadLine();
        }
    }
}