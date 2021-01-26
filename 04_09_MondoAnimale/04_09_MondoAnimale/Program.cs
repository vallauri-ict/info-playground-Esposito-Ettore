using System;

namespace _04_09_MondoAnimale
{
    class Program
    {
        static void Main(string[] args)
        {
			Cavallo c = new Cavallo("Furia del West");
			Uomo h = new Uomo("Johnny");
			Corvo w = new Corvo("Il corvo dell'uva");
			Tonno t = new Tonno("Palmera");
			// AnimaleMarino p = new AnimaleMarino("x");
			// ERRATO: classe astratta!
			Uccello u = new Uccello("Gabbiano");
			Pinguino p = new Pinguino("Tweety");
			c.mostra(); h.mostra();
			w.mostra(); t.mostra();
			u.mostra(); p.mostra();
		}
    }
}
