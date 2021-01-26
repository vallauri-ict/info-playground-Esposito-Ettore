using System;
using System.Collections.Generic;
using System.Text;

namespace _04_09_MondoAnimale
{
    abstract class Bipede : AnimaleTerrestre
    {
        public Bipede(String s) : base(s)
        {

        }

        public override String si_muove()
        {
            return "camminando su 2 gambe";
        }
    }
}
