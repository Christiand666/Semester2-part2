using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_omskrivning
{
    class Program
    {
        static void Main(string[] args)
        {
            singleton t = singleton.getinstance();
            t.navn = "Gerken";
            Console.WriteLine(t.navn);
            Console.ReadLine();
        }


    }

    class singleton
    {
        private static singleton instance; //= new sinlgeton(); (eager)

        private singleton() { }

        public string navn { get; set; }

        public static singleton getinstance()
        {
            if(instance == null)
            {
                instance = new singleton(); //lazy
            };
            return instance;
        }
    }
}
