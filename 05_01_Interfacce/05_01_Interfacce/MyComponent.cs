using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_01_Interfacce
{
    class MyComponent : IDispAggiuntivo
    {
        #region proprietà

        private int _id; 
        private bool _status;

        public int id { get => _id; set => _id = value; }

        public bool status => _status;

        #endregion

        public MyComponent(int id)
        {
            this.id = id;
            _status = false;
        }

        public void connetti(string s)
        {
            _status = true;
            MessageBox.Show("Connesso a " + s);
        }

        public void disconnetti(string s)
        {
            _status = false;
            MessageBox.Show("Disconnesso da " + s);
        }

        public void stato()
        {
            if(status)
                MessageBox.Show("Attualmente connesso con id " + id);
            else
                MessageBox.Show("Attualmente disconnesso");
        }
    }
}
