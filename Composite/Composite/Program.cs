using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new cArtikel("cykel");
            var p1 = new pArtikel("lygte", 100);
            var p2 = new pArtikel("lygte", 100);
            var p3 = new pArtikel("lygte", 100);
            var p4 = new pArtikel("lygte", 100);
            var p5 = new pArtikel("lygte", 100);
            var p6 = new pArtikel("lygte", 100);
            var p7 = new pArtikel("lygte", 100);

            var c2 = new cArtikel("computer");
            var p8 = new pArtikel("lygte", 100);
            var p9 = new pArtikel("lygte", 100);
            var p10 = new pArtikel("lygte", 100);
            var p11 = new pArtikel("lygte", 100);



            c1.add(p1);
            c1.add(p2);
            c1.add(p3);
            c1.add(p4);
            c1.add(p5);
            c1.add(p6);
            c1.add(p7);

            c2.add(p8);
            c2.add(p9);
            c2.add(p10);
            c2.add(p11);

            c1.UdskrivPris();
        }
    }
}
