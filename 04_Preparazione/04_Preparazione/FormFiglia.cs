using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_Preparazione
{
    public partial class FormFiglia : Form
    {
        public FormFiglia()
        {
            InitializeComponent();
        }

        public TextBox txtCampo1;

        public FormFiglia(TextBox txtC1, ref TextBox txtC2)
        {
            InitializeComponent();
            txtCampo1 = txtC1;
            txtC2 = txtCampo2;
        }

        private void btmInvia_Click(object sender, EventArgs e)
        {
            txtCampo1.Text = txtCampo2.Text;
        }
    }
}
