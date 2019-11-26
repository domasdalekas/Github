using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra
{
    class Daiktas
    {
        public string Pavadinimas { get; }
        public double Kaina { get; }

        public Daiktas(string pavadinimas,double kaina)
        {
            this.Pavadinimas = pavadinimas;
            this.Kaina = kaina;
        }       
    }
}
