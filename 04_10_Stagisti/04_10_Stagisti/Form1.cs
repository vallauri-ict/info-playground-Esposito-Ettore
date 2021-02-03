using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_10_Stagisti
{
    public partial class Form1 : Form
    {
        Elenco elenco = new Elenco();

        public Form1()
        {
            InitializeComponent();
        }

        private void btmCrea_Click(object sender, EventArgs e)
        {
            if(txtNome.Text != "" && txtCitta.Text != "" && txtCitta.Text != "" && cmbClasse.Text != "" && cmbSezione.Text != "" && cmbSpec.Text != "")
            {
                Studente nuovo;
                if(cmbAzienda.Text != "" && txtOre.Value != 0)
                    nuovo = new Stagista(txtNome.Text, txtCognome.Text, txtCitta.Text, Convert.ToChar(cmbClasse.Text), Convert.ToChar(cmbSezione.Text), cmbSpec.Text, cmbAzienda.Text, Convert.ToInt32(txtOre.Value));
                else
                    nuovo = new Studente(txtNome.Text, txtCognome.Text, txtCitta.Text, Convert.ToChar(cmbClasse.Text), Convert.ToChar(cmbSezione.Text), cmbSpec.Text);
                elenco.Inserisci(nuovo);
                txtPos.Maximum++;
                elenco.VisualizzaDGV(dgvStag);
                PulisciCampi();
            }
            else
                MessageBox.Show("Completa tutti i campi");
        }

        private void PulisciCampi()
        {
            foreach (Control control in Controls)
            {
                if ((control is TextBox))
                    (control as TextBox).Text = "";
                else if ((control is ComboBox))
                    (control as ComboBox).SelectedIndex = -1;
                else if ((control is NumericUpDown))
                    (control as NumericUpDown).Value = 0;
            }
        }

        private void btmCerca_Click(object sender, EventArgs e)
        {
            string nomeAzienda = cmbAzienda.Text;
            int ore = elenco.OreAzienda(nomeAzienda);
            if(ore != 0)
                MessageBox.Show("Toale ore: " + ore);
            else
                MessageBox.Show("Nessuno ha lavorato li");
        }

        private void btmElimina_Click(object sender, EventArgs e)
        {
            int pos = Convert.ToInt32(txtPos.Value) - 1;
            if(pos >= 0)
            {
                elenco.cancella(pos);
                txtPos.Maximum--;
                elenco.VisualizzaDGV(dgvStag);
                txtPos.Value = 0;
            }
            else
                MessageBox.Show("Seleziona prima una posizione");
        }
    }
}
