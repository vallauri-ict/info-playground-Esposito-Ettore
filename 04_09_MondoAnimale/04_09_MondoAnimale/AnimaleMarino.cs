using System;
using System.Collections.Generic;
using System.Text;

namespace _04_09_MondoAnimale
{
    abstract class AnimaleMarino : AnimaleAcquatico
    {
		public AnimaleMarino(String s) : base(s)
		{

		}

		public override String vive()
		{
			return "in mare";
		}

		public override String chi_sei()
		{
			return "un animale marino";
		}
	}
}
