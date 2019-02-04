using System;
using System.Globalization;
namespace Csharp.Day1
{
    public class Example1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            // ./csahrp#./csharp.exe 1 2 3 hello world
            int i = 0;
            for(i=0;i<args.Length;i++)
            {
                Console.WriteLine(args[i]);
            }

            string argsJoined = string.Join(",", args);
            Console.WriteLine(argsJoined);


            string[] myArgs = Environment.GetCommandLineArgs();

            for (i = 0; i < myArgs.Length; i++)
            {
                Console.WriteLine("myArges {0}", myArgs[i]);
            }

            

            // Data Type
            // Boolean
            bool isTrue = true; // False
            Console.WriteLine(isTrue);

            // Integer   32bit

            int x = 23;
            Console.WriteLine(x);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            Console.WriteLine("#############################");

            // long 64 bit
            //long k;
            Console.WriteLine(long.MaxValue);

            // Decimal 128 bit
            // with 28 gigit
            decimal z= 3.1452638364846487M;
            Console.WriteLine(z);

            Console.WriteLine(long.MinValue);

            //byte 8-bit
            // char
            // sbyte  16bit
            // short 8bit
            // ulong 64bit
            // ushort 16bit

            // conversion
            bool bool1 = bool.Parse("true");
            Console.WriteLine(bool1);

            int int1 = int.Parse("100");
            Console.WriteLine(int1);

            double double1 = double.Parse("100,000");
            Console.WriteLine(double1);

            // Date et Datetime
            DateTime datetime1 = new DateTime(1986, 12, 21);
            Console.WriteLine("la date est : {0}",datetime1);
            Console.WriteLine("le jour de la date est : {0}", datetime1.DayOfWeek);

            datetime1 = datetime1.AddDays(4);
            datetime1 = datetime1.AddMonths(4);
            datetime1 = datetime1.AddYears(4);
            Console.WriteLine("la date est : {0}", datetime1.Date);

            // time
            TimeSpan timeSpan = new TimeSpan(10, 28, 50);
            Console.WriteLine("le time est : {0}", timeSpan.ToString());
            timeSpan = timeSpan.Subtract(new TimeSpan(0, 5, 0));
            Console.WriteLine("le time est : {0}", timeSpan.ToString());
            timeSpan = timeSpan.Add(new TimeSpan(1, 0, 0));
            Console.WriteLine("le time est : {0}", timeSpan.ToString());


            Console.WriteLine("#############################");
            // Data type Formatting
            // C to add currency
            var var1 = 10;
            Console.WriteLine("{0}", var1.GetType());
            Console.WriteLine("{0:C3}", x);

            double value = 12345.6789;
            Console.WriteLine(value.ToString("C3",
                CultureInfo.CreateSpecificCulture("fr-FR")));

            // Pad with zero
            Console.WriteLine("Pad with 0 : {0:d6}", x);

            Console.WriteLine(x.ToString("D8"));

            int value1 = -12345;
            Console.WriteLine(value1.ToString("D8"));
            // float
            float v = 4.534455F;
            // difine decimal
            decimal value2 = 23.555578M;
            Console.WriteLine("3 decimal : {0:f3}", 23.45678);
            Console.WriteLine(value2.ToString("F3"));


            // Pad with zero
            Console.WriteLine("with Percentage with 0 : {0:R3}", value);

            // with R
            //Console.WriteLine("with Percentage with 0 : {0:R3}", x);


            // display with hex x
            int value3 = 0x2054e;
            Console.WriteLine(value3.ToString("x"));


            Console.ReadLine();

        }
    }
}
