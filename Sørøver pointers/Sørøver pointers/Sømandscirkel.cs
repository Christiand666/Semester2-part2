using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sørøverkani
{
    class Sømand
    {

        int tæller = 0;
        public Sømand Next;
        public Sømand Prev;
        //øge tæller
        public void overlevede()
        {
            this.tæller++;
            //increment en tæller
        }

        //afleverer tæller
        public int GetGangeOverlevet()
        {
            return tæller;

        }

    }
}
