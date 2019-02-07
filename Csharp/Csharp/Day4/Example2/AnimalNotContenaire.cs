using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Day4.Example2
{
    class AnimalNotContenaire
    {

        public double Length { get; set; }
        public double Width { get; set; }
        public double Poind { get; set; }

        public AnimalNotContenaire()
            : this(1, 1, 1) { }

        public AnimalNotContenaire(int length, int width, int poind)
        {
            Length = length;
            Width = width;
            Poind = poind;
        }

        // overload + operator 
        public static AnimalNotContenaire operator +(AnimalNotContenaire y, AnimalNotContenaire x)
        {
            AnimalNotContenaire newOne = new AnimalNotContenaire()
            {
                Length = y.Length + x.Length,
                Width = y.Width + x.Width,
                Poind = y.Poind + x.Poind
            };
            return newOne;
        }

        public static AnimalNotContenaire operator -(AnimalNotContenaire y, AnimalNotContenaire x)
        {
            AnimalNotContenaire newOne = new AnimalNotContenaire()
            {
                Length = y.Length - x.Length,
                Width = y.Width - x.Width,
                Poind = y.Poind - x.Poind
            };
            return newOne;
        }

        public static bool operator ==(AnimalNotContenaire y, AnimalNotContenaire x)
        {
            AnimalNotContenaire newOne = new AnimalNotContenaire()
            {
                Length = y.Length - x.Length,
                Width = y.Width - x.Width,
                Poind = y.Poind - x.Poind
            };
            return false;
        }

        public static bool operator !=(AnimalNotContenaire y, AnimalNotContenaire x)
        {
            AnimalNotContenaire newOne = new AnimalNotContenaire()
            {
                Length = y.Length - x.Length,
                Width = y.Width - x.Width,
                Poind = y.Poind - x.Poind
            };
            return false;
        }

        public override string ToString()
        {
            return String.Format("AnimalNotContenaire with Lenght: {0} \n Width : {1} | and Poid {2}",
                Length, Width, Poind);

        }

        // convert from this object an 
        // int like 
        public static explicit operator int(AnimalNotContenaire a)
        {
            return (int)(a.Length + a.Width + a.Poind);

        }


        public static implicit operator AnimalNotContenaire( int a)
        {
            return new AnimalNotContenaire(a, a+1, a+2);

        }



    }
}
