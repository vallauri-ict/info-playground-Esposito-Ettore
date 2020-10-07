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
    public partial class Form2 : Form
    {
        public int n;
        public TextBox txt1;

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

        private void btmSend_Click(object sender, EventArgs e)
        {
            if (txt1 != null)
                txt1.Text = txtSend.Text;
        }

        private void btmMostraN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("N: " + n);
        }

        private void btmformFiglia_Click(object sender, EventArgs e)
        {
            FormFiglia ff = new FormFiglia();
            ff.MdiParent = this.MdiParent;
            ff.Text = "gha gha ghu gha";
            ff.Show();
            this.AddOwnedForm(ff);
        }
    }
}
