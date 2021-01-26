using System;
using System.Collections.Generic;
using System.Text;

namespace _04_09_MondoAnimale
{
    abstract class AnimaleTerrestre : Animale
    {
		public AnimaleTerrestre(String s) : base(s)
		{

		}

		public override String vive()
		{
			return "sulla terraferma";
		}

		public override String chi_sei()
		{
			return "un animale terrestre";
		}
	}
}
