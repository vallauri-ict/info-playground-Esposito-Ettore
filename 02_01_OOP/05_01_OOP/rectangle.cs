using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_01_OOP
{
    class rectangle
    {
        private int _side1, _side2;
        private int side1
        {
            get => _side1;
            set
            {
                if (value > 0)
                    _side1 = value;
                else
                    throw new Exception("Metti un lato adatto"); //manda in errore
            }
        }
        private int side2
        {
            get => _side2;
            set
            {
                if (value > 0)
                    _side2 = value;
                else
                    throw new Exception("Metti un lato adatto");
            }
        }
        public Color colore;

        public rectangle() : this(1)
        {

        }

        public rectangle(int l) : this(l, l)
        {

        }

        public rectangle(int b, int h)
        {
            side1 = b;
            side2 = h;
        }

        public string getSides()
        {
            return "Base: " + side1 + "\nAltezza: " + side2;
        }
    }
}
