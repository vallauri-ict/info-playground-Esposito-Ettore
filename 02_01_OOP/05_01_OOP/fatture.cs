using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_01_OOP
{
    class fatture
    {
        private static int cntFatture = 0;
        public readonly int nFattura;

        public fatture()
        {
            cntFatture++;
            nFattura = cntFatture;
        }

        public static void Visualizza()
        {
            MessageBox.Show("Numero fatture totali: " + cntFatture);
            //MessageBox.Show("Numero fattura corrente: " + nFattura); non funge, nFattura non è statico
        }
    }
}
