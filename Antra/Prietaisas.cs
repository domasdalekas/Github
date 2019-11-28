using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra
{ public enum PrietaisoTipas
    {
        Taikiklis,
        Žiūronai,
        Termovizorius
    }
    class Prietaisas : Daiktas
    {
        public string Priartinimas { get; }
        public string Diametras { get; }
        public PrietaisoTipas tipas { get; }
        public Prietaisas(string pavadinimas,double kaina,string priartinimas,string diametras,PrietaisoTipas tipas):base(pavadinimas,kaina)
        {
            this.Priartinimas = priartinimas;
            this.Diametras = diametras;
            this.tipas = tipas;
        }
    }
}
