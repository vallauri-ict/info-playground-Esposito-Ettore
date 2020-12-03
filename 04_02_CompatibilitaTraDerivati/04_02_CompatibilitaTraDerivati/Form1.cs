using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_02_CompatibilitaTraDerivati
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sender is Button)
                (sender as Button).Text = "Hello";
            else if (sender is Label)
                (sender as Label).BackColor = Color.Red;
        }
    }
}
