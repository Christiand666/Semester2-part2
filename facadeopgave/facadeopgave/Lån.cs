using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facadeopgave
{
    class Lån
    {

        public person person { get; set; }

        public double skylder { get; set; }

        public List<Lån> GetAll()
        {
            var list = new List<Lån>();
            var l1 = new Lån { person = new person { Fornavn = "Christian", Efternavn = "Gerken", konto = new Konto { indestående = 50000 } } };
            var l2 = new Lån { person = new person { Fornavn = "Christian", Efternavn = "Gerken", konto = new Konto { indestående = 50000 } }, skylder = 5000 };
            list.Add(l1); list.Add(l2);
            return list;
        }
    }
}
