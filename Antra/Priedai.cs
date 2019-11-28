using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra
{
    public enum PriedoTipas
    {
        Kuprine,
        Apsauga,
        Prožektorius

    }
    class Priedai : Daiktas
    {
       public PriedoTipas Tipas { get; }
       public Priedai(string pavadinimas, double kaina, PriedoTipas tipas) : base(pavadinimas, kaina)
        {
            this.Tipas = tipas;
        }
    }
}
