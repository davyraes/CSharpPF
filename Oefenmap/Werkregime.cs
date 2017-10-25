using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Personeel
{
    public abstract partial class werknemer
    {
        public class WerkRegime
        {
            public WerkRegime(RegimeType type,int vakantiedagen=20)
                {
                    this.vakantieDagen = vakantiedagen;
                    this.Type = type;
                }
            public enum RegimeType
            {
                Voltijds,
                Viervijfde,
                Halftijds
            }
            private RegimeType typeValue;

            public RegimeType Type
            {
                get { return typeValue; }
                set { typeValue = value; }
            }
            private int vakantieDagen;
            public int Vakantie
            {
                get
                {
                    switch (Type)
                    {
                        case RegimeType.Voltijds:
                            return (int)vakantieDagen;
                        case RegimeType.Viervijfde:
                            return (int)(vakantieDagen * 4 / 5);
                        case RegimeType.Halftijds:
                            return (int)(vakantieDagen / 2);
                        default:
                            return 0;
                    }
                }
            }
           
            public override string ToString()
            {
                return Type.ToString();
            }
        }
    }
}