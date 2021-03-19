using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_03_ControlliPersonalizzato
{
    public partial class MyTextBox: UserControl
    {
        #region Proprietà

        private bool _numero = false;
        private string _testo;
        private int _decimali = 0;

        public bool Numero 
        { 
            get => _numero; 
            set => _numero = value; 
        }

        public string Testo
        { 
            get => _testo = txtTesto.Text;
            set
            {
                _testo = value;
                txtTesto.Text = value;
            }
        }

        public int Decimali 
        { 
            get => _decimali;
            set
            {
                _decimali = value;
                ReimpostaTesto();
            }
        }

        #endregion

        public MyTextBox()
        {
            InitializeComponent();
        }


        private void txtTesto_Leave(object sender, EventArgs e)
        {
            ReimpostaTesto();
        }

        private void txtTesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Numero)
            {
                if (!(char.IsDigit(e.KeyChar) || e.KeyChar == ',' || char.IsControl(e.KeyChar)))
                    e.Handled = true;
                else if (e.KeyChar == ',' && Testo.Contains(','))
                    e.Handled = true;
            }
        }

        private void ReimpostaTesto()
        {
            if(Numero && Testo != "")
            {
                try
                {
                    //controllo se ci sono troppe virgole
                    if(ContaVirgole(Testo) > 1)
                    {
                        throw new Exception("Ci sono troppe virgole");
                    }

                    //controllo dei decimali
                    double numero = Math.Round(Convert.ToDouble(Testo), Decimali);
                    Testo = numero.ToString();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private int ContaVirgole(string testo)
        {
            int cont = 0;
            for (int i = 0; i < testo.Length; i++)
                if (testo[i] == ',')
                    cont++;
            return cont;
        }

        public void Pulisci()
        {
            Testo = "";
        }
    }
}
