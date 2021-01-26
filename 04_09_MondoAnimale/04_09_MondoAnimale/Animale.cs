using System;
using System.Collections.Generic;
using System.Text;

namespace _04_09_MondoAnimale
{
    abstract class Animale
    {
		protected String nome;
		protected String verso;

		public Animale(String s)
		{
			nome = s;
		}

		public abstract String si_muove();

		public abstract String vive();

		public abstract String chi_sei();

		public void mostra()
		{
			Console.WriteLine(nome + ", " + chi_sei() + ", " + verso + ", si muove " + si_muove() + " e vive " + vive());
		}
	}
}
