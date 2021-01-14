using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_05_NumeriComplessi
{
    class Quaternione : Complesso
    {
        private double immaginario2 = 0, immaginario3 = 0;
        public double j { get => immaginario2; set => immaginario2 = value; }
        public double k { get => immaginario3; set => immaginario3 = value; }

        public Quaternione() : this (0, 0, 0, 1)
        {

        }
        public Quaternione(double k) : this (0, 0, 0, k)
        {
            this.k = k;
        }
        public Quaternione(double j, double k) : this(0, 0, j, k)
        {
            this.k = k;
            this.j = j;
        }
        public Quaternione(double i, double j, double k) : this(0, i, j, k)
        {
            this.k = k;
            this.j = j;
            base.i = i;
        }
        public Quaternione(double r,double i, double j, double k)
        {
            this.k = k;
            this.j = j;
            base.i = i;
            base.r = r;
        }

        public double Norma()
        {
            return Math.Sqrt(Math.Pow(r, 2) + Math.Pow(i, 2) + Math.Pow(j, 2) + Math.Pow(k, 2));
        }

        public void Coniugato()
        {
            i = -i;
            j = -j;
            k = -k;
        }

        public string Print()
        {
            string aus = base.Print();

            if (j >= 0)
                aus += "+" + j + "j";
            else
                aus += j + "j";

            if (k >= 0)
                aus += "+" + k + "k";
            else
                aus += k + "k";
            return aus;
        }
    }
}
