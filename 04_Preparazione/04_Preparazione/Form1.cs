using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_Preparazione
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public TextBox txtCampo2 = null;

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUscita fu = new FormUscita();
            fu.Text = "Uscire?";
            if (fu.ShowDialog() == DialogResult.OK)
                this.Close();
            stlStato.Text = "Close canceled";
        }

        private void secondariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSecondaria fs = new FormSecondaria(txtNomeOut, txtEtaOut);
            fs.Text = "Dati";
            fs.Show();
            stlStato.Text = "Form secondaria opened";
        }

        private void figliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFiglia ff = new FormFiglia(txtCampo1, ref txtCampo2);
            ff.Text = "Caro amico ti scrivo";
            ff.Show();
            stlStato.Text = "Form figlia opened";
        }

        private void mDIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fm = new Form();
            fm.Text = "Mdi";
            fm.MdiParent = this;
            fm.Show();
            stlStato.Text = "Form MDI opened";
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stlStato.Text = "Loaded";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stlStato.Text = "Saved";
        }
        private void btmInvia_Click(object sender, EventArgs e)
        {
            if (txtCampo2 != null)
                txtCampo2.Text = txtCampo1.Text;
            else
                MessageBox.Show("Prima apri la form figlia");
        }
    }
}
