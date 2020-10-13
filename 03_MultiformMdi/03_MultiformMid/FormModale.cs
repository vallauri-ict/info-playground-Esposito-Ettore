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
    public partial class FormModale : Form
    {
        public FormModale()
        {
            InitializeComponent();
        }

        public string Nome = "";
        public string Eta = "";

        private void btmOk_Click(object sender, EventArgs e)
        {
            Nome = txtNome.Text;
            Eta = txtEta.Text;
        }

        private void btmCanc_Click(object sender, EventArgs e)
        {
            Nome = "";
            Eta = "";
        }
    }
}
