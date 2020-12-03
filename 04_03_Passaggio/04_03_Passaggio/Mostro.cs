﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_03_Passaggio
{
    public class Mostro
    {
        public string nome;
        public Mostro() : this("Mostro")
        {

        }

        public Mostro(string nome)
        {
            this.nome = nome;
        }

        public void Rivela()
        {
            MessageBox.Show(nome);
        }
    }
}
