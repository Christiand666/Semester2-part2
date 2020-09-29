using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composit_opgave_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var figur = new Figur("Figur1");
            var c = new cirkel(50);
            var f = new Firkant(100);
            var t = new Trekant(200);

            figur.add(c);
            figur.add(f);
            figur.add(t);
            figur.UdskrivAreal();
        }
    }
}
