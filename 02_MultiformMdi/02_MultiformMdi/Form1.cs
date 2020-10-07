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
            f.Location = new Point(50, 50);
            f.Show();
        }
    }
}
