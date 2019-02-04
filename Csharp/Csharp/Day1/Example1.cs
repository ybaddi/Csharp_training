using System;
using System.Globalization;
namespace Csharp.Day1
{
    public class Example1
    {
        static void Main1(string[] args)
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
            Console.WriteLine(value3.ToString("X8"));

            int value4 = 123456789;
            Console.WriteLine(value4.ToString("X"));
            Console.WriteLine(value4.ToString("X2"));

            // String
            string valueString = "this is a string";
            Console.WriteLine("String lenght is {0}",valueString.Length);

            // test if this string contains other string 
            

            Console.WriteLine(valueString.IndexOf("is "));
            String substring1 = valueString.Remove(10, 6);
            Console.WriteLine(substring1);
            String substring2 = valueString.Substring(10);
            Console.WriteLine(substring2);

            Console.WriteLine(valueString.Insert(11 , " added "));


            Console.WriteLine(valueString.Replace("string", "Replaced"));

            Console.WriteLine(String.Compare("A","B",StringComparison.OrdinalIgnoreCase));


            Console.WriteLine(String.Equals("A", "a", StringComparison.OrdinalIgnoreCase));


            String valueString2 = "hello WOrld";
            Console.WriteLine(valueString2.PadRight(8, '.'));

            Console.WriteLine(valueString2.Trim());

            Console.WriteLine(valueString2.ToUpper());
            Console.WriteLine(valueString2.ToLower());

            String valueString3 = string.Format("{0} , \n {1}, {2}, {3}",
                "baddi", "youssef", "adil", "aymen");
            Console.WriteLine(valueString3);

            Console.Write("Exactly what I Typed");
            Console.Write("\n");
            Console.Write(@"\n Exactly what I Typed");


            // functions

            SayHello();

            // Arrays
            int[] arrayofInt = new int[3];

            arrayofInt[0] = 23;
            arrayofInt[1] = 20;
            arrayofInt[2] = 25;

            Console.WriteLine("faluer of 0 is : {0}", arrayofInt[0]);

            string[] arrayOfString = {"baddi", "youssef", "adil", "aymen"};

            var arrayOfVar = new[] { "baddi", "youssef", "adil", "aymen" };

            object[] arrayOfObect = { "baddi", 1, "adil", 2 };

            Console.WriteLine("type of elemey in index 0 is : {0}",
                arrayOfObect[1].GetType());

            for(int j=0; j< arrayOfString.Length;j++)
            {
                Console.WriteLine("Array {0}: vaalue : {1}",
                    j, arrayOfString[j]);

            }

            string[,] Array2DofNAmes = new string[2, 2]
            {{"baddi", "youssef" },{"adil", "aymen"} };
            Console.WriteLine("value of table 1 index 1 {0}",
                    Array2DofNAmes.GetValue(1,1));

            for (int j = 0; j < Array2DofNAmes.GetLength(0); j++)
            {
                for (int i1 = 0; i1 < Array2DofNAmes.GetLength(1); i1++)
                {
                    Console.WriteLine("Array {0}",
                       Array2DofNAmes[j,i1]);

                }

            }

            PrintStringArray(arrayOfString, "ForEach");
            PrintIntArray(arrayofInt, "ForEach");


            // sort array
            Array.Sort(arrayofInt);
            PrintIntArray(arrayofInt, "ForEach");

            //reverse array
            Array.Reverse(arrayofInt);
            PrintIntArray(arrayofInt, "ForEach");

            //get index of element 
            Console.WriteLine("20 at index {0}",
                       Array.IndexOf(arrayofInt,20));
            Console.WriteLine("1 at index {0}",
                       Array.IndexOf(arrayofInt, 1));
            PrintIntArray(arrayofInt, "ForEach");

            // to set value of array 
            arrayofInt.SetValue(33, 1);

            // example de copy of tables
            int[] scrArray = { 1, 2, 3 };
            int[] dstArray = new int[2];
            int startIn = 0;
            int lenght = 2;

            Array.Copy(scrArray, startIn, dstArray, startIn, lenght);
            PrintIntArray(dstArray, "Copy");


            Array anotherArray =  Array.CreateInstance(typeof(string), 2);
            Array anotherIntArray = Array.CreateInstance(typeof(int), 10);

            //copy values in scrArray to anotherIntArray 
            // startin at index 5
            scrArray.CopyTo(anotherIntArray,5);

            foreach (int var in anotherIntArray)
            {
                Console.WriteLine("anotherIntArray : {0}", var);
            }

            //PrintStringArray(anotherArray, "ForEach");

            // search for element that match the condition
            // difined by the specified predicate
            int[] arrayOfnumber = { 1, 12, 15 };
            Console.WriteLine("> 10 : {0}", Array.Find(arrayOfnumber, GT10));

            Console.ReadLine();

        }

        private static bool GT10(int value)
        {
            return value > 10;
        }

        private static void PrintStringArray(string[] array2DofNAmes, string v)
        {
            foreach(string var in array2DofNAmes)
            {
                Console.WriteLine("{0} : {1}", v, var);
            }
        }

        private static void PrintIntArray(int[] array2DofNAmes, string v)
        {
            foreach (int var in array2DofNAmes)
            {
                Console.WriteLine("{0} : {1}", v, var);
            }
        }

        private static void SayHello()
        {
            String name = "";
            Console.WriteLine("give me your name pls ");
            name =   Console.ReadLine();
            Console.WriteLine("Say hello {0} " , name);
        }
    }
}
