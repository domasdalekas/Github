using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra
{
    class Ginklas : Daiktas
    {
        private string tipas;


        private string kalibras;

        public Ginklas()
        {
            pavadinimas = "";
            kaina = 0.0;
            tipas = "";
            kalibras = "";
        }
        public void SetTipas(string tipas)
        {
            if (tipas != null)
                this.tipas = tipas;
        }
        public string GetTipas()
        {
            return tipas;
        }
        public void SetKalibras(string kalibras)
        {
            if (kalibras != null)
                this.kalibras = kalibras;
        }
        public string GetKalibras()
        {
            return kalibras;
        }
    }
}
