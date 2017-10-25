using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Personeel
{
    public sealed class manager:bediende
    {
        public manager(string naam , DateTime indienst , geslacht geslacht , decimal wedde, decimal bonus):base(naam,indienst,geslacht,wedde)
        {
            Bonus = bonus;
        }

        private decimal bonusValue;
        public decimal Bonus
        {
            get
            {
                return bonusValue;
            }
            set
            {
                if (value > 0)
                    bonusValue = value;
            }
        }
        public override void afbeelden()
        {
            base.afbeelden();
            Console.WriteLine("bonus: {0}", Bonus);
        }
        public override string ToString()
        {
            return base.ToString()+ ", bonus :" + Bonus;
        }
        public override decimal premie
        {
            get
            {
                return this.Bonus * 3m;
            }
        }
        public override decimal Bedrag
        {
            get
            {
                return base.Bedrag + Bonus;
            }
        }
        public  void OnderhoudNoteren(Firma.Materiaal.Fotokopiemachine machine)
        {
            Console.WriteLine($"{Naam} registreert het onderhoud van machine {machine.SerieNr} in het logboek.");
        }
    }
}
