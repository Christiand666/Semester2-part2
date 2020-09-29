using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class pArtikel : Component
    {
        public pArtikel(string navn, double pris)
        {
            base.Navn = navn;
            base.pris = pris;
        }


        public override void add(Component c)
        {
            throw new NotImplementedException();
        }



        public override void Getchild(int index)
        {
            throw new NotImplementedException();
        }

        public override void remove(Component c)
        {
            throw new NotImplementedException();
        }

        public override void UdskrivPris()
        {
            Console.WriteLine($"pris for {Navn} er {pris}");
        }
    }
}
