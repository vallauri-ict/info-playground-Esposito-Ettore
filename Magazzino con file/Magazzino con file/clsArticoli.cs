using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazzino_con_file
{
    class clsArticoli
    {
        internal static void InserisciArticolo(DataGridView dgv, ref int n, string file, string CodArt, string Nome, string Azienda, int Prezzo, int Giacenza, int Scorta, string Fornitore)
        {
            if ((String.Compare(CodArt, dgv[0, n - 1].Value.ToString()) <= 0) || (CodArt == ""))
                MessageBox.Show("Codice articolo non valido o non presente");
            else if (Nome == "")
                MessageBox.Show("Nome non presente");
            else if (Fornitore == "")
                MessageBox.Show("Codice fornitore non presente");
            else
            {
                StreamWriter sw = new StreamWriter(file, true);
                string s = CodArt + "," + Nome + "," + Azienda + "," + Prezzo.ToString() + "," + Giacenza.ToString() + "," + Scorta.ToString() + "," + Fornitore;
                sw.WriteLine(s);
                sw.Close();
                string[] dati = s.Split(',');
                FormMain.CaricaRiga(dgv, n, 7, dati);
                n++;
            }
        }

        internal static int CercaPrezzoArticolo(string file, string CodArt)
        {
            StreamReader sr = new StreamReader(file);
            string[] dato = sr.ReadLine().Split(',');
            string s = dato[0];
            while (s != CodArt)
            {
                dato = sr.ReadLine().Split(',');
                s = dato[0];
            }
            return Convert.ToInt32(dato[3]);
        }

        internal static int CercaArticoloCodiceSicuro(string file, string codArt)
        {
            StreamReader sr = new StreamReader(file);
            string s = sr.ReadLine().Split(',')[0];;
            int i = 0;
            while (s != codArt)
            {
                s = sr.ReadLine().Split(',')[0];
                i++;
            }
            sr.Close();
            return i;
        }

        internal static int CercaArticoloCodice(string file, string codArt)
        {
            StreamReader sr = new StreamReader(file);
            int i = 0;
            string s = sr.ReadLine().Split(',')[0];
            while((sr.Peek() != -1) && (s != codArt))
            {
                s = sr.ReadLine().Split(',')[0];
                i++;
            }
            sr.Close();
            if (s == codArt)
                return i;
            else
                return -1;
        }

        internal static string cercaNomArt(string file, string CodArt)
        {
            StreamReader sr = new StreamReader(file);
            string[] dati = sr.ReadLine().Split(',');
            while (dati[0] != CodArt)
                dati = sr.ReadLine().Split(',');
            sr.Close();
            return dati[1];
        }

        internal static void ModificaArticolo(DataGridView dgv, string file)
        {
            string CodArt = Interaction.InputBox("Inserisci il codice dell'articolo da modificare: ", "Modifica");
            int pos = CercaArticoloCodice(file, CodArt);
            if (pos != -1)
            {
                dgv.ClearSelection();
                dgv.Rows[pos].Selected = true;
                int pre, gia;
                while ((!int.TryParse(Interaction.InputBox("Inserisci il nuovo prezzo o metti 0: ", "Modifica", "0"), out pre)) && (pre < 0)) ;
                if (pre == 0)
                    pre = Convert.ToInt32(dgv[3, pos].Value);
                else
                    dgv[3, pos].Value = pre.ToString();
                while ((!int.TryParse(Interaction.InputBox("Inserisci la nuova giacenza o metti 0: ", "Modifica", "0"), out gia)) && (gia < 0)) ;
                if (gia == 0)
                    gia = Convert.ToInt32(dgv[4, pos].Value);
                else
                    dgv[4, pos].Value = gia.ToString();
                string newLine = dgv[0, pos].Value + "," + dgv[1, pos].Value + "," + dgv[2, pos].Value + "," + pre.ToString() + "," + gia.ToString() + "," + dgv[5, pos].Value + "," + dgv[6, pos].Value;
                string[] newFile = new string[dgv.RowCount - 1];
                StreamReader sr = new StreamReader(file);
                int i = 0;
                while (sr.Peek() != -1)
                {
                    if (i == pos)
                    {
                        newFile[i] = newLine;
                        sr.ReadLine();
                    }
                    else
                        newFile[i] = sr.ReadLine();
                    i++;
                }
                sr.Close();
                StreamWriter sw = new StreamWriter(file, false);
                for (i = 0; i < newFile.Length; i++)
                    sw.WriteLine(newFile[i]);
                sw.Close();
            }
            else
                MessageBox.Show("Articolo non esistente");
        }

        internal static void OrdinaArticoliCodForn(clsUtilities.Articolo[] articoli, string file)
        {
            int nArt = CaricaTabellaDaFile(articoli, file);
            OrdinaTabellaCodForn(articoli, nArt);
            CaricaFileDaTabella(articoli, nArt, file);
        }

        private static void CaricaFileDaTabella(clsUtilities.Articolo[] articoli, int n, string file)
        {
            File.Copy(file, "originalArticoli.txt", true);
            StreamWriter sw = new StreamWriter("nuovo.txt", false);
            string s;
            for (int i = 0; i < n; i++)
            {
                s = articoli[i].CodArt + "," + articoli[i].NomeArt + "," + articoli[i].Azienda + "," + articoli[i].Prezzo.ToString() + "," + articoli[i].Giacenza.ToString() + "," + articoli[i].Scorta.ToString() + "," + articoli[i].CodForn;
                sw.WriteLine(s);
            }
            sw.Close();
            File.Copy("nuovo.txt", file, true);
            File.Delete("nuovo.txt");
        }

        private static void OrdinaTabellaCodForn(clsUtilities.Articolo[] articoli, int n)
        {
            clsUtilities.Articolo aus;
            int posMin;
            for (int i = 0; i < n - 1; i++)
            {
                posMin = i;
                for (int j = i + 1; j < n; j++)
                    if (string.Compare(articoli[j].CodForn, articoli[posMin].CodForn) < 0)
                        posMin = j;
                if (i != posMin)
                {
                    aus = articoli[i];
                    articoli[i] = articoli[posMin];
                    articoli[posMin] = aus;
                }
            }
        }

        internal static int CercaTuttiCodArt(string file, string[] a)
        {
            StreamReader sr = new StreamReader(file);
            int i = 0;
            while (sr.Peek() != -1)
                a[i++] = sr.ReadLine().Split(',')[0];
            sr.Close();
            return i;
        }

        private static int CaricaTabellaDaFile(clsUtilities.Articolo[] articoli, string file)
        {
            StreamReader sr = new StreamReader(file);
            string[] dato;
            int i = 0;
            while (sr.Peek() != -1)
            {
                dato = sr.ReadLine().Split(',');
                articoli[i].CodArt = dato[0];
                articoli[i].NomeArt = dato[1];
                articoli[i].Azienda = dato[2];
                articoli[i].Prezzo = Convert.ToInt32(dato[3]);
                articoli[i].Giacenza = Convert.ToInt32(dato[4]);
                articoli[i].Scorta = Convert.ToInt32(dato[5]);
                articoli[i].CodForn = dato[6];
                i++;
            }
            sr.Close();
            return i;
        }
    }
}
