using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_02_Comperable
{
    public partial class Form1 : Form
    {
        Persona[] persone = { new Persona("d", "d", "a"), new Persona("a", "a", "a"), new Persona("b", "b", "b"), new Persona("e", "e", "b"), new Persona("c", "c", "a") };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StampaVet(persone);
        }

        private void StampaVet(Persona[] pers)
        {
            string output = "";
            foreach (Persona item in pers)
                output += item.ToString() + "\n";
            MessageBox.Show(output);
        }

        private void btmOridna_Click(object sender, EventArgs e)
        {
            Array.Sort(persone);
            StampaVet(persone);
        }
    }
}
