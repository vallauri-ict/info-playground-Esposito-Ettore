using System;
using System.Collections.Generic;
using System.Text;

namespace _04_09_MondoAnimale
{
    abstract class AnimaleAcquatico : Animale
    {
		public AnimaleAcquatico(String s) : base(s)
		{

		}

		public override String vive()
		{
			return "nell'acqua";
		}

		public override String chi_sei()
		{
			return "un animale acquatico";
		}
	}
}
