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
        private int side1, side2;
        public Color colore;

        public rectangle()
        {
            side1 = 1;
            side2 = 1;
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
