using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_03_IComparer
{
    public partial class Form1 : Form
    {
        Persona[] persone = { new Persona("d", "q", "a"), new Persona("a", "r", "a"), new Persona("b", "p", "b"), new Persona("e", "t", "b"), new Persona("c", "s", "a") };

        public Form1()
        {
            InitializeComponent();
            StampaVet(persone);
        }

        private void btmOrdinaCognome_Click(object sender, EventArgs e)
        {
            Array.Sort(persone, new Persona.confrontaCognome());
            StampaVet(persone);
        }

        private void btmOrdinaNome_Click(object sender, EventArgs e)
        {
            Array.Sort(persone, new Persona.confrontaNome());
            StampaVet(persone);
        }

        private void StampaVet(Persona[] pers)
        {
            string output = "";
            foreach (Persona item in pers)
                output += item.ToString() + "\n";
            MessageBox.Show(output);
        }
    }
}