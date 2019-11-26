using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra
{
    public enum GinkloTipas
    {
        Graiztvinis,
        Lygiavamzdis,
        Sovinys
    }


    class Ginklas : Daiktas
    {
        public GinkloTipas Tipas { get; }
        public string Kalibras { get; }

        public Ginklas(string pavadinimas, double kaina, GinkloTipas tipas, string kalibras) : base(pavadinimas, kaina)
        {
            this.Tipas = tipas;
            this.Kalibras = kalibras;    
        }
        
    }
}
