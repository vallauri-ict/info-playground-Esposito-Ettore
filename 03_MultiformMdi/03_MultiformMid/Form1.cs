using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_MultiformMid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void apriForm2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.MdiParent = this;
            f2.Text = "Form2";
            f2.Show();
        }

        private void apriForm2ConNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(5);
            f2.MdiParent = this;
            f2.Text = "Form2";
            f2.Show();
        }

        private void apriForm2ConTextboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormApp fa = new FormApp("TextBox");
            fa.MdiParent = this;
            fa.Text = "Form 1"; 
            fa.Show();
        }

        private void apriFormModaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormApp fa = new FormApp("Mod");
            fa.MdiParent = this;
            fa.Text = "Form 1";
            fa.Show();
        }
    }
}
