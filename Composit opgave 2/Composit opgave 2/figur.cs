using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composit_opgave_2
{
    class Figur : Component
    {
        List<Component> ComponentListe = new List<Component>();

        public Figur(string navn)
        {
            base.Navn = navn;

        }

        public override void add(Component c)
        {
            ComponentListe.Add(c);
        }

        public override void Remove(Component c)
        {
            ComponentListe.Remove(c);
        }

        public override void UdskrivAreal()
        {
            var samletAreal = 0.00;
            ComponentListe.ForEach(x => samletAreal += x.Areal);
            Console.WriteLine($"Arealet på {Navn} er {samletAreal} og indeholder disse komponenter");
            ComponentListe.ForEach(o => o.UdskrivAreal());
        }
    }
}
