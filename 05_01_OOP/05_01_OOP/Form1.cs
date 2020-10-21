using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_01_OOP
{
    public partial class Form1 : Form
    {
        rectangle r;

        public Form1()
        {
            InitializeComponent();
            r = new rectangle();
        }

        private void btmCrea_Click(object sender, EventArgs e)
        {
            /*r.side1 = Convert.ToInt32(txtBase.Text);
            r.side2 = Convert.ToInt32(txtAltezza.Text);
            rectangle t;
            t = r; //non è una copia, punta direttamente a r
            MessageBox.Show("Rettangolo r\nBase: " + r.side1 + "\nAltezza: " + r.side2);
            MessageBox.Show("Rettangolo t\nBase: " + t.side1 + "\nAltezza: " + t.side2);*/
            r.colore = Color.White;
            MessageBox.Show(r.getSides());
            r = new rectangle(Convert.ToInt32(txtBase.Text), Convert.ToInt32(txtAltezza.Text));
            MessageBox.Show(r.getSides());
        }
    }
}
