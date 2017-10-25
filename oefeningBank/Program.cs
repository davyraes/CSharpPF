using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefeningBank
{
    class Program
    {
        static void Main(string[] args)
        {try
            {
                Klant klant1 = new Klant("Davy", "Raes");
                Zichtrekening zichtrekening = new Zichtrekening("BE82860110336468", klant1,-2500);
                SpaarRekening spaarrekening = new SpaarRekening("BE82860110336468", klant1);
                Kasbon kasbon = new Kasbon(new DateTime(1990, 1, 1), 2500, 15, klant1);
                BankBediende bankBediende = new BankBediende("bank", "bediende");
                zichtrekening.RekeningUittreksel += bankBediende.rekeningUittreksel;
                zichtrekening.SaldoInHetRood += bankBediende.SaldoInHetRood;
                spaarrekening.RekeningUittreksel += bankBediende.rekeningUittreksel;
                spaarrekening.SaldoInHetRood += bankBediende.SaldoInHetRood;
                zichtrekening.Storten(500);
                spaarrekening.Storten(2300);
                zichtrekening.Afhalen(1000);
                spaarrekening.Afhalen(1000);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
    }
}
