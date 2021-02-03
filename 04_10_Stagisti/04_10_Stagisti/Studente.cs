using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_10_Stagisti
{
    class Studente : Persona
    {
        #region Proprietà

        private static int progressivo = 0;
        private readonly string matricola;
        private char classe;
        private char sezione;
        private string specializzazione;

        public char Classe
        {
            get => classe;
            set => classe = Convert.ToChar(value);
        }

        public char Sezione
        {
            get => sezione;
            set => sezione = Convert.ToChar(value);
        }

        public string Specializzazione
        {
            get => specializzazione;
            set => specializzazione = value;
        }

        #endregion

        public Studente(string nome, string cognome, string citta, char classe, char sezione, string specializzazione) : base(nome, cognome, citta)
        {
            Classe = classe;
            Sezione = sezione;
            Specializzazione = specializzazione;
            progressivo++;
            matricola = "A" + progressivo.ToString().PadLeft(5, '0');
        }

        public override string Visualizza()
        {
            return matricola + " " + Nome + " " + Cognome + " " + Citta + " " + Classe + "^" + Sezione + " " + Specializzazione;
        }
    }
}
