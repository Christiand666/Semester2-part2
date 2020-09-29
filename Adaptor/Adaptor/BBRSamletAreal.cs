using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaptor
{
    class BBRSamletAreal
    {
        bool harBeboeligKælder;
        bool harTagetage;

        public BBRSamletAreal(bool beboeligkælder, bool tagetage)
        {
            harBeboeligKælder = beboeligkælder;
            harTagetage = tagetage;
        }

        public double SamletAreal(double længde, double bredde)
        {
            double areal = længde * bredde;
            if (harBeboeligKælder)
            {
                areal += længde * bredde;
            }

            if (harTagetage)
            {
                areal += (længde * bredde) * 0.75;
            }
            return areal;
        }
    }
}
