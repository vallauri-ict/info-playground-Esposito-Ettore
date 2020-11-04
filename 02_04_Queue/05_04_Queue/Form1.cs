using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_04_Queue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvCoda.ColumnCount = 1;
            dgvCoda.RowHeadersVisible = false;
            dgvCoda.ColumnHeadersVisible = false;
            dgvCoda.ReadOnly = true;
        }

        private void btmAggiungi_Click(object sender, EventArgs e)
        {
            if (txtNuovo.Text != "")
            {
                Stampa s = Stampa.CreaStampa();
                s.CreateElement(txtNuovo.Text);
                AggiungiInDgv(txtNuovo.Text);
                MessageBox.Show("L'lemento \"" + txtNuovo.Text  + "\" è stato aggiunto alla coda");
                txtNuovo.Text = "";
            }
            else
                MessageBox.Show("Metti un testo prima");
        }

        private void btmStampa_Click(object sender, EventArgs e)
        {
            Stampa s = Stampa.CreaStampa();
            string stampato = s.GetElement();
            if(stampato != null)
            {
                TogliDaDgv();
                MessageBox.Show("l'Elemento \"" + stampato + "\" è stato stampato");
            }
            else
                MessageBox.Show("La coda è vuota");
        }

        private void AggiungiInDgv(string text)
        {
            dgvCoda.Rows.Add();
            dgvCoda[0, dgvCoda.RowCount - 2].Value = text;
        }

        private void TogliDaDgv()
        {
            for (int i = 0; i < dgvCoda.RowCount - 1; i++)
                dgvCoda[0, i].Value = dgvCoda[0, i + 1].Value;
            dgvCoda.RowCount--;
        }
    }
}
