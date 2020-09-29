using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facadeopgave
{
    class Register
    {
        public person person { get; set; }


        public List<Register> GetAll()
        {
            var list = new List<Register>();
            var p1 = new person { Fornavn = "Christian", Efternavn = "Gerken", konto = new Konto { indestående = 50000 } };
            list.Add(new Register { person = p1 });
            for (int i = 0; i < 100; i++)
            {
                list.Add(new Register { person = new person() });
            }
            return list;
        }
    }
}
