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

        // A related feature is called "out vars"
        // no longer need to declare out variables before the method
        // the scope is broad, too, so you can use them below
        p.GetCoordinates(out var x, out var y);

        WriteLine($"Initial Coordinates: X {p.X}; Y: {p.Y}");
    }
}
