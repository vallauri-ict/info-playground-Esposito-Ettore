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
    public partial class FormModale : Form
    {
        public FormModale()
        {
            InitializeComponent();
        }

        public string Nome = "";
        public string Età = "";

        private void btmOk_Click(object sender, EventArgs e)
        {
            Nome = txtNome.Text;
            Età = txtEta.Text;
        }

        private void btmAnnulla_Click(object sender, EventArgs e)
        {
            Nome = "";
            Età = "";
        }
    }
}
