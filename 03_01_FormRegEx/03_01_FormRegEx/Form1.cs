using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_01_FormRegEx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btmRegistra_Click(object sender, EventArgs e)
        {
            bool valido = true;
            string errore = "";

            //cognome
            Regex regCognome = new Regex(@"^[A-Z][a-z]+$");
            if (txtCognome.Text == "")
            {
                errore += "\n - Il campo cognome è obbligatorio";
                txtCognome.BackColor = Color.Red;
                valido = false;
            }
            else if (!regCognome.IsMatch(txtCognome.Text))
            {
                errore += "\n - Il campo cognome è errato";
                txtCognome.BackColor = Color.Red;
                valido = false;
            }
            else
                txtCognome.BackColor = TextBox.DefaultBackColor;

            //nome
            Regex regNome = new Regex(@"^[A-Z][a-z]+$");
            if (txtCognome.Text == "")
            {
                errore += "\n - Il campo nome è obbligatorio";
                txtNome.BackColor = Color.Red;
                valido = false;
            }
            else if (!regCognome.IsMatch(txtNome.Text))
            {
                errore += "\n - Il campo nome è errato";
                txtNome.BackColor = Color.Red;
                valido = false;
            }
            else
                txtNome.BackColor = TextBox.DefaultBackColor;

            //indirizzo
            Regex regIndirizzo= new Regex(@"^[A-Za-z\s]+\s\d+$");
            if (txtIndirizzo.Text == "")
            {
                errore += "\n - Il campo indirizzo è obbligatorio";
                txtIndirizzo.BackColor = Color.Red;
                valido = false;
            }
            else if (!regIndirizzo.IsMatch(txtIndirizzo.Text))
            {
                errore += "\n - Il campo indirizzo è errato";
                txtIndirizzo.BackColor = Color.Red;
                valido = false;
            }
            else
                txtIndirizzo.BackColor = TextBox.DefaultBackColor;

            //Città
            Regex regCitta = new Regex(@"^[A-Z][A-Za-z]+$");
            if (txtIndirizzo.Text == "")
            {
                errore += "\n - Il campo città è obbligatorio";
                txtCitta.BackColor = Color.Red;
                valido = false;
            }
            else if (!regCitta.IsMatch(txtCitta.Text))
            {
                errore += "\n - Il campo città è errato";
                txtCitta.BackColor = Color.Red;
                valido = false;
            }
            else
                txtCitta.BackColor = TextBox.DefaultBackColor;

            //cap
            Regex regCap = new Regex(@"^\d{5}$");
            if (txtCap.Text == "")
            {
                errore += "\n - Il campo CAP è obbligatorio";
                txtCap.BackColor = Color.Red;
                valido = false;
            }
            else if (!regCap.IsMatch(txtCap.Text))
            {
                errore += "\n - Il campo CAP è errato";
                txtCap.BackColor = Color.Red;
                valido = false;
            }
            else
                txtCap.BackColor = TextBox.DefaultBackColor;

            //email
            Regex regMail = new Regex(@"^.+@.+\..{2,4}$");
            if (txtMail.Text == "")
            {
                errore += "\n - Il campo mail è obbligatorio";
                txtMail.BackColor = Color.Red;
                valido = false;
            }
            else if (!regMail.IsMatch(txtMail.Text))
            {
                errore += "\n - Il campo mail è errato";
                txtMail.BackColor = Color.Red;
                valido = false;
            }
            else
                txtMail.BackColor = TextBox.DefaultBackColor;

            //codice fiscale
            Regex regCodFisc = new Regex(@"^[a-zA-Z]{6}\d{2}[a-zA-Z]\d{2}.{4}[a-zA-Z]$");
            if (txtCodFisc.Text == "")
            {
                errore += "\n - Il campo codice fiscale è obbligatorio";
                txtCodFisc.BackColor = Color.Red;
                valido = false;
            }
            else if (!regCodFisc.IsMatch(txtCodFisc.Text))
            {
                errore += "\n - Il campo codice fiscale è errato";
                txtCodFisc.BackColor = Color.Red;
                valido = false;
            }
            else
                txtCodFisc.BackColor = TextBox.DefaultBackColor;

            //user
            if (txtUser.Text == "")
            {
                errore += "\n - Il campo user è obbligatorio";
                txtUser.BackColor = Color.Red;
                valido = false;
            }
            else
                txtUser.BackColor = TextBox.DefaultBackColor;

            //pssword
            Regex regPassword = new Regex(@"^(?=.*\d+)(?=.*[A-Z]+).{8,}");
            if (txtPassword.Text == "")
            {
                errore += "\n - Il campo password è obbligatorio";
                txtPassword.BackColor = Color.Red;
                valido = false;
            }
            else if (!regPassword.IsMatch(txtPassword.Text))
            {
                errore += "\n - Il campo password è errato";
                txtPassword.BackColor = Color.Red;
                valido = false;
            }
            else
                txtPassword.BackColor = TextBox.DefaultBackColor;

            //controllo
            if(valido)
            {
                GestioneUtenti Gestione = GestioneUtenti.CreaGestione();
                if(Gestione.AggiungiUtente(txtCognome.Text, txtNome.Text, txtIndirizzo.Text, txtCitta.Text, txtCap.Text, txtMail.Text, txtCodFisc.Text, txtUser.Text, txtPassword.Text))
                {
                    txtUser.BackColor = TextBox.DefaultBackColor;
                    MessageBox.Show("Utente aggiunto con successo");
                }
                else
                {
                    txtUser.BackColor = Color.Red;
                    MessageBox.Show("Nome utente già occupato");
                }
            }
            else
                MessageBox.Show("Elenco errori:" + errore);
        }
    }
}
