using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_03_IComparer
{
    class Persona
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

        public override string ToString()
        {
            return cognome + " " + nome + " " + citta;
        }

        public class confrontaCognome : IComparer<Object>
        {
            int IComparer<Object>.Compare(Object o1, Object o2)
            {
                //0 se sono uguali, 1 se il primo è più grande, -1 se il rpimo è più piccolo
                if (o1 == null && o2 == null) return 0;
                else if (o1 == null) return 1;
                else if (o2 == null) return -1;
                else
                {
                    Persona p1 = (Persona)o1;
                    Persona p2 = (Persona)o2;
                    return String.Compare(p1.cognome, p2.cognome, true);
                }
            }
        }

        public class confrontaNome : IComparer<Object>
        {
            int IComparer<Object>.Compare(Object o1, Object o2)
            {
                if (o1 == null && o2 == null) return 0;
                else if (o1 == null) return 1;
                else if (o2 == null) return -1;
                else
                {
                    Persona p1 = (Persona)o1;
                    Persona p2 = (Persona)o2;
                    return String.Compare(p1.nome, p2.nome, true);
                }
            }
        }

    }
}
