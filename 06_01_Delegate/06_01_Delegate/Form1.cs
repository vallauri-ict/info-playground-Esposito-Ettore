using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_01_Delegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //dichiarazione di un delegate con due parametri e che restituisce un intero
        public delegate int Operazione(int a, int b);

        //le 3 funzioni del delegate
        public int Somma(int x, int y)
        {
            return x + y;
        }

        public int Prodotto(int x, int y)
        {
            return x * y;
        }

        public int Differenza(int x, int y)
        {
            return x - y;
        }

        //metodi dei bottoni
        private void btmSomma_Click(object sender, EventArgs e)
        {
            //istanzio il delegate e gli dico di fare la funzione somma che rispetta parametri e return
            Operazione op = new Operazione(Somma);

            //richiamo il delegate che farà somma
            MessageBox.Show("Somma = " + op(10, 15));
        }

        private void btmProdotto_Click(object sender, EventArgs e)
        {
            //istanzio il delegate e gli dico di fare la funzione somma che rispetta parametri e return
            Operazione op = Prodotto;

            //richiamo il delegate che farà somma
            MessageBox.Show("Prodotto = " + op(10, 15));
        }

        private void btmDifferenza_Click(object sender, EventArgs e)
        {
            //istanzio il delegate e gli dico di fare la funzione somma che rispetta parametri e return
            Operazione op = new Operazione(Differenza);

            //richiamo il delegate che farà somma
            MessageBox.Show("Differenza = " + op(10, 15));
        }
    }
}
