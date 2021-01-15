using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_07_ClassiAbstract
{
    class Studente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }

        public Studente(string Nome, string Cognome)
        {
            this.Nome = Nome;
            this.Cognome = Cognome;
        }

        public string nomeCompleto()
        {
            return Cognome + " " + Nome;
        }
    }
}
