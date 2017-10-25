using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefenmap
{
    class verwisselaar
    {
        public void Verwissel(ref int getal1,ref int getal2)
        {
            int temp = getal1;
            getal1 = getal2;
            getal2 = temp;

        }
        public  void VerwisselNaarAndereVariabelen(int getal1,int getal2,out int verwisseld1 , out int verwisseld2)
        {
            verwisseld1 = getal2;
            verwisseld2 = getal1;
        }
    }
}
