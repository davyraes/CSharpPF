using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefeningBank
{
    public delegate void transactie(Rekening rekening);
    public abstract class Rekening:ISpaarmiddel
    {
        private string rekeningnummerValue;
        private decimal saldoValue;
        private DateTime creatiedatumValue;
        private Klant eigenaarValue;
        private decimal vorigSaldoValue;
        public event transactie RekeningUittreksel;
        public event transactie SaldoInHetRood;
        public Rekening(string rekeningnummer,Klant eigenaar)
        {
            this.Rekeningnummer = rekeningnummer;
            saldoValue = 0;
            this.Creatiedatum = DateTime.Now;
            this.Eigenaar = eigenaar;
        }
        
        public string Rekeningnummer
        {
            get
            {
                return rekeningnummerValue;
            }
            set
            {
                ulong temp = 0;
                if (value.Length == 16 && value.Substring(0, 2) == "BE" && ulong.TryParse(value.Substring(2), out temp))
                {
                    temp = ulong.Parse(value.Substring(4, 10));
                    if (temp % 97 == ulong.Parse(value.Substring(14)))
                        rekeningnummerValue = value;
                    else
                        throw new Exception("ongeldig rekeningnummer");
                }
                else
                    throw new Exception("ongeldig rekeningnummer");

            }
        }
        public decimal Saldo
        {
            get
            {
                return saldoValue;
            }
            
        }
        public DateTime Creatiedatum
        {
            get
            {
                return creatiedatumValue;
            }
            set
            {
                if (value < new DateTime(1990, 1, 1))
                    throw new Exception("ongeldige creatiedatum");
                creatiedatumValue = value;
            }
        }
        public Klant Eigenaar
        {
            get
            {
                return eigenaarValue;
            }
            set
            {
                eigenaarValue = value;
            }
        }
        public decimal VorigSaldo
        {
            get
            {
                return vorigSaldoValue;
            }
        }
        
        public  virtual void Afbeelden()
        {
            this.Eigenaar.afbeelden();
            Console.WriteLine("rekeningnummer : {0}",this.Rekeningnummer);
            Console.WriteLine("saldo : {0}",this.Saldo);
            Console.WriteLine("creatiedatum : {0}",this.Creatiedatum);
            
        }
        public void Storten(decimal bedrag)
        {
            if (bedrag > 0)
            {
                vorigSaldoValue = this.saldoValue;
                this.saldoValue += bedrag;
                if (RekeningUittreksel!=null)
                    RekeningUittreksel(this);
            }
        }
        public void Afhalen(decimal bedrag)
        {
            
            if (bedrag > 0)
            {
                vorigSaldoValue = this.saldoValue;
                if (bedrag > this.Saldo)
                {
                    if (SaldoInHetRood != null)
                        SaldoInHetRood(this);
                }
                else
                {
                    this.saldoValue -= bedrag;
                    if (RekeningUittreksel != null)
                        RekeningUittreksel(this);
                }
            }
                
        }
       
    }
}
