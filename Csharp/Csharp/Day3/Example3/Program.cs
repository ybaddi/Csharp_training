using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Day3.Example3
{
    class Program
    {

        static void Main1(string[] args)
        {
        // Example 2

        IElectrinicDevice IPTV = DeviceCreator.GetDevice();

        PowerButton pB = new PowerButton(IPTV);
        pB.Exec();
        pB.Undo();


        Console.ReadLine();
        }
       
    }
}
