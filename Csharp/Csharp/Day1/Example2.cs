using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Globalization;

namespace Csharp.Day1
{
    class Example2
    {
        static void Main1(string[] args)
        {
            // StringBuilder
            StringBuilder sb = new StringBuilder("Random text Random text",18);

            StringBuilder sb2 = new StringBuilder("More String Buolder with very important information", 256);

            Console.WriteLine("Capacity of sb is {0}", sb.Capacity);
            Console.WriteLine("Capacity of sb is {0}", sb);
            Console.WriteLine("Capacity of sb2  is {0}", sb2.Capacity);

            Console.WriteLine("Lenght of sb is {0}", sb.Length);
            Console.WriteLine("Lenght of sb2  is {0}", sb2.Length);


            // add text to Stringbuilder
            sb.AppendLine("\n more text appended");
            Console.WriteLine("Capacity of sb is {0}", sb);

            // append a formate string
            double value = 12345.6789;
            CultureInfo enUS = CultureInfo.CreateSpecificCulture("en-US");

            Console.WriteLine(value.ToString("C3",
                enUS));
            sb2.AppendFormat(enUS, "best manager is : {0}", "baddi");
            Console.WriteLine(sb2.ToString());

            // to replace
            sb2.Replace("baddi","youssef");
            Console.WriteLine(sb2.ToString());

            //to clear 
            sb2.Clear();

            sb2.Append("baddi youssef");
            Console.WriteLine(sb2.ToString());

            // check if equals
            Console.WriteLine(sb2.Equals(sb));

            // 
            sb2.Insert(11, "hello");
            Console.WriteLine(sb2.ToString());

            sb2.Remove(11, 5);
            Console.WriteLine(sb2.ToString());

            long num = 1234;
            int num2 = (int)num;

            Console.WriteLine("orig: {0} ==> cast : {1}", num,num2);

            //
           int age = 16;
            if(age >= 16)
            {
                Console.WriteLine("true");   
            }
            else
            {
                Console.WriteLine("false");
            }
            
            bool bool1 = age >= 16 ? true : false;

            switch(age)
            {
                case 1:
                case 2:
                    Console.WriteLine("go to school");
                    break;
                default:
                    Console.WriteLine("go to work");
                    goto other;
            }
            other:
                Console.WriteLine("go to default");

            Console.ReadLine();
        }

    }
}
