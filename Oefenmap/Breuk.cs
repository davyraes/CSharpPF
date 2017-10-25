using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefenmap
{
    class Breuk
    {
        private int tellerValue;
        private int noemerValue;
        public int teller
        {
            get { return tellerValue; }
            set { tellerValue = value; }
        }
        public int noemer
        {
            get { return noemerValue; }
            set
            {
                if (value == 0)
                    throw new Exception("noemer mag niet 0 zijn.");
                noemerValue = value;
            }
        }
        public Breuk(int teller,int noemer)
        {
            this.teller = teller;
            this.noemer = noemer;
        }
        public override string ToString()
        {
            return noemer + "/" + teller;
        }
        public override bool Equals(object obj)
        {
            if (obj is Breuk)
            {
                Breuk anderebreuk = (Breuk)obj;
                return (decimal)teller / noemer == (decimal)anderebreuk.teller / anderebreuk.noemer;
            }
            else
                return false;
        }
        public override int GetHashCode()
        {
            return teller + noemer;
        }
        public static bool operator ==(Breuk eerste,Breuk tweede)
        {
            return eerste.Equals(tweede);
        }
        public static bool operator !=(Breuk eerste,Breuk tweede)
        {
            return !eerste.Equals(tweede);
        }
        public static bool operator >(Breuk eerste,Breuk tweede)
        {
            return eerste.noemer/eerste.teller > tweede.noemer/tweede.teller;
        }
        public static bool operator <(Breuk eerste,Breuk tweede)
        {
            return eerste.noemer/eerste.teller < tweede.noemer/tweede.teller;
        }
    }
}
