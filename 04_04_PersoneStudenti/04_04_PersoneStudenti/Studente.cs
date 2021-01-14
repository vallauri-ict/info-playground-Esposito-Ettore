using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_04_PersoneStudenti
{
    class Studente : Persona
    {
        private List<int> Voti = new List<int>();

        public double MediaVoti()
        {
            double somma = 0;
            foreach (int voto in Voti)
                somma += voto;
            if (Voti.Count() != 0)
                return somma / Voti.Count();
            else
                return -1;
        }

        public void AddVoto(int nuovo)
        {
            Voti.Add(nuovo);
        }

        public string GetVoti()
        {
            string output = "";
            foreach (int voto in Voti)
                output += " " + voto.ToString();
            return output;
        }
    }
}
