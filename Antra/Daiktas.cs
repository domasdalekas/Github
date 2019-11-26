using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra
{
    class Daiktas
    {
        protected string pavadinimas;
        protected double kaina;

        public Daiktas()
        {
            pavadinimas = "";
            kaina = 0.0;
        }
        public void SetPavadinima(string pavadinimas)
        {
            if (pavadinimas != null)
                this.pavadinimas = pavadinimas;
        }
        public string GetPavadinima()
        {
            return pavadinimas;
        }
        public void SetKaina(double kaina)
        {

            this.kaina = kaina;
        }  
        
        public double GetKaina()
        {
            return kaina;
        }
    }
}
