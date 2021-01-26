using System;
using System.Collections.Generic;
using System.Text;

namespace _04_09_MondoAnimale
{
    class Cavallo : Quadrupede
    {
        public Cavallo(String s) : base(s)
        {
            verso = "nitrisce";
        }

        public override string chi_sei()
        {
            return "cavallo";
        }
    }
}
