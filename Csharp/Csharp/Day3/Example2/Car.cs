
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Csharp.Day3.Example2
{
    class Car : Idrivable
    {

        public string Marque { get; set; }

        public int Wheels {
            get; set ; 
        }
        public double Speed {
            get ;
            set ;
        }

        // Constructor
        public Car(string marque="No Marque",
           int wheels = 0,
           double speed = 0)
        {
            Marque = marque;
            Wheels = wheels;
            Speed = speed;
        }

        public void Move()
        {
            Console.WriteLine($"the {Marque} car Moves forward at {Speed} Km/h");
        }

        public void Stop()
        {
            Console.WriteLine($"the {Marque} car stops");
            Speed = 0;
        }
    }
}