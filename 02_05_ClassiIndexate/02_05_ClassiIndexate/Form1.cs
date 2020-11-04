using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_05_ClassiIndexate
{
    public partial class Form1 : Form
    {
        IndexClass vet;

        public Form1()
        {
            InitializeComponent();
        }

        private void btmCrea_Click(object sender, EventArgs e)
        {
            vet = new IndexClass(Convert.ToInt32(txtLenght.Value));
            for (int i = 0; i < vet.lenght(); i++)
                vet[i] = i.ToString();
        }

        private void btmVisualizza_Click(object sender, EventArgs e)
        {
            string output = "";
            for (int i = 0; i < vet.lenght(); i++)
                output += "\nvet[" + i.ToString() + "]: " + vet[i];
            MessageBox.Show(output);
        }
    }
}
