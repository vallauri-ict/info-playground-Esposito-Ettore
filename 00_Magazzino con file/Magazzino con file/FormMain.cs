using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazzino_con_file
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        int nArt, nCli, nVen, nForn;

        private void FormMain_Load(object sender, EventArgs e)
        {
            //gestione file, dgv e ComboBox per gli articoli
            ImpostaDgv(dgvArt, 7, "Codice articolo,Nome,Azienda,Prezzo,Giacenza,Scorta,Codice fornitore");
            nArt = CaricaDaFile(dgvArt, 7, "articoli.txt");
            CaricaSelectDuplicati(sltAzienda, nArt, "articoli.txt", 2);
            CaricaSelectSingoli(sltCodForn, "fornitori.txt", 0);

            //gestione file e dgv per i clienti
            ImpostaDgv(dgvCli, 4, "Codice cliente,Cognome,Nome,Città");
            nCli = CaricaDaFile(dgvCli, 4, "clienti.txt");
            CaricaSelectDuplicati(sltCittà, nCli, "clienti.txt", 3);

            //gestione file e dgv per le vendite
            ImpostaDgv(dgvVen, 4, "Codice articolo,Codice cliente,Quantità,Data");
            nVen = CaricaDaFile(dgvVen, 4, "vendite.txt");
            CaricaSelectSingoli(sltCodArt, "articoli.txt", 0);
            CaricaSelectSingoli(sltCodCli, "clienti.txt", 0);

            //gestione file e dgv per i fornitori
            ImpostaDgv(dgvForn, 3, "Codice fornitore,Nome,Città");
            nForn = CaricaDaFile(dgvForn, 3, "fornitori.txt");
        }


        private int CaricaDaFile(DataGridView dgv, int m, string file)
        {
            StreamReader sr = new StreamReader(file);
            string[] dato;
            int i = 0;
            dgv.Rows.Clear();
            while (sr.Peek() != -1)
            {
                dato = sr.ReadLine().Split(',');
                CaricaRiga(dgv, i, m, dato);
                i++;
            }
            dgv.AutoResizeColumns();
            dgv.AutoResizeRows();
            sr.Close();
            return i;
        }

        private void btmInserisciArticolo_Click(object sender, EventArgs e)
        {
            clsArticoli.InserisciArticolo(dgvArt, ref nArt, "articoli.txt", txtCodArt.Text, txtNomArt.Text, sltAzienda.Text, Convert.ToInt32(txtPrezzo.Value), Convert.ToInt32(txtGiacenza.Value), Convert.ToInt32(txtScorta.Value), sltCodForn.Text);
        }

        

        public static void CaricaRiga(DataGridView dgv, int i, int m, string[] dato)
        {
            dgv.Rows.Add();
            for (int j = 0; j < m; j++)
                dgv[j, i].Value = dato[j];
        }

        private void ImpostaDgv(DataGridView dgv, int m, string str)
        {
            string[] campi = str.Split(',');
            dgv.ColumnCount = m;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.AllowUserToOrderColumns = false;
            for (int j = 0; j < campi.Length; j++)
                dgv.Columns[j].HeaderText = campi[j];
            dgv.BackgroundColor = FormMain.DefaultBackColor;
            dgv.BorderStyle = BorderStyle.None;
            dgv.AutoResizeColumns();
        }

        private void btnInserisciVendta_Click(object sender, EventArgs e)
        {
            clsVendite.InserisciVendita(dgvVen, ref nVen, "vendite.txt", dgvArt, "articoli.txt", "fornitori.txt", sltCodArt.Text, sltCodCli.Text, Convert.ToInt32(txtQuantità.Value), Convert.ToDateTime(txtDate.Text).ToShortDateString());
        }

        private void btmCercaArticoloCodice_Click(object sender, EventArgs e)
        {
            string CodArt = Interaction.InputBox("Inserisci il codice dell'articolo: ", "Ricerca");
            int pos = clsArticoli.CercaArticoloCodice("articoli.txt", CodArt);
            dgvArt.ClearSelection();
            if (pos != -1)
                dgvArt.Rows[pos].Selected = true;
            else
                MessageBox.Show("Articolo non trovato");
        }

        private void btmModArt_Click(object sender, EventArgs e)
        {
            clsArticoli.ModificaArticolo(dgvArt, "articoli.txt");
        }

        private void btmModCli_Click(object sender, EventArgs e)
        {
            clsClienti.ModificaCliente(dgvCli, "clienti.txt");
        }

        private void btmCercaClienteCodice_Click(object sender, EventArgs e)
        {
            string CodCli = Interaction.InputBox("Inserici il codice del cliente da cercare: ", "Ricerca");
            int pos = clsClienti.CercaClienteCodice("clienti.txt", CodCli);
            dgvCli.ClearSelection();
            if (pos != -1)
                dgvCli.Rows[pos].Selected = true;
            else
                MessageBox.Show("Cliente non trovato");
        }

        private void btmTotaleVenduto_Click(object sender, EventArgs e)
        {
            string CodArt = sltCodArt.Text;
            clsUtilities.CalcolaTotaleVendutoUnArticolo("vendite.txt", "articoli.txt", CodArt);
        }

        private void btmContaVenditiPerArticolo_Click(object sender, EventArgs e)
        {
            clsUtilities.CalcolaVenditePerArticolo("vendite.txt", "articoli.txt");
        }

        private void btmTotaleAcquistiCliente_Click(object sender, EventArgs e)
        {
            clsUtilities.CalcolaAcquistiCliente("vendite.txt", "clienti.txt", sltCodCli.Text);
        }

        private void btmCalcolaAcquistiPerCliente_Click(object sender, EventArgs e)
        {
            clsUtilities.CalcolaAcquistiPerCliente("vendite.txt", "clienti.txt");
        }

        private void btmCercaMaxFornitore_Click(object sender, EventArgs e)
        {
            clsUtilities.CercaFornitoreMaxForniti("articoli.txt", "fornitori.txt");
        }

        private void btmCercaArtInvenduti_Click(object sender, EventArgs e)
        {
            clsUtilities.CercaArtInvenduti("vendite.txt", "articoli.txt");
        }

        private void btmCercaVenditeData_Click(object sender, EventArgs e)
        {
            DateTime data = txtDate.Value;
            clsUtilities.CercaVenditePostume("vendite.txt", "articoli.txt", data);
        }

        private void btmArtVendutiTraDueDate_Click(object sender, EventArgs e)
        {
            DateTime d1, d2;
            while (!DateTime.TryParse(Interaction.InputBox("Inserisci la prima data: "), out d1)) ;
            while (!DateTime.TryParse(Interaction.InputBox("Inserisci la seconda data: "), out d2)) ;
            clsUtilities.CercaArticoliTraDate("vendite.txt", "articoli.txt", d1, d2);
        }

        private void btmGiornoPiuVendite_Click(object sender, EventArgs e)
        {
            clsUtilities.CercaGiornoMaxVendite("vendite.txt");
        }

        private void btmDataMaxIncassi_Click(object sender, EventArgs e)
        {
            clsUtilities.CercaGiornoMaxIncassi("vendite.txt", "articoli.txt");
        }

        private void btmCercaClientiArticolo_Click(object sender, EventArgs e)
        {
            string CodArt = sltCodArt.Text;
            clsUtilities.CercaClientiArticolo("vendite.txt", "clienti.txt", CodArt);
        }

        private void btmCercaClientinonArticolo_Click(object sender, EventArgs e)
        {
            string CodArt = sltCodArt.Text;
            clsUtilities.CercaClientinonArticolo("vendite.txt", "clienti.txt", CodArt);
        }

        private void btmInserisciCliente_Click(object sender, EventArgs e)
        {
            clsClienti.InserisciArticolo(dgvCli, ref nCli, "clienti.txt", txtCodCli.Text, txtCognCli.Text, txtNomCli.Text, sltCittà.Text);
        }

        private void CaricaSelectDuplicati(ComboBox slt, int n, string file, int pos)
        {
            StreamReader sr = new StreamReader(file);
            slt.Items.Clear();
            string[] Campo = new string[n];
            int i = 0;

            while (sr.Peek() != -1)
                Campo[i++] = sr.ReadLine().Split(',')[pos];
            sr.Close();

            Array.Sort(Campo);
            slt.Items.Add(Campo[0]);
            for (i = 1; i < n; i++)
                if (Campo[i] != Campo[i - 1])
                    slt.Items.Add(Campo[i]);
            slt.SelectedIndex = 0;
        }

        private static void CaricaSelectSingoli(ComboBox slt, string file, int pos)
        {
            StreamReader sr = new StreamReader(file);
            slt.Items.Clear();
            while (sr.Peek() != -1)
                slt.Items.Add(sr.ReadLine().Split(',')[pos]);
            slt.SelectedIndex = 0;
            sr.Close();
        }
    }
}
