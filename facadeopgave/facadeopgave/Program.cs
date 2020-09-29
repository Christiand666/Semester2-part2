using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facadeopgave
{
    class program
    { 
        static void Main(string[] args)
        {
            var person = new person { Fornavn = "Christian", Efternavn = "Gerken", konto = new Konto { indestående = 500000 } };
            var facade = new Facade(person);

            Console.WriteLine($"er {person.Fornavn} dårlig låner?{facade.DårligLåner()}" );
        }
    }
}
