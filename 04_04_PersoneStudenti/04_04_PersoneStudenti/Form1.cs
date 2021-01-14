using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_04_PersoneStudenti
{
    public partial class Form1 : Form
    {
        private List<Studente> Studenti = new List<Studente>();
        int pos = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CaricaDgvStudenti();
        }

        private void btmAggiungi_Click(object sender, EventArgs e)
        {
            Studente nuovo = new Studente();
            nuovo.setAll(txtNome.Text, txtCognome.Text, txtSesso.Text, Convert.ToInt32(txtEta.Value));
            Studenti.Add(nuovo);
            AggiungiDgv(nuovo);
            MessageBox.Show("Studente " + nuovo.getNome() + " aggiunt" + nuovo.getSesso() == "Maschio" ? "o" : "a");
            txtNome.Text = "";
            txtCognome.Text = "";
            txtSesso.SelectedIndex = -1;
            txtEta.Value = 0;
        }

        private void btmInserisciVoto_Click(object sender, EventArgs e)
        {
            if(pos != -1 && pos < Studenti.Count)
            {
                Studente selected = Studenti[pos];
                selected.AddVoto(Convert.ToInt32(txtVoto.Value));
                txtVoto.Value = -1;
                MessageBox.Show("Voto aggiunto a " + selected.getNome());
            }
            else
                MessageBox.Show("Selezionare uno studente dalla griglia");
        }

        private void btmVotiStudente_Click(object sender, EventArgs e)
        {
            if (pos != -1 && pos < Studenti.Count)
            {
                Studente selected = Studenti[pos];
                string voti = selected.GetVoti();
                if(voti != "")
                    MessageBox.Show("Voti studente:" + voti);
                else
                    MessageBox.Show("Lo studente " + selected.getNome() + " non ha voti");
            }
            else
                MessageBox.Show("Selezionare uno studente dalla griglia");
        }

        private void btmMediaStudente_Click(object sender, EventArgs e)
        {
            if (pos != -1 && pos < Studenti.Count)
            {
                Studente selected = Studenti[pos];
                double media = selected.MediaVoti();
                if (media != -1)
                    MessageBox.Show("Voti studente: " + media.ToString("0.00"));
                else
                    MessageBox.Show("Lo studente " + selected.getNome() + " non ha voti");
            }
            else
                MessageBox.Show("Selezionare uno studente dalla griglia");
        }

        private void dgvStudenti_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pos = e.RowIndex;
            dgvStudenti.ClearSelection();
        }

        private void CaricaDgvStudenti()
        {
            string[] Campi = { "Nome", "Cognome", "Sesso", "Età" };
            dgvStudenti.ColumnCount = Campi.Length;
            dgvStudenti.RowHeadersVisible = false;
            dgvStudenti.ReadOnly = true;
            for (int i = 0; i < Campi.Length; i++)
                dgvStudenti.Columns[i].HeaderText = Campi[i];
            dgvStudenti.AutoResizeColumns();
        }

        private void AggiungiDgv(Studente nuovo)
        {
            int row = Studenti.Count() - 1;
            dgvStudenti.Rows.Add();
            dgvStudenti[0, row].Value = nuovo.getNome();
            dgvStudenti[1, row].Value = nuovo.getCognome();
            dgvStudenti[2, row].Value = nuovo.getSesso();
            dgvStudenti[3, row].Value = nuovo.getEta();
            dgvStudenti.AutoResizeColumns();
        }
    }
}
