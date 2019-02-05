using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Csharp.Day2.example6
{


    //NAme
    // virtual GetInfo
    // methode abstract so the class must be also abstract
    abstract class Shape
    {

        public abstract double area();
    }
}