﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_07_ClassiAbstract
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btmElenco_Click(object sender, EventArgs e)
        {
            ElencoStudenti elenco = new ElencoStudenti();
            MessageBox.Show(elenco.StampaElenco(), "Report"); 
        }
    }
}
