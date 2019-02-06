using System;
namespace Csharp.Day3
{
    internal class Circle : Shape
    {
        private int Rayon { get; set; }

        public Circle(int r)
        {
            Name = "Circle";
            this.Rayon = r;
        }

        public override double Area()
        {
            return Math.PI * (Math.Pow(Rayon, 2));
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"this circle has a Rayon of {Rayon}");
        }
    }
}