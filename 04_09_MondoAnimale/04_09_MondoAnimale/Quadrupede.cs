using System;
using System.Collections.Generic;
using System.Text;

namespace _04_09_MondoAnimale
{
    abstract class Quadrupede : AnimaleTerrestre
    {
        public Quadrupede(String s) : base(s)
        {

        }

        public override String si_muove()
        {
            return "avanzando su 4 zampe";
        }
    }
}
