using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TussentijdseOefening
{
    public class Doelgroep
    {
        public Doelgroep(int leeftijd)
        {
            this.Leeftijd = leeftijd;
           
        }

        private int leeftijdValue;
        public int Leeftijd
        {
            get
            {
                return leeftijdValue;
            }
            set
            {
                if (value >= 0)
                {
                    leeftijdValue = value;
                    if (value < 18)
                        categorieValue = Categorie.Jeugd;
                    else
                        categorieValue = Categorie.Volwassen;
                }
            }
        }
        private Categorie categorieValue;
        public Categorie Categorie
        {
            get
            {
                return categorieValue;
            }
            
        }

    }
}
