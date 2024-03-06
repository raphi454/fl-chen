using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flaechen;

public class Rechteck : Fläche
{
    double _l;
    double _b;

    public Rechteck(double l, double b)
    {
        _l = l;
        _b = b;
    }

    public override double GetFläche()
    {
        return _l * _b;
    }
}