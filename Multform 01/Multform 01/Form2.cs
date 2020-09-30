using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multform_01
{
    public partial class Form2 : Form
    {
        private int n;
        private TextBox txt1;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(int n)
        {
            InitializeComponent();
            this.n = n;
        }

        public Form2(TextBox txt1)
        {
            InitializeComponent();
            this.txt1 = txt1;
        }

        private void Leggi_Click(object sender, EventArgs e)
        {
            MessageBox.Show(n.ToString());
        }

        private void Invia_Click(object sender, EventArgs e)
        {
            txt1.Text = Inviato.Text;
        }

        private void FormFiglia_Click(object sender, EventArgs e)
        {
            FormFiglia f = new FormFiglia();
            f.Text = "gah gah ghu gah"; //bhe, è appena nata dopo tutto
            this.AddOwnedForm(f);
            f.Show();
        }
    }
}
