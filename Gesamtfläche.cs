using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flaechen;
public class Gesamtfläche
{
    List<Fläche> _flächen = new();

    public void Add(Fläche fläche)
    {
        _flächen.Add(fläche);
    }
    public double GetFläche()
    {
        double sum = 0.0;

        for (int i = 0; i < _flächen.Count; i++)
        {
            sum = sum + _flächen[i].GetFläche();
        }

        return 0;
    }
}