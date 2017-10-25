using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TussentijdseOefening
{
    class Boekenrek : IVoorwerpen, IAankoop
    {
        public Boekenrek(double hoogte,double breedte,decimal aankoopprijs)
        {
            this.Hoogte = hoogte;
            this.Breedte = breedte;
            this.aankoopPrijs = aankoopprijs;
        }
        private Double hoogteValue;

        public Double Hoogte
        {
            get
            {
                return hoogteValue;
            }
            set
            {
                if (value>0)
                    hoogteValue = value;
            }
        }
        private double breedteValue;
        public double Breedte
        {
            get
            {
                return breedteValue;
            }
            set
            {
                if (value > 0)
                    breedteValue = value;
            }
        }

        private decimal aankoopPrijsValue;
        public decimal aankoopPrijs
        {
            get
            {
                return aankoopPrijsValue;
            }

            set
            {
                if (value > 0)
                    aankoopPrijsValue = value;
            }
        }

        public decimal winst
        {
            get
            {
                return this.aankoopPrijs*2m;
            }
        }

        public void GegevensTonen()
        {
            Console.WriteLine("breedte : {0} mm",Breedte);
            Console.WriteLine("hoogte :{0} mm",Hoogte);
            Console.WriteLine("aankoopprijs :{0} euro",aankoopPrijs);
            Console.WriteLine();
        }
    }
}
