using System;
using System.Collections.Generic;
using System.Text;

namespace _04_09_MondoAnimale
{
    class Uccello : Animale
    {
        public Uccello(String s) : base(s)
        {
            verso = "cinguetta";
        }

        public override string chi_sei()
        {
            return "uccello";
        }

        public override string si_muove()
        {
            return "volando";
        }

        public override string vive()
        {
            return "un nido su un albero";
        }
    }
}
