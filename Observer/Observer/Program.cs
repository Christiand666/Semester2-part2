using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            SkakUnion indland = new SkakUnion();
            SkakUnion udland = new SkakUnion();

            skakmedlem medlem1 = new skakmedlem("martin");
            skakmedlem medlem2 = new skakmedlem("Christian");
            skakmedlem medlem3 = new skakmedlem("gerken");
            skakmedlem medlem4 = new skakmedlem("karl");

            privatMedlem medlem5 = new privatMedlem("karl2");
            privatMedlem medlem6 = new privatMedlem("mette");


            indland.Attach(medlem1);
            indland.Attach(medlem2);
            indland.Attach(medlem3);
            indland.Attach(medlem4);
            indland.Attach(medlem5);

            udland.Attach(medlem1);
            udland.Attach(medlem2);
            udland.Attach(medlem3);


            udland.State = "verdensmesterskabet";
            indland.State = "Danmarksturnening";

            Console.ReadKey();
        }
    }
}
