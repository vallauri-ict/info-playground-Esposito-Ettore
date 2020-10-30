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


        private string txtValue;
        TextBox txtForm1;

        public string TxtValue 
        { 
            get => txtValue;
            set 
            {
                txtValue = value;
                txtCampo2.Text = txtValue;
            }
        }

        public FormFiglia(TextBox txt1)
        {
            InitializeComponent();
            txtForm1 = txt1;
        }

        private void btmInvia_Click(object sender, EventArgs e)
        {
            txtForm1.Text = txtCampo2.Text;
        }

        internal void ChangeText(string text)
        {
            txtCampo2.Text = text;
        }
    }
}
