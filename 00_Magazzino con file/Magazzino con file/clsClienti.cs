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
    class clsClienti
    {
        internal static void InserisciArticolo(DataGridView dgv, ref int n, string file, string CodCli, string Cogn, string Nom, string Città)
        {
            if((String.Compare(CodCli, dgv[0, n - 1].Value.ToString()) <= 0) || (CodCli == ""))
                MessageBox.Show("Il codice cliente non è valido");
            else if(Cogn == "")
                MessageBox.Show("Il cognome non è presente");
            else if(Nom == "")
                MessageBox.Show("Il nome non è presente");
            else
            {
                StreamWriter sw = new StreamWriter(file, true);
                string s = CodCli + "," + Cogn + "," + Nom + "," + Città;
                sw.WriteLine(s);
                sw.Close();
                string[] dati = s.Split(',');
                FormMain.CaricaRiga(dgv, n, 4, dati);
                n++;
            }
        }

        internal static void ModificaCliente(DataGridView dgv, string file)
        {
            string CodCli = Interaction.InputBox("Inserisci il codice del cliente da modificare: ", "Modifica");
            int pos = CercaClienteCodice(file, CodCli);
            if (pos != -1)
            {
                dgv.ClearSelection();
                dgv.Rows[pos].Selected = true;
                string cit = Interaction.InputBox("Inserisci la nuova città o lascia vuoto: ", "Modifica");
                if (cit != "")
                {
                    dgv[3, pos].Value = cit;
                    string newLine = dgv[0, pos].Value + "," + dgv[1, pos].Value + "," + dgv[2, pos].Value + "," + cit;
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
            }
            else
                MessageBox.Show("Cliente non esistente");
        }

        internal static int CercaClienteCodice(string file, string codCli)
        {
            StreamReader sr = new StreamReader(file);
            int i = 0;
            string s = sr.ReadLine().Split(',')[0];
            while ((sr.Peek() != -1) && (s != codCli))
            {
                s = sr.ReadLine().Split(',')[0];
                i++;
            }
            sr.Close();
            if (s == codCli)
                return i;
            else
                return -1;
        }

        internal static string CercaNominativoCodice(string file, string codCli)
        {
            StreamReader sr = new StreamReader(file);
            string[] dati = sr.ReadLine().Split(',');
            while (dati[0] != codCli)
                dati = sr.ReadLine().Split(',');
            sr.Close();
            return dati[1] + " " + dati[2];
        }
    }
}
