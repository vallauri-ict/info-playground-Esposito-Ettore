using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_06_Scopa
{
    class Carta
    {
        string seme;
        int valore;

        public Carta(string seme, int valore)
        {
            this.seme = seme;
            this.valore = valore;
        }

        public void getCarta(out string seme, out int valore)
        {
            seme = this.seme;
            valore = this.valore;
        }
    }
}
