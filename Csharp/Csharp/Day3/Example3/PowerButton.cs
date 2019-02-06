using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Day3.Example3
{
    class PowerButton : Icommand
    {
        IElectrinicDevice device;

        public PowerButton(IElectrinicDevice device)
        {
            this.device = device;
        }

        public void Exec()
        {
            device.On();
        }

        public void Undo()
        {
            device.Off();
        }
    }
}
