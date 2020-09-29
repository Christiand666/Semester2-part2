using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composit_opgave_2
{
    public abstract class Component
    {
        public string Navn { get; set; }

        public double Areal { get; set; }

        public abstract void UdskrivAreal();

        public abstract void add(Component c);

        public abstract void Remove(Component c);
    }
}
