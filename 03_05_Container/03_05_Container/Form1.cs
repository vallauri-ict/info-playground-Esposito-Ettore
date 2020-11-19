using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_05_Container
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public struct Container
        {
            public int Codice;
            public double Peso;
            public double Tara;
            public override string ToString()
            {
                return "Numero " + this.Codice + " - Peso: " + this.Peso + " - Tara: " + this.Tara; 
            }
        }
        Stack<Container> Pila = new Stack<Container>();

        private void btmAggiungi_Click(object sender, EventArgs e)
        {
            Container nuovo;
            nuovo.Codice = Convert.ToInt32(txtCodice.Value);
            nuovo.Peso = Convert.ToDouble(txtPeso.Value);
            nuovo.Tara = Convert.ToDouble(txtTara.Value);
            if(nuovo.Tara < nuovo.Peso)
            {
                Pila.Push(nuovo);
                txtCodice.Value = 0;
                txtPeso.Value = txtPeso.Minimum;
                txtTara.Value = txtTara.Minimum;
                MessageBox.Show("Container aggiunto");
            }
            else
                MessageBox.Show("La tara non può essere maggiore del peso totale");
        }

        private void btmTogli_Click(object sender, EventArgs e)
        {
            if(Pila.Count != 0)
            {
                Container tolto = Pila.Pop();
                MessageBox.Show(tolto.ToString());
            }
            else
                MessageBox.Show("Nessun container presente");
        }
    }
}
