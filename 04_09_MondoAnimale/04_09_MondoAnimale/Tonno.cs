using System;
using System.Collections.Generic;
using System.Text;

namespace _04_09_MondoAnimale
{
    class Tonno : AnimaleMarino
    {
        public Tonno(String s) : base(s)
        {
            verso = "non fa versi";
        }

        public override string chi_sei()
        {
            return "tonno";
        }

        public override string si_muove()
        {
            return "nuotando";
        }
    }
}
