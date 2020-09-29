using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaptor
{
    class Program
    {
        static void Main(string[] args)
        {

            BBR myBBr = new BBR();


            Console.WriteLine(myBBr.SamletAreal(20, 40));

            BBR samletBoligAreal = new BBRAdaptor(true, true);
            Console.WriteLine(samletBoligAreal.SamletAreal(20, 40));
            Console.ReadKey();
        }
    }
}
