using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefenmap
{
    class lijnenTrekker
    {
        public void TrekLijn(Int32 lengte, char teken='-')
        {
            for (int i = 0; i < lengte; i++)
                Console.Write(teken);
            Console.WriteLine();
        }
        
        public void TrekLijn()
        {
            TrekLijn(79);
        }

    }
}
