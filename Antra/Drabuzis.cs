using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra
{
    public enum DrabuzioTipas
    {
        Striuke,
        Kelnes,
        Kepure
    }
    class Drabuzis : Daiktas
    {
        public DrabuzioTipas Tipas { get; }
        public string Dydis { get; }
        public Drabuzis(DrabuzioTipas tipas,string dydis,string pavadinimas,double kaina) : base(pavadinimas,kaina)
        {
            this.Tipas = tipas;
            this.Dydis = dydis;
        }
    }
}
