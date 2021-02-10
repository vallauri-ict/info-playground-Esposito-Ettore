using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_02_Comperable
{
    class Persona : IComparable
    {
        private string nome;
        private string cognome;
        private string citta;

        public Persona(string nome, string cognome, string citta)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.citta = citta;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            return string.Compare(cognome, (obj as Persona).cognome, true);
        }

        public override string ToString()
        {
            return cognome + " " + nome + " " + citta;
        }
    }
}
