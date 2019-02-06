using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Day3.Example3
{
    class IPTV : IElectrinicDevice
    {
        public int Volume { get; set; }

        public void Off()
        {
            Console.WriteLine("The device is Off");
        }

        public void On()
        {
            Console.WriteLine("The device is On");
        }

        public void VolumeDown()
        {
            if (Volume != 0) Volume--;
            string res = $"The device volume is {Volume}";
            Console.WriteLine(res);

        }

        public void VolumeUp()
        {
            if (Volume != 110) Volume--;
            string res = $"The device volume is {Volume}";
            Console.WriteLine(res);
        }
    }
}
