using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_01_OOP
{
    public partial class Form1 : Form
    {
        rectangle r;

        public Form1()
        {
            InitializeComponent();
            r = new rectangle();
        }

        private void btmCrea_Click(object sender, EventArgs e)
        {
            //se side1 e side2 fossero pubbliche
            /*r.side1 = Convert.ToInt32(txtBase.Text);
            r.side2 = Convert.ToInt32(txtAltezza.Text);
            rectangle t;
            t = r; //non è una copia, punta direttamente a r
            MessageBox.Show("Rettangolo r\nBase: " + r.side1 + "\nAltezza: " + r.side2);
            MessageBox.Show("Rettangolo t\nBase: " + t.side1 + "\nAltezza: " + t.side2);*/

            //se side1 e side2 sono privati
            r.colore = Color.White;
            MessageBox.Show(r.getSides());
            try //prova, se va in errore esegue un catch
            {
                r = new rectangle(Convert.ToInt32(txtBase.Text), Convert.ToInt32(txtAltezza.Text));
                MessageBox.Show(r.getSides());
            }
            catch(Exception) //viene eseguito quando il try va in errore in ogni caso, mettendo eccezioni specifiche prima fa un codice diverso per ognuna
            {
                MessageBox.Show("Inserisci i lati, pirla");
            }
            r = new rectangle(6);
            MessageBox.Show(r.getSides());
        }

        private void btmCreaFattura_Click(object sender, EventArgs e)
        {
            fatture f = new fatture();
            MessageBox.Show("Fattura numero " + f.nFattura);
        }

        private void btmNFattura_Click(object sender, EventArgs e)
        {
            fatture.Visualizza();
        }

        private void btmClasseStatica_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pigreco: " + miaMath.pi + "\n3*4=" + miaMath.Prodotto(3, 4));
        }
    }
}
