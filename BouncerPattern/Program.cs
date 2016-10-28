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
        if (!(o is Point p)) throw new ArgumentException("Not a Point", nameof(p));

        // pattern expressions have a broader scope than normal
        // we can use p below!

        WriteLine($"Initial Coordinates: X {p.X}; Y: {p.Y}");
    }
}
