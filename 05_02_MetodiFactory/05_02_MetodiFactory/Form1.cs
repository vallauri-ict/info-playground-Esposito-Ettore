using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_02_MetodiFactory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btmCrea_Click(object sender, EventArgs e)
        {
            Quadrato q;
            if (txtLato.Text != "")
                try
                {
                    q = Quadrato.CreaQuadrato(Convert.ToInt32(txtLato.Text));
                    MessageBox.Show("Creato con successo");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            else
                MessageBox.Show("Metti prima un lato");
        }
    }
}
