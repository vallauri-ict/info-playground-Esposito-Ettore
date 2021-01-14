using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_06_Scopa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Mazzo Deck;
        Mano Campo;
        Giocatore p1, p2;
        int turno = 1;
        Carta cartaGiocata = null;

        private void btmPlay_Click(object sender, EventArgs e)
        {
            btmPlay.Visible = false;
            Deck = new Mazzo();
            Deck.Mescola();
            Campo = new Mano();
            p1 = new Giocatore(Interaction.InputBox("Inserisci il nome del giocatore 1:", "Inserisci nome"));
            p2 = new Giocatore(Interaction.InputBox("Inserisci il nome del giocatore 2:", "Inserisci nome"));
            lblP1.Text = p1.Nome;
            lblP2.Text = p2.Nome;

            for (int i = 0; i < 4; i++)
                Campo.Pesca(Deck.Pesca());
            for (int i = 0; i < 3; i++)
            {
                p1.Pesca(Deck.Pesca());
                p2.Pesca(Deck.Pesca());
            }

            ImpostaDgv(dgvMazzo, Deck.VediMazzo());
            ImpostaDgv(dgvCampo, Campo.Lettura());
            ImpostaDgv(dgvMano1, p1.Lettura());
            ImpostaDgv(dgvMano2, p2.Lettura());
            ImpostaDgv(dgvPrese1, p1.LetturaPrese());
            ImpostaDgv(dgvPrese2, p2.LetturaPrese());
        }

        private void Giocata(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (cartaGiocata == null)
                {
                    DataGridView aus = (DataGridView)sender;
                    if (turno.ToString() == aus.Name.Substring(aus.Name.Length - 1, 1))
                    {
                        bool possibile = false;
                        string seme;
                        int valore;
                        int giocata = e.RowIndex;
                        cartaGiocata = turno == 1 ? p1.Gioca(giocata) : p2.Gioca(giocata);
                        List<Carta> carteCampo = Campo.Lettura();
                        cartaGiocata.getCarta(out seme, out valore);
                        for (int i = 0; i < carteCampo.Count() && !possibile; i++)
                        {
                            string ausSeme;
                            int ausValore;
                            carteCampo[i].getCarta(out ausSeme, out ausValore);
                            if (ausValore == valore)
                                possibile = true;
                        }
                        if (possibile)
                            MessageBox.Show("Seleziona la carta da prendere");
                        else
                        {
                            Campo.Pesca(cartaGiocata);
                            ImpostaDgv(dgvCampo, Campo.Lettura());
                            ImpostaDgv(aus, turno == 1 ? p1.Lettura() : p2.Lettura());
                            Ripescata();
                            turno = turno == 1 ? 2 : 1;
                            cartaGiocata = null;
                            MessageBox.Show("Non puoi prendere carte");
                            if (turno == 1)
                                MessageBox.Show("Tunro di " + p1.Nome);
                            else
                                MessageBox.Show("Tunro di " + p2.Nome);
                        }
                    }
                    else
                        MessageBox.Show("Non è il tuo turno");
                }
            }
            catch
            {

            }
        }

        private void dgvCampo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (cartaGiocata != null)
                {
                    DataGridView aus = (DataGridView)sender;
                    int pos = e.RowIndex;
                    string semeGiocata, semeScelta;
                    int valGiocata, valScelta;
                    cartaGiocata.getCarta(out semeGiocata, out valGiocata);
                    Campo.Lettura()[pos].getCarta(out semeScelta, out valScelta);
                    if (valScelta == valGiocata)
                    {
                        Giocatore ausGiocatore = turno == 1 ? p1 : p2;
                        ausGiocatore.MettiPrese(cartaGiocata);
                        ausGiocatore.MettiPrese(Campo.Gioca(pos));
                        ImpostaDgv(dgvCampo, Campo.Lettura());
                        ImpostaDgv(turno == 1 ? dgvMano1 : dgvMano2, ausGiocatore.Lettura());
                        ImpostaDgv(turno == 1 ? dgvPrese1 : dgvPrese2, ausGiocatore.LetturaPrese());
                        Ripescata();
                        turno = turno == 1 ? 2 : 1;
                        cartaGiocata = null;
                        if (turno == 1)
                            MessageBox.Show("Tunro di " + p1.Nome);
                        else
                            MessageBox.Show("Tunro di " + p2.Nome);
                    }
                    else
                        MessageBox.Show("Devi scegliere una carta con lo stesso numero");
                }
                else
                    MessageBox.Show("Selezione prima una carta da giocare");
            }
            catch
            {

            }
        }

        private void Ripescata()
        {
            if(turno == 2)
                if(p2.Lettura().Count() == 0)
                {
                    if (Deck.VediMazzo().Count >= 6)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            p1.Pesca(Deck.Pesca());
                            p2.Pesca(Deck.Pesca());
                        }
                        ImpostaDgv(dgvMano1, p1.Lettura());
                        ImpostaDgv(dgvMano2, p2.Lettura());
                        ImpostaDgv(dgvMazzo, Deck.VediMazzo());
                    }
                    else
                    {
                        int punti1 = p1.LetturaPrese().Count();
                        int punti2 = p2.LetturaPrese().Count();
                        if(punti1 == punti2)
                            MessageBox.Show("Partita finita\nÈ un pareggio");
                        else if(punti1 > punti2)
                            MessageBox.Show("Partita finita\nHa vinto " + p1.Nome);
                        else
                            MessageBox.Show("Partita finita\nHa vinto " + p2.Nome);
                    }
                }
        }

        private void ImpostaDgv(DataGridView dgv, List<Carta> carte)
        {
            dgv.ColumnCount = 1;
            dgv.RowCount = 1;
            dgv.RowHeadersVisible = false;
            dgv.ColumnHeadersVisible = false;
            dgv.AllowUserToOrderColumns = false;
            dgv.AllowUserToResizeRows = false;

            int i = 0;
            foreach (Carta carta in carte)
            {
                string seme;
                int valore;
                carta.getCarta(out seme, out valore);
                dgv.Rows.Add();
                dgv[0, i++].Value = valore + " - " + seme;
            }
            dgv.AutoResizeColumns();
        }
    }
}
