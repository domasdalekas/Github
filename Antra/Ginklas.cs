using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra
{
    class Ginklas : Daiktas
    {
        private string tipas { get; set; }
       
        private string kalibras { get; set; }

        public void gautiGinkla(string Tipas, string Kalibras)
        {
            this.tipas = Tipas;
            this.kalibras = Kalibras;
        }
    }
}
