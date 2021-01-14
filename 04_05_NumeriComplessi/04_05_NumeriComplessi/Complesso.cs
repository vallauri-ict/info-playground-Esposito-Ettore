using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_05_NumeriComplessi
{
    class Complesso
    {
        private double reale = 0, immaginario = 0;
        public double r { get => reale; set => reale = value; }
        public double i { get => immaginario; set => immaginario = value; }

        public Complesso() : this (1)
        {

        }

        public Complesso(double immaginario) : this (0, immaginario)
        {
            
        }

        public Complesso(double reale, double immaginario)
        {
            r = reale;
            i = immaginario;
        }

        public double Modulo()
        {
            return Math.Sqrt(Math.Pow(r, 2) + Math.Pow(i, 2));
        }

        public void Coniugato()
        {
            i = -i;
        }

        public string Print()
        {
            string aus = r.ToString();
            if (i >= 0)
                aus += "+" + i + "i";
            else
                aus += i + "i";
            return aus;
        }
    }
}
