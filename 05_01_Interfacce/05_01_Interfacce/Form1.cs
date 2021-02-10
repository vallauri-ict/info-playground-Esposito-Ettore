using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_01_Interfacce
{
    public partial class Form1 : Form
    {
        int prog = 1;
        MyComponent disp;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            disp = new MyComponent(prog++);
        }

        private void btmConnetti_Click(object sender, EventArgs e)
        {
            disp.connetti("discarica");
        }

        private void btmDisconnetti_Click(object sender, EventArgs e)
        {
            disp.disconnetti("Cassonetto");
        }

        private void btmStatus_Click(object sender, EventArgs e)
        {
            disp.stato();
        }
    }
}
