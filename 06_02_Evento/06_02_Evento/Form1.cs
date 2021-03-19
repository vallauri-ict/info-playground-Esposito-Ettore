using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_02_Evento
{
    public partial class Form1 : Form
    {
        Counter cnt;

        public Form1()
        {
            InitializeComponent();
        }

        private void btmCrea_Click(object sender, EventArgs e)
        {
            try
            {
                cnt = new Counter(Convert.ToInt32(txtNumero.Text));
                cnt.overMax += new OverMaxEventHandler(GestioneMaxValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btmIncrementa_Click(object sender, EventArgs e)
        {
            try
            {
                cnt.Increment();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GestioneMaxValue(object sender, OverMaxEventArgs e)
        {
            MessageBox.Show("Superato il valore soglia di " + e.ValoreSoglia);
        }
    }
}
