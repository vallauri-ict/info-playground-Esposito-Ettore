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
        private readonly string nomeFile = "Utenti.txt";
        private readonly char div = '|';

        private GestioneUtenti()
        {

        }

        public static GestioneUtenti CreaGestione()
        {
            if (ind == null)
                ind = new GestioneUtenti();
            return ind;
        }

        internal bool AggiungiUtente(string Cognome, string Nome, string Indirizzo, string Citta, string Cap, string Mail, string CodFisc, string User, string Password)
        {
            StreamReader sr = new StreamReader(nomeFile);
            bool aggiunto = true;
            while (sr.Peek() != -1 && aggiunto)
            {
                string userUtente = sr.ReadLine().Split(div)[7];
                if (User == userUtente)
                    aggiunto = false;
            }
            sr.Close();
            if (aggiunto)
            {
                StreamWriter sw = new StreamWriter(nomeFile, true);
                sw.WriteLine(Cognome + div + Nome + div + Indirizzo + div + Citta + div + Cap + div + Mail + div + CodFisc + div + User + div + Password);
                sw.Close();
            }
            return aggiunto;
        }
    }
}
