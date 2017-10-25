using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningVoertuigen
{
    class Program
    {
        static void Main(string[] args)
        {
            IVervuiler[] vervuiler = new IVervuiler[3];
            vervuiler[0] = new Vrachtwagen("davy", 35000, 250, 25.3f, "pzm747");
            vervuiler[1] = new Personenwagen("vero", 30000, 125, 4.5f, "aze123");
            vervuiler[2] = new Stookketel(15);
            foreach (IVervuiler vervuil in vervuiler)
                Console.WriteLine(vervuil.GeefVervuiling());
            IPrivaat[] privaten = new IPrivaat[4];
            privaten[0] = new Vrachtwagen("davy", 68000, 450, 25.3f, "PZM747");
            privaten[1] = new Vrachtwagen();
            privaten[2] = new Personenwagen("vero", 31000, 125, 4.5f, "1AZE123");
            privaten[3] = new Personenwagen();
            foreach (IPrivaat privaat in privaten)
                Console.WriteLine(privaat.GeefPrivateData());
            IMilieu[] milieus = new IMilieu[4];
            milieus[0] = new Vrachtwagen("davy", 68000, 450, 25.3f, "PZM747");
            milieus[1] = new Vrachtwagen();
            milieus[2] = new Personenwagen("vero", 31000, 125, 4.5f, "1AZE123");
            milieus[3] = new Personenwagen();
            foreach (IMilieu milieu in milieus)
                Console.WriteLine(milieu.GeefMilieuData());
        }
    }
}
