using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flaechen;

public class Dreieck : Fläche
{
    double _g;
    double _h;
    public Dreieck(double g, double h)
    {
        this._g = g;
        this._h = h;
    }
    public override double GetFläche()
    {
        return _g * _h / 2;
    }
}