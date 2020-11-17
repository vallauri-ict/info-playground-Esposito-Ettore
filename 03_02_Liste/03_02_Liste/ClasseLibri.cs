using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_02_Liste
{
    class ClasseLibri
    {
        Dictionary<int, Libro> listaLibri = new Dictionary<int,Libro>();
        public struct Libro
        {
            public string Titolo;
            public string Autore;
        }

        public ClasseLibri()
        {

        }

        public void AggiungiLibro(int id, string titolo, string autore)
        {
            Libro l;
            l.Titolo = titolo;
            l.Autore = autore;
            listaLibri.Add(id, l);
        }

        public string VisualizzaLibri()
        {
            string output = "";
            foreach (Libro l in listaLibri.Values)
                output += "\n" + l.Titolo + " - " + l.Autore;
            return output;
        }
    }
}
