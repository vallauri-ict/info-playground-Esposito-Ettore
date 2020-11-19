using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_03_GestioneNegozio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<int, string> Articoli = new Dictionary<int, string>();

        private void btmAggiungi_Click(object sender, EventArgs e)
        {
            try
            {
                Articoli.Add(Convert.ToInt32(txtChiave.Text), txtNome.Text);
                MessageBox.Show("Articolo \"" + txtNome.Text + "\" aggiunto");
                foreach (TextBox txt in this.Controls.OfType<TextBox>())
                    txt.Text = "";
            }
            catch(ArgumentException)
            {
                MessageBox.Show("La chiave inserita esiste già");
            }
            catch(FormatException)
            {
                MessageBox.Show("La chiave deve essere un numero");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btmVisualizza_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "Numero articoli: " + Articoli.Count;
        }

        private void txtCerca_Click(object sender, EventArgs e)
        {
            try
            {
                int chiave = Convert.ToInt32(txtChiave.Text);
                if(Articoli.ContainsKey(chiave))
                {
                    lblOutput.Text = Articoli[chiave];
                }
                else
                {
                    lblOutput.Text = "Chiave \"" + chiave + "\" non esistente";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("La chiave deve essere un numero");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
