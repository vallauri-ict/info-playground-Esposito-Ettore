using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_08_TreSette
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Mazzo Deck;
        List<Carta> p1, p2, Giocate;
        int puntiP1 = 0, puntiP2 = 0;
        int turno = 1, primoturno = 1, maxTurno = -1, presa = -1;
        string semeTurno = "";

        private void Form1_Load(object sender, EventArgs e)
        {
            Deck = new Mazzo();
            Deck.Mescola();

            p1 = new List<Carta>();
            p2 = new List<Carta>();
            Giocate = new List<Carta>();

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 5; j++)
                    p1.Add(Deck.DammiCarta());
                for (int j = 0; j < 5; j++)
                    p2.Add(Deck.DammiCarta());
            }

            GestisciDgv(dgvMazzo, Deck.Deck);
            GestisciDgv(dgvP1, p1);
            GestisciDgv(dgvP2, p2);
        }

        private void GiocaCarta(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridView dgv = (DataGridView)sender;
                if (dgv.Name[dgv.Name.Length - 1].ToString() == turno.ToString())
                {
                    int pos = e.RowIndex;
                    Carta giocata = null;
                    if (turno == 1)
                    {
                        giocata = p1[pos];
                        p1.RemoveAt(pos);
                    }
                    else
                    {
                        giocata = p2[pos];
                        p2.RemoveAt(pos);
                    } 
                    Giocate.Add(giocata);

                    
                    if ((semeTurno == giocata.Seme || semeTurno == "") && giocata.Valore > maxTurno)
                        presa = turno;
                    if (semeTurno != giocata.Seme)
                        semeTurno = giocata.Seme;
                    if(Deck.Deck.Count() != 0)
                    {
                        if (turno == 1)
                            p1.Add(Deck.DammiCarta());
                        else
                            p2.Add(Deck.DammiCarta());
                    }
                    if(primoturno != turno)
                    {
                        if (presa == 1)
                            puntiP1++;
                        else if(presa == 2)
                            puntiP2++;
                        primoturno = presa;
                        turno = presa;
                        if(presa != -1)
                            MessageBox.Show("Presa di giocatore " + presa);
                        else
                            MessageBox.Show("Nessuno ha fatto la presa");
                        maxTurno = -1;
                        presa = -1;
                    }
                    else
                        turno = turno == 1 ? 2 : 1;

                    GestisciDgv(dgvMazzo, Deck.Deck);
                    GestisciDgv(dgvP1, p1);
                    GestisciDgv(dgvP2, p2);
                    GestisciDgv(dgvGiocate, Giocate);
                }
                else
                    MessageBox.Show("Non è il tuo turno");
            }
            catch
            {

            }
        }

        private void GestisciDgv(DataGridView dgv, List<Carta> carte)
        {
            dgv.ColumnCount = 1;
            dgv.RowCount = 1;
            dgv.ReadOnly = true;
            dgv.AllowUserToOrderColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.RowHeadersVisible = false;
            dgv.ColumnHeadersVisible = false;

            for (int i = 0; i < carte.Count(); i++)
            {
                dgv.Rows.Add();
                dgv[0, i].Value = carte[i].Stampa();
            }
            dgv.AutoResizeColumns();
            dgv.AutoResizeRows();
        }
    }
}
