using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Day3.Example3
{
    interface Icommand
    {

        void Exec();
        void Undo();
    }
}
