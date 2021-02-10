using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_10_Stagisti
{
    sealed class Elenco
    {
        List<Studente> elenco;

        public Elenco()
        {
            elenco = new List<Studente>();
        }

        public void Inserisci(Studente nuovo)
        {
            elenco.Add(nuovo);
        }

        public void VisualizzaDGV(DataGridView dgv)
        {
            dgv.RowHeadersVisible = false;
            dgv.DataSource = null;
            dgv.DataSource = elenco;
            dgv.AutoResizeColumns();
        }

        public int OreAzienda(string nomeAzienda)
        {
            int oreTot = 0;

            foreach (Studente studente in elenco)
                if ((studente is Stagista) && (studente as Stagista).Azienda == nomeAzienda)
                    oreTot += (studente as Stagista).Ore;

            return oreTot;
        }

        public void cancella()
        {
            if (elenco.Count == 0)
                throw new Exception("Lista già vuota");
            else
                elenco.RemoveAt(elenco.Count - 1);
        }

        public void cancella(int pos)
        {
            if (elenco.Count == 0)
                throw new Exception("Lista già vuota");
            else if (pos >= elenco.Count)
                throw new Exception("Posizione non valida");
            else
                elenco.RemoveAt(pos);
        }
    }
}