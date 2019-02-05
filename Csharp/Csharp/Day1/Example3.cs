using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Day1
{
    class Example3
    {
        static void Main1(string[] args)
        {
            double x = 4;
            double y = 5;

            Console.WriteLine("5 + 4 = {0}",
                GetFirstSum(x, y));

            Console.WriteLine("x is  => {0}",
                x);

            // OUT PARAM
            int solution;
            DoubleIt(15, out solution);
            Console.WriteLine("solution is  => {0}",
                solution);

            // REf param
            int num1 = 10;
            int num3 = 20;
            Console.WriteLine("num1 is {0} and num3  is {1}",
                num1,num3);
            swap(ref num1, ref num3);
            Console.WriteLine("num1 is {0} and num3  is {1}",
                num1, num3);

            // 
            Console.WriteLine("{0}",GetMoreSum(1, 2, 3));
            Console.WriteLine("{0}", GetMoreSum(1, 2));
            Console.WriteLine("{0}", GetMoreSum(1, 2 ,4 ,5));

            Console.WriteLine("{0}", GetMoreSum(1, 2, 4, 5, 6));

            // Named Param
            PrintInfo("ahmed", age: 18);

            //
            double sum = GetSum("1", "2");
            double sum3 = GetSum();
            double sum2 = GetSum(4, 5);
            Console.WriteLine("{0}", sum);
            Console.WriteLine("{0}", sum2);
            Console.WriteLine("{0}", sum3);

            // ENUM

            Color c = Color.Yellow;
            PrintColor(c);


            //
            double num4 = 5;
            double num5 = 0;

            try
            {
                Console.WriteLine("5 / 0 = {0}", 
                DoDivision(num4, num5));
            }catch(DivideByZeroException ex)
            {
                Console.WriteLine("you are trying to divid by zero");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
            



            Console.ReadLine();
        }

        private static double DoDivision(double num4, double num5)
        {
            if(num5 == 0)
            {
                throw new System.DivideByZeroException();
            }
            return num4 / num5;
        }

        private static double GetSum(string v1 = "1", string v2="2")
        {
            double v1db = Convert.ToDouble(v1);
            double v2db = Convert.ToDouble(v2);
            return v1db + v2db;
        }

        private static double GetSum(double v1, double v2)
        {
            return v1 + v2;
        }

        private static void PrintInfo(string name, int age)
        {
            Console.WriteLine("name is {0} and age is {1}", 
                name, age);
        }

        private static double GetMoreSum(params double[] numbers)
        {
            double sum = 0;
            foreach (int i in numbers)
            {
                sum += i;
            }
            return sum;
        }

        private static void swap(ref int num1, ref int num3)
        {
            int temp = num1;
            num1 = num3;
            num3 = temp;
        }

        private static void DoubleIt(int v, out int solution)
        {
            solution = v * 2;
        }

        private static double GetFirstSum(double x, double y)
        {
            double temp = x;
            x = y;
            y = temp;
            return x + y;

        }

        enum Color : byte
        {
            Orange = 2,
            Blue = 1,
            Green,
            Red,
            Yellow
        }

        static void PrintColor(Color c)
        {
            Console.WriteLine("the color is {0} with the code {1}",
                c, (int)c);
        }
    }
}
