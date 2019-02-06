using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Day3.Example3
{
    class DeviceCreator
    {
        internal static IElectrinicDevice GetDevice()
        {
            return new IPTV();
        }
    }
}
