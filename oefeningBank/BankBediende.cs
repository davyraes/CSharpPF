using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefeningBank
{
    class BankBediende
    {
        public BankBediende(string voornaam, string naam)
        {
            this.Voornaam = voornaam;
            this.Naam = naam;
        }
        private string voornaamValue;
        public string Voornaam
        {
            get
            {
                return voornaamValue;
            }
            set
            {
                if (value != null)
                    voornaamValue = value;
            }
        }
        private string naamValue;
        public string Naam
        {
            get
            {
                return naamValue;
            }
            set
            {
                if (value != null)
                    naamValue = value;
            }
        }
        public void rekeningUittreksel(Rekening rekening)
        {
            rekening.Afbeelden();
            Console.WriteLine("vorig saldo : {0}",rekening.VorigSaldo);
            Console.WriteLine("bedrag van de storting/afhaling : {0}", Math.Abs(rekening.Saldo - rekening.VorigSaldo));
            Console.WriteLine("nieuwe saldo : {0}", rekening.Saldo);
            Console.WriteLine();
        }
        public void SaldoInHetRood(Rekening rekening)
        {
            Console.WriteLine("saldo ontoereikend");
            Console.WriteLine("max af te halen bedrag : {0}",rekening.Saldo);
            Console.WriteLine();
        }
    }
}
