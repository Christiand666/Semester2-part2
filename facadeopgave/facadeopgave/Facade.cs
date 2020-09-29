using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facadeopgave
{
    class Facade
    {
        private Lån lån;

        private Konto konto { get => person.konto; }
        private Register register;
        private person person;


        public Facade(person person)
        {
            lån = new Lån();
            this.person = person;
            register = new Register();
        }


        public bool DårligLåner()
        {
            bool tjek = false;
            if (FindesIRegister())
                tjek = true;

            else if (HarDårligLån())
                tjek = true;

            else if (ManglerPenge())
                tjek = true;

            return tjek;
        }

        private bool ManglerPenge()
        {
            bool manglerpenge = false;
            if (konto.indestående < 50000)
                manglerpenge = true;
            return manglerpenge;
        }


        private bool HarDårligLån()
        {
            bool findes = false;
            var list = lån.GetAll();
            var p = list.Where(x => x.person.Fornavn == person.Fornavn).FirstOrDefault();
            if (p != null)
            {
                if (p.skylder > 50000)
                    findes = true;
            }
            return findes;
        }

        private bool FindesIRegister()
        {
            var findes = false;
            var list = register.GetAll();
            list.ForEach(x => { if (x.person.Fornavn == person.Fornavn) findes = true; });
            return findes;
        }
    }
}
