using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Materiaal
{
    public delegate void Onderhoudsbeurt(Fotokopiemachine machine);
    public class Fotokopiemachine:Ikost
    {
        public event Onderhoudsbeurt OnderhoudNodig;
        private const int AantalBlzTussen20OnderhoudsBeurten = 10;
        private string serieNrValue;
        public string SerieNr
        {
            get
            {
                return serieNrValue;
            }
            set
            {
                serieNrValue = value;
            }
        }
        private int aantalGekopieerdeBlzValue;
        public int AantalGekopieeerdeBlz
        {
            get
            {
                return aantalGekopieerdeBlzValue;
            }
            set
            {
                if (value > 0)
                    aantalGekopieerdeBlzValue = value;
            }
        }
        private decimal kostPerPaginaValue;
        public decimal KostPerPagina
        {
            get
            {
                return kostPerPaginaValue;
            }
            set
            {
                if (value > 0)
                    kostPerPaginaValue = value;
            }
        }

        public decimal Bedrag
        {
            get
            {
                return AantalGekopieeerdeBlz * KostPerPagina;
            }
        }

        public bool Menselijk
        {
            get
            {
                return false;
            }
        }

        public Fotokopiemachine(string serienummer, int aantalGekopieerdeBlz, decimal kostPerPagina)
        {
            this.SerieNr = serienummer;
            this.AantalGekopieeerdeBlz = aantalGekopieerdeBlz;
            this.KostPerPagina = kostPerPagina;
        }
        public void fotokopieer(int aantalBlz)
        {
            for (int blz = 1; blz <= aantalBlz; blz++)
            {
                Console.WriteLine($"fotokopieMachine {SerieNr} kopieert {blz} van {aantalBlz}.");
                if (++AantalGekopieeerdeBlz % AantalBlzTussen20OnderhoudsBeurten == 0)
                    if (OnderhoudNodig != null)
                        OnderhoudNodig(this);
            }
        }
        
    }
}
