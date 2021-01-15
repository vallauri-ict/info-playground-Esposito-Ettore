using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_07_ClassiAbstract
{
    class ElencoStudenti : Report
    {
        private List<Studente> Studenti = new List<Studente>();
        private string stampa = "";

        public ElencoStudenti()
        {
            Studenti.Add(new Studente("Mario", "Rossi"));
            Studenti.Add(new Studente("Pier", "Giuseppe"));
            Studenti.Add(new Studente("LUI", "Abbate"));
        }

        protected override void PrintBody()
        {
            foreach (Studente item in Studenti)
                stampa += item.nomeCompleto() + "\n";
        }

        protected override void PrintFooter()
        {
            stampa += "\nFooter";
        }

        protected override void PrintHeader()
        {
            stampa += "Header\n\n";
        }

        public string StampaElenco()
        {
            stampa = "";
            PrintReport();
            return stampa;
        }
    }
}
