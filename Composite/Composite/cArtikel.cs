using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class cArtikel : Component
    {

        List<Component> Components = new List<Component>();

        public cArtikel(string navn)
        {
            base.Navn = navn;
        }

        public override void UdskrivPris()
        {
            var samletPris = 0.00;
            Components.ForEach(o => samletPris += o.pris);
            Console.WriteLine($"samlet pris for:  { base.Navn} er {samletPris}");
            Components.ForEach(o => o.UdskrivPris());
        }

        public override void add(Component c)
        {
            Components.Add(c);
        }

        public override void remove(Component c)
        {
            Components.Remove(c);
        }

        public override void Getchild(int index)
        {
            throw new NotImplementedException();
        }
    }
}
