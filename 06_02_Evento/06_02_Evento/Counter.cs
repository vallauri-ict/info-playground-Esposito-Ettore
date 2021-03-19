using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_02_Evento
{
    public delegate void OverMaxEventHandler(object sender, OverMaxEventArgs e);

    class Counter
    {
        public event OverMaxEventHandler overMax;
        private int maxVal;
        public int cont = 0;

        public Counter(int n)
        {
            if (n > 10)
                throw new Exception("Valore massimo 10");
            else
                maxVal = n;
        }

        public void Increment()
        {
            cont++;
            if(cont >= maxVal)
            {
                OverMaxEventArgs e = new OverMaxEventArgs(maxVal);
                OnOverMax(this, e);
            }
        }

        private void OnOverMax(object sender, OverMaxEventArgs e)
        {
            if(overMax != null) // se overMax punta ad una funzione (se è stato gestito)
                overMax(sender, e);
        }
    }
}
