using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_10_Stagisti
{
    class Stagista : Studente
    {
        #region prorietà

        protected string azienda;
        protected int ore;

        public string Azienda 
        { 
            get => azienda; 
            set => azienda = value; 
        }
        public int Ore
        {
            get => ore;
            set
            {
                if (value < 1)
                    throw new Exception("Prendi delle tasterer decenti");
                else
                    ore = value;
            }
        }

        #endregion

        public Stagista(string nome, string cognome, string citta, char classe, char sezione, string specializzazione, string azienda, int ore) : base(nome, cognome, citta, classe, sezione, specializzazione)
        {
            Azienda = azienda;
            Ore = ore;
        }

        public override string Visualizza()
        {
            return base.Visualizza() + " " + Azienda + " " + ore;
        }
    }
}
