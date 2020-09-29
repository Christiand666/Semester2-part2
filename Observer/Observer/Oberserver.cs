using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    interface Oberserver
    {
        void Update(subject subject);
    }


    class skakmedlem : Oberserver
    {
        string name;

        public skakmedlem(string name)
        {
            this.name = name;
        }


        public void Update(subject subject)
        {
            Console.WriteLine("Til {0}\nInvitation til turnering : {1}\n\n", name, subject.GetState());
        }
    }

    class privatMedlem : Oberserver
    {
        string name;
        public privatMedlem(string name)
        {
            this.name = name;
        }

        public void Update(subject subject)
        {
            Console.WriteLine("Til {0}\nInvitation til turnering : {1}\n\n", name, subject.GetState());
        }
    }
}
