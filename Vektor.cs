using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poligon_39
{
    internal class Vektor
    {
        Tacka Pocetak, Kraj;
        public Vektor(Tacka a, Tacka b)
        {
            Pocetak = a;
            Kraj = b;
        }
        public Tacka Centriraj()
        {
            Tacka Nova = new Tacka(Kraj.x - Pocetak.x, Kraj.y - Pocetak.y);
            return Nova;
        }
    }
}
