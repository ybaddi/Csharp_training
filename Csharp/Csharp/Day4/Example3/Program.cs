using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace Csharp.Day4.Example3
{
    class Program
    {
        static void Main1(string[] args)
        {
            generateStrings();

            int[] integers =  generateIntegers();

            generateArrayList();

            generateDataList();

            Console.ReadLine();
        }

        private static void generateDataList()
        {
            Animal[] animals = new[]
            {
                new Animal{Name = "cat",
                Length = .8,
                Width = 2 ,
                ID = 1},
                new Animal{Name = "cat1",
                Length = .8,
                Width = 14,
                ID = 2},
                new Animal{Name = "cat2",
                Length = .8,
                Width = 22,
                ID = 1},
                new Animal{Name = "cat3",
                Length = .8,
                Width = 24,
                ID = 2}

            };

            Owner[] owners = new[]
            {
                new Owner{Name = " baddi", ID = 1},
                new Owner{Name = " baddi1", ID = 2},
                new Owner{Name = " baddi2", ID = 3},
                new Owner{Name = " baddi3", ID = 5}
            };

            // select from animal just name and width
            var nameWidthAnimal = from animal in animals
                                  select new
                                  { animal.Name, animal.Width };

            // convert this table to array
            var arrNameWidthAnimal = nameWidthAnimal.ToArray();

           foreach (var i in arrNameWidthAnimal)
            {
                Console.WriteLine(i);
            }

           Console.WriteLine("###################33");
            // JOIN
            // create an inner join 
            // toin info in owners and animals using 
            // equal value of ID
            var arrayJoin = from animal in animals
                            join owner in owners on animal.ID
                            equals owner.ID
                            select new { OwnerNAme = owner.Name, AnimalName = animal.Name };


            foreach (var i in arrayJoin)
            {
                Console.WriteLine($"{i.OwnerNAme} is owner of {i.AnimalName}");
            }


            // create a groupe inner join 
            // get all animals and put them in 
            // a newly created owner group if their ID match the owner ID

            var groupIoin =
                from owner in owners
                orderby owner.ID
                join animal in animals on owner.ID
                equals animal.ID into ownerGroup
                select new
                {
                    Owner = owner.Name,
                    Animals = from owner1 in ownerGroup
                              orderby owner1.Name
                              select owner1

                };
            Console.WriteLine("###################33");
            int numOfAnimals = 0;
            foreach (var i in groupIoin)
            {
                Console.WriteLine(i.Owner);
                foreach (var j in i.Animals)
                {
                    numOfAnimals++;
                    Console.WriteLine($"{j.Name}");
                }
            }

            // get only group with not empty list of animals

        }

        private static void generateArrayList()
        {
            ArrayList Animals = new ArrayList()
            {
                new Animal{Name = "cat",
                Length = .8,
                Width = 2 },
                new Animal{Name = "cat1",
                Length = .8,
                Width = 14 },
                new Animal{Name = "cat2",
                Length = .8,
                Width = 22 },
                new Animal{Name = "cat3",
                Length = .8,
                Width = 24 }

            };

            // to convert this arrayList into an IEnumerable
            var AnimalsEnumerable = Animals.OfType<Animal>();

            var animalsGT20 = from animal in AnimalsEnumerable
                              where animal.Width >= 20
                              orderby animal.Name
                              select animal;

            foreach (var i in animalsGT20)
            {
                Console.WriteLine(i);
            }

        }

        private static int[] generateIntegers()
        {
            int[] numbers = { 5, 6, 4, 3, 2, 15, 20, 25, 24, 26 };
            // get number gt 20 and sorted
            var numGT20 = (from n in numbers
                          where n > 20
                          orderby n
                          select n).ToList();

            foreach (var i in numGT20)
            {
                Console.WriteLine(i);
            }

            // check the 
            Console.WriteLine(numGT20.GetType());

            // convertion to Array
            //var ListGT20 = numGT20.ToList<int>();
            var arryGT20 = numGT20.ToArray();

            numbers[0] = 30;
            numbers[7] = 6;

            foreach (var i in numGT20)
            {
                Console.WriteLine(i);
            }


            return arryGT20;

        }

        private static void generateStrings()
        {
            string[] names = { "b baddi", " amine a", "a a",
            "y baddi", "aminea", "a a",
            "y baddi", " amine a", "aa"};

            // select from this list item match condition
            var nameWithoutSpace = from name in names
                                   where name.Contains(" ")
                                   orderby name descending
                                   select name; 
            
            foreach(var i in nameWithoutSpace)
            {
                Console.WriteLine(i);
            }

            
        }
    }
}
