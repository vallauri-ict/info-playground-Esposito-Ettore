using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_04_PersoneStudenti
{
    class Persona
    {
        private string nome, cognome, sesso;
        private int eta;

        public void setAll(string nome, string cognome, string sesso, int eta)
        {
            if(nome != "" && cognome != "" && sesso != "")
            {
                this.nome = nome;
                this.cognome = cognome;
                this.sesso = sesso;
                this.eta = eta;
            }
            else
                MessageBox.Show("Tutti i campi devono essere compilati");
        }

        public string getNome()
        {
            return this.nome;
        }

        public string getCognome()
        {
            return this.cognome;
        }

        public string getSesso()
        {
            return this.sesso;
        }

        public int getEta()
        {
            return this.eta;
        }
    }
}
