using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_04_UsoControlloPersonalizzato
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chkNumeri_CheckedChanged(object sender, EventArgs e)
        {
            if (!myTextBox.Numero && !myTextBox.Testo.All(ch => char.IsNumber(ch)))
                myTextBox.Pulisci();
            myTextBox.Numero = chkNumeri.Checked;
        }

        private void txtDecimali_ValueChanged(object sender, EventArgs e)
        {
            myTextBox.Decimali = Convert.ToInt32(txtDecimali.Value);
        }

        private void btmPulisci_Click(object sender, EventArgs e)
        {
            myTextBox.Pulisci();
        }
    }
}
