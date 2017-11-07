using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastaPizzaNet
{
    public class gerechten 
    {
        public List<Gerecht> GerechtenLijst { get; set; }
        public void AddGerechten(Gerecht gerecht)
        {
            if (GerechtenLijst == null)
                GerechtenLijst = new List<Gerecht>();
            GerechtenLijst.Add(gerecht);
        }
    }

}
