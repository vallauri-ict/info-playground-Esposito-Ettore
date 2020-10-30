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
    public partial class FormApp : Form
    {
        public FormApp()
        {
            InitializeComponent();
        }

        public string app;

        public FormApp(string app)
        {
            InitializeComponent();
            this.app = app;
        }

        private void FormApp_Load(object sender, EventArgs e)
        {
            switch(app)
            {
                case "TextBox":
                    Form2 f2 = new Form2(txtOut);
                    f2.MdiParent = this.MdiParent;
                    f2.Text = "Form2";
                    f2.Show();
                    break;
                case "Mod":
                    FormModale fm = new FormModale();
                    if (fm.ShowDialog() == DialogResult.OK)
                    {
                        txtNomeOut.Text = fm.Nome;
                        txtEtaOut.Text = fm.Eta;
                        MessageBox.Show("Premuto ok");
                    }
                    else
                    {
                        txtNomeOut.Text = "";
                        txtEtaOut.Text = "";
                        MessageBox.Show("Premuto !ok");
                    }
                    break;
                default:
                    break;
            }    
        }
    }
}
