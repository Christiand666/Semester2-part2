using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composit_opgave_2
{
    class Firkant : Component
    {
        public Firkant(double areal)
        {
            base.Areal = areal;
            base.Navn = "Firkant";

        }
        public override void add(Component c)
        {
            throw new NotImplementedException();
        }

        public override void Remove(Component c)
        {
            throw new NotImplementedException();
        }

        public override void UdskrivAreal()
        {
            Console.WriteLine($"Arealet på {Navn} er {Areal}");
        }
    }
}
