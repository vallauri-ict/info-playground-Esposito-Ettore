using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_04_GestioneOspedale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public struct Paziente
        {
            public string Nome;
            public int Età;
            public string Priorità;
            public override string ToString()
            {
                return this.Nome + " " + this.Età.ToString() + " " + this.Priorità;
            }
        }
        Queue<Paziente> Rossi = new Queue<Paziente>();
        Queue<Paziente> Gialli = new Queue<Paziente>();
        Queue<Paziente> Verdi = new Queue<Paziente>();
        Queue<Paziente> Bianchi = new Queue<Paziente>();
        float maxTemp = 31, minTemp = 43;
        /*
        Bianco
        Verde
        Giallo
        Rosso 
        */

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPriorita.SelectedIndex = 0;
        }

        private void btmAggiungi_Click(object sender, EventArgs e)
        {
            if(txtNome.Text != "")
            {
                Paziente nuovo;
                nuovo.Nome = txtNome.Text;
                nuovo.Età = Convert.ToInt32(txtEta.Value);
                nuovo.Priorità = txtPriorita.Text;
                switch(nuovo.Priorità)
                {
                    case "Rosso":
                        Rossi.Enqueue(nuovo);
                        break;
                    case "Giallo":
                        Gialli.Enqueue(nuovo);
                        break;
                    case "Verde":
                        Verdi.Enqueue(nuovo);
                        break;
                    case "Bianco":
                        Bianchi.Enqueue(nuovo);
                        break;
                    default:
                        break;
                }
                float temp = (float)txtTemp.Value;
                if (temp < minTemp)
                    minTemp = temp;
                if (temp > maxTemp)
                    maxTemp = temp;
                txtNome.Text = "";
                txtEta.Value = txtEta.Minimum;
                txtPriorita.SelectedIndex = 0;
                txtTemp.Value = txtTemp.Minimum;
            }
            else
                MessageBox.Show("Inserire il nome");
        }

        private void btmChiedi_Click(object sender, EventArgs e)
        {
            Paziente uscito;
            string output = "";
            if(Rossi.Count != 0)
            {
                uscito = Rossi.Dequeue();
                output = uscito.ToString();
            }
            else if (Gialli.Count != 0)
            {
                uscito = Gialli.Dequeue();
                output = uscito.ToString();
            }
            else if (Verdi.Count != 0)
            {
                uscito = Verdi.Dequeue();
                output = uscito.ToString();
            }
            else if (Bianchi.Count != 0)
            {
                uscito = Bianchi.Dequeue();
                output = uscito.ToString();
            }
            if (output != "")
                lblOutput.Text = output;
            else
                lblOutput.Text = "Nessun paziente";
        }

        private void btmTemp_Click(object sender, EventArgs e)
        {
            if (maxTemp < minTemp)
                MessageBox.Show("Nessuna temperatura rilevata");
            else if (maxTemp == minTemp)
                MessageBox.Show("Unica temperatura rilevata: " + maxTemp);
            else
                MessageBox.Show("Temperatura minima: " + minTemp + "\nTemperatura massima: " + maxTemp);
        }
    }
}
