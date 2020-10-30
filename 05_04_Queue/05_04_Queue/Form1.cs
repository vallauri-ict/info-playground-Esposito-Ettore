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

        private void btmAggiungi_Click(object sender, EventArgs e)
        {
            if (txtNuovo.Text != "")
            {
                Stampa s = Stampa.CreaStampa();
                s.CreateElement(txtNuovo.Text);
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
                MessageBox.Show("l'Elemento \"" + stampato + "\" è stato stampato");
            else
                MessageBox.Show("La coda è vuota");
        }
    }
}
