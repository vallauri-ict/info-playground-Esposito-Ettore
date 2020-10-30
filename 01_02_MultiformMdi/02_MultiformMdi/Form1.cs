using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_MultiformMdi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btmApriF1_Click(object sender, EventArgs e)
        {
            Figlia1 f = new Figlia1();
            f.Text = "Figlia 1";
            f.MdiParent = this;
            f.Size = new Size(210, 180);
            f.StartPosition = FormStartPosition.Manual;
            f.Location = new Point(10, 40);
            f.Show();
        }

        private void btmApriF2_Click(object sender, EventArgs e)
        {
            Figlia2 f = new Figlia2();
            f.Text = "Figlia 2";
            f.MdiParent = this;
            f.Size = new Size(210, 180);
            f.StartPosition = FormStartPosition.Manual;
            f.Location = new Point(225, 40);
            f.Show();
        }

        private void btmFinestreAperte_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length != 1)
                MessageBox.Show("Sono state aperte " + this.MdiChildren.Length + " finestre");
            else
                MessageBox.Show("È stata aperta una finestra");
            foreach (Form f in this.MdiChildren)
                MessageBox.Show("Finestra " + f.Text + " aperta");
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEsci fm = new FormEsci();
            fm.Text = "Uscire?";
            if(fm.ShowDialog() == DialogResult.OK)
                 this.Close();
        }

        private void apri1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mstlbl.Text = "premuto Apri1";
        }

        private void apri2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mstlbl.Text = "premuto Apri2";
        }
    }
}
