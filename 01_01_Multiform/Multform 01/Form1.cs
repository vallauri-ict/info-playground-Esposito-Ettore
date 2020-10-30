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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Text = "Form 2";
            Form2.Show();

            Form2 Form2n = new Form2(5);
            Form2n.Text = "Form 2 con n";
            Form2n.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Formb2 = new Form();
            Formb2.Text = "Ciao";
            Formb2.Show();
        }

        private void Passa_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2(Passata);
            Form2.Text = "Form 2 con textbox";
            Form2.Show();
        }

        private void ApriFormModale_Click(object sender, EventArgs e)
        {
            FormModale fm = new FormModale();
            if (fm.ShowDialog() == DialogResult.OK)
            {
                txtNomeOut.Text = fm.Nome;
                txtEtaOut.Text = fm.Età;
                MessageBox.Show("Premuto ok");
            }
            else
            {
                txtNomeOut.Text = "";
                txtEtaOut.Text = "";
                MessageBox.Show("Premuto !ok");
            }
        }
    }
}
