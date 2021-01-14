using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_05_NumeriComplessi
{
    public partial class Form1 : Form
    {
        Complesso complesso = null;
        Quaternione quaternione = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btmCreaComplesso_Click(object sender, EventArgs e)
        {
            complesso = new Complesso(Convert.ToDouble(txtReale.Value), Convert.ToDouble(txtI.Value));
            lblComplesso.Text = complesso.Print();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            quaternione = new Quaternione(Convert.ToDouble(txtReale.Value), Convert.ToDouble(txtI.Value), Convert.ToDouble(txtJ.Value), Convert.ToDouble(txtK.Value));
            lblQuaternione.Text = quaternione.Print();
        }

        private void btmConiugati_Click(object sender, EventArgs e)
        {
            if(complesso != null)
            {
                complesso.Coniugato();
                lblComplesso.Text = complesso.Print();
            }

            if(quaternione != null)
            {
                quaternione.Coniugato();
                lblQuaternione.Text = quaternione.Print();
            }
        }

        private void btmModuli_Click(object sender, EventArgs e)
        {
            double modulo;
            if (complesso != null)
            {
                modulo = complesso.Modulo();
                lblComplesso.Text = modulo.ToString("0.00");
            }

            if (quaternione != null)
            {
                modulo = quaternione.Norma();
                lblQuaternione.Text = modulo.ToString("0.00");
            }
        }

        private void btmMostraNumeri_Click(object sender, EventArgs e)
        {
            if (complesso != null)
                lblComplesso.Text = complesso.Print();

            if (quaternione != null)
                lblQuaternione.Text = quaternione.Print();
        }
    }
}
