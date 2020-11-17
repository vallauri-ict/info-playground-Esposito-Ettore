using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_02_Liste
{
    public partial class Form1 : Form
    {
        public struct Libro
        {
            public int Id;
            public string Titolo;
            public string Autore;
        }
        List<Libro> listaLibri = new List<Libro>();
        ClasseLibri Libri = new ClasseLibri();

        public Form1()
        {
            InitializeComponent();
        }

        private void btmAggiungi_Click(object sender, EventArgs e)
        {
            Libro l;
            l.Id = Convert.ToInt32(txtId.Text);
            l.Titolo = txtTitolo.Text;
            l.Autore = txtAutore.Text;
            listaLibri.Add(l);
            foreach (TextBox txt in this.Controls.OfType<TextBox>())
                txt.Text = "";
        }

        private void btmVisualizza_Click(object sender, EventArgs e)
        {
            string output = "";
            foreach (Libro l in listaLibri)
                output += "\n" + l.Id + " - " + l.Titolo + " - " + l.Autore;
            if (output != "")
                MessageBox.Show("Lista libri:" + output);
            else
                MessageBox.Show("Non ci sono libri");
        }

        private void btmAggiungiObj_Click(object sender, EventArgs e)
        {
            Libri.AggiungiLibro(Convert.ToInt32(txtId.Text), txtTitolo.Text, txtAutore.Text);
            foreach (TextBox txt in this.Controls.OfType<TextBox>())
                txt.Text = "";
        }

        private void VisualizzaObj_Click(object sender, EventArgs e)
        {
            string output = Libri.VisualizzaLibri();
            if (output != "")
                MessageBox.Show("Lista libri:" + output);
            else
                MessageBox.Show("Non ci sono libri");
        }

        private void btmFind_Click(object sender, EventArgs e)
        {
            Libro l = listaLibri.Find(bf => bf.Titolo == txtRicerca.Text);
            MessageBox.Show(l.Titolo + l.Autore);
        }

        private void btmFindAll_Click(object sender, EventArgs e)
        {
            List<Libro> l = new List<Libro>();
            l = listaLibri.FindAll(bf => bf.Autore == txtRicerca.Text);
            string output = "";
            foreach (Libro item in l)
                output += "\n" + item.Id + " - " + item.Titolo + " - " + item.Autore;
            if (output != "")
                MessageBox.Show("Libri di " + txtRicerca.Text + ":" + output);
            else
                MessageBox.Show("Autore " + txtRicerca.Text + " non trovato");
        }
    }
}
