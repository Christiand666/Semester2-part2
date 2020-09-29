using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaptor
{
    class BBR
    {
        public virtual double SamletAreal(double længde, double bredde)
        {
            return længde * bredde;
        }

    }
}
