using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_01_Ereditarietà
{
    class Mannaro : Mostro
    {
        protected bool mutato;

        public Mannaro()
        {
            punti = 33;
            verso = "ululato";
            mutato = true;
        }

        public double Valore()
        {
            return mutato ? base.Valore() * 2 : base.Valore();
        }

        public string Verso()
        {
            return mutato ? verso : base.verso;
        }

        public void Muta()
        {
            mutato = !mutato;
        }
    }
}
