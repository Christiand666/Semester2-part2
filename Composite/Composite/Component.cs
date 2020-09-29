using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public abstract class Component
    {
        public string Navn { get; set; }

        public double pris { get; set; }

        public abstract void UdskrivPris();

        public abstract void add(Component c);

        public abstract void remove(Component c);

        public abstract void Getchild(int index);
    }
}
