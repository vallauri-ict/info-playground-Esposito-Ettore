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
    class clsVendite
    {
        internal static void InserisciVendita(DataGridView dgv, ref int n, string file, DataGridView dgvArt, string file2, string file3, string CodArt, string CodCli, int Quantità, string data)
        { 
            int pos = clsArticoli.CercaArticoloCodiceSicuro(file2, CodArt);
            if (Quantità > Convert.ToInt32(dgvArt[4,pos].Value))
                MessageBox.Show("La quantità richiesta è troppo alta");
            else
            {
                StreamWriter sw = new StreamWriter(file, true);
                string s = CodArt + "," + CodCli + "," + Quantità.ToString() + "," + data;
                sw.WriteLine(s);
                sw.Close();
                string[] dati = s.Split(',');
                FormMain.CaricaRiga(dgv, n, 4, dati);
                n++;
                int New = 0;
                if (Convert.ToInt32(dgvArt[4, pos].Value) - Quantità < Convert.ToInt32(dgvArt[5, pos].Value))
                {
                    while ((!int.TryParse(Interaction.InputBox("L'articolo è sottoscorta, chiederne una nuova quantità: "), out New)) || (Convert.ToInt32(dgvArt[4, pos].Value) - Quantità + New < Convert.ToInt32(dgvArt[5, pos].Value))) ;
                    string Forn = CercaNomeFornitoreCodice(file3, dgvArt[6, pos].Value.ToString());
                    StreamWriter swMail = new StreamWriter("Richiesta " + Forn + ".txt", false); //crea file di testo
                    string ms = "Sig./Sig.ra " + Forn + " vorremmo acquistare da lei " + New.ToString() + " untià di " + dgvArt[1,pos].Value + "\nEsposito S.p.a.";
                    swMail.WriteLine(ms);
                    swMail.Close();
                    MessageBox.Show(ms, "Mail inviata");
                }
                dgvArt[4, pos].Value = Convert.ToInt32(dgvArt[4, pos].Value) - Quantità + New;
                s = dgvArt[0, pos].Value + "," + dgvArt[1, pos].Value + "," + dgvArt[2, pos].Value + "," + dgvArt[3, pos].Value + "," + dgvArt[4, pos].Value + "," + dgvArt[5, pos].Value + "," + dgvArt[6, pos].Value;
                StreamReader srArt = new StreamReader(file2);
                string[] NewFile = new string[dgvArt.RowCount - 1];
                int i = 0;
                while (i < NewFile.Length)
                {
                    if (i == pos)
                    {
                        NewFile[i] = s;
                        srArt.ReadLine();
                    }    
                    else
                        NewFile[i] = srArt.ReadLine();
                    i++;
                }
                srArt.Close();
                StreamWriter swArt = new StreamWriter(file2, false);
                for (i = 0; i < NewFile.Length; i++)
                    swArt.WriteLine(NewFile[i]);
                swArt.Close();
            }
        }

        internal static void ordinaVenditeCodCli(clsUtilities.Vendita[] vendite, string file)
        {
            int nVen = CaricaTabellaDaFile(vendite, file);
            OrdinaTabellaCodCli(vendite, nVen);
            CaricaFileDaTabella(vendite, nVen, file);
        }

        private static void OrdinaTabellaCodCli(clsUtilities.Vendita[] vendite, int n)
        {
            clsUtilities.Vendita aus;
            int posMin;
            for (int i = 0; i < n - 1; i++)
            {
                posMin = i;
                for (int j = i + 1; j < n; j++)
                    if (string.Compare(vendite[j].CodCli, vendite[posMin].CodCli) < 0)
                        posMin = j;
                if (i != posMin)
                {
                    aus = vendite[i];
                    vendite[i] = vendite[posMin];
                    vendite[posMin] = aus;
                }
            }
        }

        internal static void ordinaVenditeCodArt(clsUtilities.Vendita[] vendite, string file)
        {
            int nVen = CaricaTabellaDaFile(vendite, file);
            OrdinaTabellaCodArt(vendite, nVen);
            CaricaFileDaTabella(vendite, nVen, file);
        }

        private static void CaricaFileDaTabella(clsUtilities.Vendita[] vendite, int n, string file)
        {
            File.Copy(file, "originalVendite.txt", true);
            StreamWriter sw = new StreamWriter("nuovo.txt", false);
            string s;
            for (int i = 0; i < n; i++)
            {
                s = vendite[i].CodArt + "," + vendite[i].CodCli + "," + vendite[i].Quantità.ToString() + "," + vendite[i].Data.ToShortDateString();
                sw.WriteLine(s);
            }
            sw.Close();
            File.Copy("nuovo.txt", file, true);
            File.Delete("nuovo.txt");
        }

        private static void OrdinaTabellaCodArt(clsUtilities.Vendita[] vendite, int n)
        {
            clsUtilities.Vendita aus;
            int posMin;
            for (int i = 0; i < n - 1; i++)
            {
                posMin = i;
                for (int j = i + 1; j < n; j++)
                    if (string.Compare(vendite[j].CodArt, vendite[posMin].CodArt) < 0)
                        posMin = j;
                if (i != posMin)
                {
                    aus = vendite[i];
                    vendite[i] = vendite[posMin];
                    vendite[posMin] = aus;
                }
            }
        }

        private static int CaricaTabellaDaFile(clsUtilities.Vendita[] vendite, string file)
        {
            StreamReader sr = new StreamReader(file);
            string[] dato;
            int i = 0;
            while (sr.Peek() != -1)
            {
                dato = sr.ReadLine().Split(',');
                vendite[i].CodArt = dato[0];
                vendite[i].CodCli = dato[1];
                vendite[i].Quantità = Convert.ToInt32(dato[2]);
                vendite[i].Data = Convert.ToDateTime(dato[3]);
                i++;
            }
            sr.Close();
            return i;
        }

        private static string CercaNomeFornitoreCodice(string file, string CodForn)
        {
            StreamReader sr = new StreamReader(file);
            string[] dato = sr.ReadLine().Split(',');
            string s = dato[0];
            while (s != CodForn)
            {
                dato = sr.ReadLine().Split(',');
                s = dato[0];
            }
            return dato[1];
        } 

        internal static void ordinaVenditeData(string file, clsUtilities.Vendita[] vendite)
        {
            int nVen = CaricaTabellaDaFile(vendite, file);
            OrdinaTabellaData(vendite, nVen);
            CaricaFileDaTabella(vendite, nVen, file);
        }

        private static void OrdinaTabellaData(clsUtilities.Vendita[] vendite, int n)
        {
            clsUtilities.Vendita aus;
            int posMin;
            for (int i = 0; i < n - 1; i++)
            {
                posMin = i;
                for (int j = i + 1; j < n; j++)
                    if (vendite[j].Data < vendite[posMin].Data)
                        posMin = j;
                if (i != posMin)
                {
                    aus = vendite[i];
                    vendite[i] = vendite[posMin];
                    vendite[posMin] = aus;
                }
            }
        }

        internal static void CercaArticoliVenduti(string file, string[] a)
        {
            clsUtilities.Vendita[] Vendite = new clsUtilities.Vendita[20];
            ordinaVenditeCodArt(Vendite, file);
            StreamReader sr = new StreamReader(file);
            string pre = sr.ReadLine().Split(',')[0], att = "";
            int i = 0;
            while (sr.Peek() != -1)
            {
                att = sr.ReadLine().Split(',')[0];
                if (att != pre)
                {
                    a[i++] = pre;
                    pre = att;
                }
            }
            a[i] = att;
            sr.Close();
            File.Copy("originalVendite.txt", file, true);
            File.Delete("originalVendite.txt");
        }
    }
}
