using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra
{
    class Daiktas
    {
        private string pavadinimas;
        private double kaina;

        public void gautiDaiktas(string Pavadinimas,double Kaina)
        {
            this.kaina = Kaina;
            this.pavadinimas = Pavadinimas;
        }
    }
}
