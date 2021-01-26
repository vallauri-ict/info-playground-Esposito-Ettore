using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_08_TreSette
{
    class Carta
    {
        private string _seme;
        private int _valore;

        public string Seme
        {
            get => _seme;
            set
            {
                if (value == "Cuore" || value == "Picche" || value == "Fiore" || value == "Quadri")
                    _seme = value;
                else
                    throw new Exception("I semi possono essere Cuore, Picche, Fiore o Quadri");
            }
        }

        public int Valore
        {
            get => _valore;
            set
            {
                if (value >= 1 && value <= 10)
                    _valore = value;
                else
                    throw new Exception("I valori vanno da 1 a 10");
            }
        }

        public Carta(string Seme, int Valore)
        {
            this.Seme = Seme;
            this.Valore = Valore;
        }

        public string Stampa()
        {
            return Valore + " - " + Seme;
        }
    }
}
