using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Day4.Example2
{
    class AnimalContenair : IEnumerable
    {
        private List<Animal> animalList = new List<Animal>();

        public Animal this[int index]
        {
            get { return (Animal)animalList[index]; }
            set { animalList.Insert(index, value); }
        }


        public IEnumerator GetEnumerator()
        {
            return animalList.GetEnumerator();
        }
    }
}
