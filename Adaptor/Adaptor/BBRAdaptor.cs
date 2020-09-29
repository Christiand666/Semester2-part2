using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaptor
{
    class BBRAdaptor : BBR
    {

        BBRSamletAreal bbr = new BBRSamletAreal(true, true);

        public BBRAdaptor(bool i, bool o)
        {
            bbr = new BBRSamletAreal(i, o);
        }
        public override double SamletAreal(double længde, double bredde)
        {
            return bbr.SamletAreal(længde, bredde);
        }
    }
}
