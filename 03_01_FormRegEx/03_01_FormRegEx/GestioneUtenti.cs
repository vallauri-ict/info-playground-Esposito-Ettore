using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_01_FormRegEx
{
    class GestioneUtenti
    {
        private static GestioneUtenti ind = null;
        private const string nomeFile = "Utenti.txt";
        private const char div = '|';
        private List<string> ListaUtenti = new List<string>();

        private GestioneUtenti()
        {
            StreamReader sr = new StreamReader(nomeFile);
            while (sr.Peek() != -1)
                ListaUtenti.Add(sr.ReadLine());
            sr.Close();
        }

        public static GestioneUtenti CreaGestione()
        {
            if (ind == null)
                ind = new GestioneUtenti();
            return ind;
        }

        internal bool AggiungiUtente(string Cognome, string Nome, string Indirizzo, string Citta, string Cap, string Mail, string CodFisc, string User, string Password)
        {
            bool aggiunto = true;
            for (int i = 0; i < ListaUtenti.Count && aggiunto; i++)
            {
                string UserAtt = ListaUtenti[i].Split(div)[7];
                if (UserAtt == User)
                    aggiunto = false;
            }
            if (aggiunto)
            {
                string NuovoUtente = Cognome + div + Nome + div + Indirizzo + div + Citta + div + Cap + div + Mail + div + CodFisc + div + User + div + Password;
                ListaUtenti.Add(NuovoUtente);
                StreamWriter sw = new StreamWriter(nomeFile, true);
                sw.WriteLine(NuovoUtente);
                sw.Close();
            }
            return aggiunto;
        }
    }
}
