using System;
using System.Collections.Generic;
using System.Text;

namespace _04_09_MondoAnimale
{
    class Uomo : Bipede
    {
        public Uomo(String s) : base(s)
        {
            verso = "parla";
        }

        public override string chi_sei()
        {
            return "homo sapiens";
        }

        public override string vive()
        {
            return "in condominio";
        }
    }
}
