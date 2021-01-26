using System;
using System.Collections.Generic;
using System.Text;

namespace _04_09_MondoAnimale
{
    class Pinguino : Uccello
    {
        public Pinguino(String s) : base(s)
        {
            verso = "non fa versi";
        }

        public override string chi_sei()
        {
            return "pinguino";
        }

        public override string si_muove()
        {
            return "ma non sa volare";
        }
    }
}
