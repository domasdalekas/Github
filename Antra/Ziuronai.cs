using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra
{
    class Ziuronai : Daiktas
    {
        public int Priartinimas { get; }
        public int Diametras { get; }
        public Ziuronai(int priartinimas, int diametras):base(pavadinimas,kaina)
        {
            this.Priartinimas = priartinimas;
            this.Diametras = diametras;
        }
    }
}
