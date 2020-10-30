using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_03_ClasseSingleton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btmCreaClasse_Click(object sender, EventArgs e)
        {
            try
            {
                Singleton s1 = Singleton.CreaSingleton(Convert.ToInt32(txtValore.Text));
                MessageBox.Show("Valore s1: " + s1.GetValore());

                Singleton s2 = Singleton.CreaSingleton(Convert.ToInt32(txtValore.Text) + 5);
                MessageBox.Show("Valore s2: " + s2.GetValore());
            }
            catch (Exception)
            {
                MessageBox.Show("Metti un valore numerico");
            }
        }
    }
}
