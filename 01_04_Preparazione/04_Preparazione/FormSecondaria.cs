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
    public partial class FormSecondaria : Form
    {
        public FormSecondaria()
        {
            InitializeComponent();
        }

        public TextBox txtNomeOut, txtEtaOut;

        public FormSecondaria(TextBox txtN, TextBox txtE)
        {
            InitializeComponent();
            txtNomeOut = txtN;
            txtEtaOut = txtE;
        }

        private void btmOk_Click(object sender, EventArgs e)
        {
            txtNomeOut.Text = txtNome.Text;
            txtEtaOut.Text = txtEta.Text;
            MessageBox.Show("Dati inviati:\n - Nome: " + txtNome.Text + "\n - Età: " + txtEta.Text);
        }

        private void btmCanc_Click(object sender, EventArgs e)
        {
            txtNomeOut.Text = "";
            txtEtaOut.Text = "";
            MessageBox.Show("Operazione annullata");
            this.Close();
        }
    }
}
