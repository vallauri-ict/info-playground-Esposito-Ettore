using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_10_Stagisti
{
    abstract class Persona
    {
        #region Proprietà

        private string nome, cognome, citta;

        public string Nome 
        { 
            get => nome; 
            set
            {
                if (value.Trim().Length >= 2)
                    nome = value;
                else
                    throw new Exception("Nome non valido");
            } 
        }

        public string Cognome 
        { 
            get => cognome;
            set
            {
                if (value.Trim().Length >= 2)
                    cognome = value;
                else
                    throw new Exception("Cognome non valido");
            }
        }

        public string Citta 
        { 
            get => citta;
            set
            {
                if (value.Trim().Length >= 2)
                    citta = value;
                else
                    throw new Exception("Città non valida");
            }
        }

        #endregion

        protected Persona(string nome, string cognome, string citta)
        {
            Nome = nome;
            Cognome = cognome;
            Citta = citta;
        }

        public abstract string Visualizza();
    }
}
