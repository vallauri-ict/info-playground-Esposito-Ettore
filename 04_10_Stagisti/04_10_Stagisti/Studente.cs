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
            set
            {

            }
        }

        public char Sezione
        {
            get => Sezione;
            set
            {

            }
        }

        public string Specializzazione
        {
            get => specializzazione;
            set
            {

            }
        }

        #endregion

        public Studente(string nome, string cognome, string citta) : base(nome, cognome, citta)
        {

        }

        public override string Visualizza()
        {
            throw new NotImplementedException();
        }
    }
}
