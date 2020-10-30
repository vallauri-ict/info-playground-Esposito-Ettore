using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_02_MetodiFactory
{
    class Quadrato
    {
        private int lato;

        private Quadrato(int lato)
        {
            this.lato = lato;
        }

        public static Quadrato CreaQuadrato(int lato)
        {
            if (lato <= 0)
                throw new Exception("Sai come funziona un quadrato?");
            else
                return new Quadrato(lato);
        }
    }
}
