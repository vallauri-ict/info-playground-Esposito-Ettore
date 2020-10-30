using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazzino_con_file
{
    class clsUtilities
    {
        public struct Vendita
        {
            public string CodArt;
            public string CodCli;
            public int Quantità;
            public DateTime Data;
        }

        public struct Articolo
        {
            public string CodArt;
            public string NomeArt;
            public string Azienda;
            public int Prezzo;
            public int Giacenza;
            public int Scorta;
            public string CodForn;
        }

        internal static void CalcolaTotaleVendutoUnArticolo(string fileVen, string fileArt, string CodArt)
        {
            int pre = clsArticoli.CercaPrezzoArticolo(fileArt, CodArt);
            Vendita[] Vendite = new Vendita[20];
            clsVendite.ordinaVenditeCodArt(Vendite, fileVen);
            bool sup = false;
            int guadagni, cont = 0;
            string[] dato;
            StreamReader sr = new StreamReader(fileVen);
            while ((sr.Peek() != -1) && (!sup))
            {
                dato = sr.ReadLine().Split(',');
                if (dato[0] == CodArt)
                    cont += Convert.ToInt32(dato[2]);
                else if (string.Compare(dato[0], CodArt) > 0)
                    sup = true;
            }
            guadagni = cont * pre;
            sr.Close();
            File.Copy("originalVendite.txt", fileVen, true);
            File.Delete("originalVendite.txt");
            MessageBox.Show("L'articolo " + CodArt + " è stato venduto " + cont.ToString() + " volte con un guadagno di " + guadagni.ToString() + "€");
        }

        internal static void CalcolaVenditePerArticolo(string fileVen, string fileArt)
        {
            Vendita[] Vendite = new Vendita[20];
            clsVendite.ordinaVenditeCodArt(Vendite, fileVen);
            StreamReader sr = new StreamReader(fileVen);
            string[] dati = sr.ReadLine().Split(',');
            int cont = Convert.ToInt32(dati[2]);
            string pre = dati[0], output = "";
            while (sr.Peek() != -1)
            {
                dati = sr.ReadLine().Split(',');
                if (dati[0] != pre)
                {
                    output += "\n - " + pre + " " + clsArticoli.cercaNomArt(fileArt, pre) + ": " + cont;
                    cont = 0;
                    pre = dati[0];
                }
                cont += Convert.ToInt32(dati[2]);
            }
            output += "\n - " + pre + " " + clsArticoli.cercaNomArt(fileArt, pre) + ": " + cont;
            sr.Close();
            File.Copy("originalVendite.txt", fileVen, true);
            File.Delete("originalVendite.txt");
            MessageBox.Show("Lista degli articoli venditi: " + output);
        }

        internal static void CalcolaAcquistiCliente(string fileVen, string fileCli, string CodCli)
        {
            Vendita[] Vendite = new Vendita[20];
            clsVendite.ordinaVenditeCodCli(Vendite, fileVen);
            StreamReader sr = new StreamReader(fileVen);
            string[] dati;
            int cont = 0;
            bool sup = false;
            while ((sr.Peek() != -1) && (!sup))
            {
                dati = sr.ReadLine().Split(',');
                if (dati[1] == CodCli)
                    cont += Convert.ToInt32(dati[2]);
                else if (string.Compare(dati[1], CodCli) > 0)
                    sup = true;
            }
            string Nominativo = clsClienti.CercaNominativoCodice(fileCli, CodCli);
            sr.Close();
            File.Copy("originalVendite.txt", fileVen, true);
            File.Delete("originalVendite.txt");
            MessageBox.Show("Il cliente " + Nominativo + " ha acquistato in totale " + cont.ToString() + " articoli");
        }

        internal static void CalcolaAcquistiPerCliente(string fileVen, string fileCli)
        {
            Vendita[] Vendite = new Vendita[20];
            clsVendite.ordinaVenditeCodCli(Vendite, fileVen);
            StreamReader sr = new StreamReader(fileVen);
            string[] dati = sr.ReadLine().Split(',');
            string output = "", pre = dati[1];
            int cont = Convert.ToInt32(dati[2]);
            while (sr.Peek() != -1)
            {
                dati = sr.ReadLine().Split(',');
                if (dati[1] != pre)
                {
                    output += "\n - " + clsClienti.CercaNominativoCodice(fileCli, pre) + ": " + cont.ToString();
                    cont = 0;
                    pre = dati[1];
                }
                cont += Convert.ToInt32(dati[2]);
            }
            string Nominativo = clsClienti.CercaNominativoCodice(fileCli, pre);
            output += "\n - " + Nominativo + ": " + cont.ToString();
            sr.Close();
            File.Copy("originalVendite.txt", fileVen, true);
            File.Delete("originalVendite.txt");
            MessageBox.Show("Elenco acquisti per cliente: " + output);
        }

        internal static void CercaFornitoreMaxForniti(string fileArt, string fileForn)
        {
            Articolo[] Articoli = new Articolo[20];
            clsArticoli.OrdinaArticoliCodForn(Articoli, fileArt);
            StreamReader sr = new StreamReader(fileArt);
            string[] dato = sr.ReadLine().Split(',');
            string pre = dato[6], maxForn = "";
            int max = 0, cont = Convert.ToInt32(dato[4]);

            while (sr.Peek() != -1)
            {
                dato = sr.ReadLine().Split(',');
                if (dato[6] != pre)
                {
                    if (cont > max)
                    {
                        max = cont;
                        maxForn = dato[6];
                    }
                    pre = dato[6];
                    cont = 0;
                }
                cont += Convert.ToInt32(dato[4]);
            }
            if (cont > max)
            {
                max = cont;
                maxForn = dato[6];
            }
            sr.Close();
            File.Copy("originalArticoli.txt", fileArt, true);
            File.Delete("originalArticoli.txt");
            MessageBox.Show("Il fonitore è " + CercaNomeFornCodForn(fileForn, maxForn) + " con " + max.ToString() + " articoli forniti");
        }

        internal static void CercaArtInvenduti(string fileVen, string fileArt)
        {
            string[] CodArtVenduti = new string[20], CodArtTotali = new string[20];
            int nArt = clsArticoli.CercaTuttiCodArt(fileArt, CodArtTotali);
            clsVendite.CercaArticoliVenduti(fileVen, CodArtVenduti);
            string output = "";
            for (int i = 0; i < nArt; i++)
                if (Array.IndexOf(CodArtVenduti, CodArtTotali[i]) == -1) //volevo solo provare il comando
                    output += "\n - " + CodArtTotali[i] + ": " + clsArticoli.cercaNomArt(fileArt, CodArtTotali[i]);
            if (output != "")
                MessageBox.Show("Lista articoli mai venduti: " + output);
            else
                MessageBox.Show("Tutti gli articoli sono stati venduti");
        }

        internal static void CercaClientiArticolo(string fileVen, string fileCli, string CodArt)
        {
            Vendita[] Vendite = new Vendita[20];
            clsVendite.ordinaVenditeCodArt(Vendite, fileVen);
            StreamReader sr = new StreamReader(fileVen);
            string[] dati, trovati = new string[20];
            bool sup = false;
            string output = "";
            int i = 0;
            while ((sr.Peek() != -1) && (!sup))
            {
                dati = sr.ReadLine().Split(',');
                if (dati[0] == CodArt)
                    if (!TrovaInOrdinato(trovati, i, dati[1]))
                    {
                        trovati[i++] = dati[1];
                        output += "\n - " + dati[1] + ": " + clsClienti.CercaNominativoCodice(fileCli, dati[1]);
                    }
                else if (string.Compare(dati[0], CodArt) > 0)
                    sup = true;
            }
            sr.Close();
            File.Copy("originalVendite.txt", fileVen, true);
            File.Delete("originalVendite.txt");
            if (output != "")
                MessageBox.Show("I clienti sono: " + output);
            else
                MessageBox.Show("Nessuno ha acquistato l'altricolo " + CodArt);
        }

        internal static void CercaClientinonArticolo(string fileVen, string fileCli, string CodArt)
        {
            Vendita[] Vendite = new Vendita[20];
            clsVendite.ordinaVenditeCodArt(Vendite, fileVen);
            StreamReader sr = new StreamReader(fileVen);
            string[] dati, trovati = new string[20];
            bool sup = false;
            string output = "";
            int i = 0;

            while ((sr.Peek() != -1) && (!sup))
            {
                dati = sr.ReadLine().Split(',');
                if (dati[0] == CodArt)
                    if (!TrovaInOrdinato(trovati, i, dati[1]))
                        trovati[i++] = dati[1];
                else if (string.Compare(dati[0], CodArt) > 0)
                    sup = true;
            }

            sr.Close();
            File.Copy("originalVendite.txt", fileVen, true);
            File.Delete("originalVendite.txt");
            sr = new StreamReader(fileCli);
            while (sr.Peek() != -1)
            {
                dati = sr.ReadLine().Split(',');
                if (!TrovaInOrdinato(trovati, i, dati[0]))
                    output += "\n - " + dati[0] + ": " + dati[1] + " " + dati[2];
            }
            if (output != "")
                MessageBox.Show("I clienti sono: " + output);
            else
                MessageBox.Show("Tutti hanno comprato " + CodArt);
        }

        internal static void CercaGiornoMaxIncassi(string fileVen, string fileArt)
        {
            Vendita[] vendite = new clsUtilities.Vendita[20];
            clsVendite.ordinaVenditeData(fileVen, vendite);
            StreamReader sr = new StreamReader(fileVen);
            string[] dati = sr.ReadLine().Split(',');
            string output = "";
            int cont = Convert.ToInt32(dati[2]), max = 0;
            DateTime pre = Convert.ToDateTime(dati[3]);
            while (sr.Peek() != -1)
            {
                dati = sr.ReadLine().Split(',');
                if (Convert.ToDateTime(dati[3]) != pre)
                {
                    if (cont > max)
                    {
                        output = "\n - " + pre.ToShortDateString() + ": " + cont.ToString() + "€";
                        max = cont;
                    }
                    else if (cont == max)
                        output += "\n - " + pre.ToShortDateString() + ": " + cont.ToString() + "€";
                    pre = Convert.ToDateTime(dati[3]);
                    cont = 0;
                }
                cont += Convert.ToInt32(dati[2]) * clsArticoli.CercaPrezzoArticolo(fileArt, dati[0]);
            }
            if (cont > max)
            {
                output = "\n - " + pre.ToShortDateString() + ": " + cont.ToString() + "€";
                max = cont;
            }
            else if (cont == max)
                output += "\n - " + pre.ToShortDateString() + ": " + cont.ToString() + "€";
            sr.Close();
            File.Copy("originalVendite.txt", fileVen, true);
            File.Delete("originalVendite.txt");
            MessageBox.Show("Lista dei giorni migliori : " + output);
        }

        internal static void CercaGiornoMaxVendite(string file)
        {
            Vendita[] vendite = new clsUtilities.Vendita[20];
            clsVendite.ordinaVenditeData(file, vendite);
            StreamReader sr = new StreamReader(file);
            string[] dati = sr.ReadLine().Split(',');
            string output = "";
            int cont = Convert.ToInt32(dati[2]), max = 0;
            DateTime pre = Convert.ToDateTime(dati[3]);
            while (sr.Peek() != -1)
            {
                dati = sr.ReadLine().Split(',');
                if (Convert.ToDateTime(dati[3]) != pre)
                {
                    if (cont > max)
                    {
                        output = "\n - " + pre.ToShortDateString() + ": " + cont.ToString();
                        max = cont;
                    }
                    else if (cont == max)
                        output += "\n - " + pre.ToShortDateString() + ": " + cont.ToString();
                    pre = Convert.ToDateTime(dati[3]);
                    cont = 0;
                }
                cont += Convert.ToInt32(dati[2]);
            }
            if (cont > max)
            {
                output = "\n - " + pre.ToShortDateString() + ": " + cont.ToString();
                max = cont;
            }
            else if (cont == max)
                output += "\n - " + pre.ToShortDateString() + ": " + cont.ToString();
            sr.Close();
            File.Copy("originalVendite.txt", file, true);
            File.Delete("originalVendite.txt");
            MessageBox.Show("Lista dei giorni migliori : " + output);
        }

        internal static void CercaArticoliTraDate(string fileVen, string fileArt, DateTime d1, DateTime d2)
        {
            Vendita[] vendite = new clsUtilities.Vendita[20];
            clsVendite.ordinaVenditeData(fileVen, vendite);
            StreamReader sr = new StreamReader(fileVen);
            string[] dati, Used = new string[20];
            string output = "";
            int i = 0;
            bool sup = false;
            while ((sr.Peek() != -1) && (!sup))
            {
                dati = sr.ReadLine().Split(',');
                if ((Convert.ToDateTime(dati[3]) > d2))
                {
                    sup = true;
                }
                else if ((Convert.ToDateTime(dati[3]) >= d1) && (!TrovaInOrdinato(Used, i, dati[0])))
                {
                    output += "\n - " + dati[0] + ": " + clsArticoli.cercaNomArt(fileArt, dati[0]);
                    Used[i++] = dati[0];
                }
            }
            sr.Close();
            File.Copy("originalVendite.txt", fileVen, true);
            File.Delete("originalVendite.txt");
            if (output != "")
                MessageBox.Show("Lista degli articoli venduti : " + output);
            else
                MessageBox.Show("Non sono stati venduti");
        }

        private static string CercaNomeFornCodForn(string file, string CodForn)
        {
            StreamReader sr = new StreamReader(file);
            string[] dato = sr.ReadLine().Split(',');
            while (dato[0] != CodForn)
                dato = sr.ReadLine().Split(',');
            sr.Close();
            return dato[1];
        }

        internal static void CercaVenditePostume(string fileVen, string fileArt, DateTime data)
        {
            Vendita[] vendite = new clsUtilities.Vendita[20];
            clsVendite.ordinaVenditeData(fileVen, vendite);
            StreamReader sr = new StreamReader(fileVen);
            string[] dati, Used = new string[20];
            string output = "";
            int i = 0;
            while (sr.Peek() != -1)
            {
                dati = sr.ReadLine().Split(',');
                if ((Convert.ToDateTime(dati[3]) >= data) && (!TrovaInOrdinato(Used, i, dati[0])))
                {
                    output += "\n - " + dati[0] + ": " + clsArticoli.cercaNomArt(fileArt, dati[0]);
                    Used[i++] = dati[0];
                }
            }
            sr.Close();
            File.Copy("originalVendite.txt", fileVen, true);
            File.Delete("originalVendite.txt");
            if (output != "")
                MessageBox.Show("Lista degli articoli venduti dopo il " + data.ToShortDateString() + ": " + output);
            else
                MessageBox.Show("Non sono stati venduti articoli dopo il " + data.ToShortDateString());
        }

        private static bool TrovaInOrdinato(string[] vet, int n, string x)
        {
            int i = 0;
            while ((i < n) && (vet[i] != x))
                i++;
            return vet[i] == x;
        }
    }
}
