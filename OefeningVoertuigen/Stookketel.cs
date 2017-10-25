using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningVoertuigen
{
    class Stookketel:IVervuiler
    {
        public Stookketel(Single coNorm)
        {
            this.CoNorm = coNorm;
        }
        private Single coNormValue;
        public Single CoNorm
        {
            get
            {
                return coNormValue;
            }
            set
            {
                if (value > 0)
                    coNormValue = value;
            }
        }

        public double GeefVervuiling()
        {
            return CoNorm * 100;
        }
    }
}
