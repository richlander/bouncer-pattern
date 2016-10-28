using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

class BouncerPattern
{
    static void Method(object o)
    {
        if (o is null) throw new ArgumentException(nameof(o));
        if (o is Point p)
        {
            // implement method here
        }
        else throw new ArgumentException("Not a Point", nameof(p));
    }
}
