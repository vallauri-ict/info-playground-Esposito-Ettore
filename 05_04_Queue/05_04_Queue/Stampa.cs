using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_04_Queue
{
    class Stampa
    {
        private Queue<string> coda = new Queue<string>();
        private static Stampa ind = null;

        private Stampa()
        {

        }

        public static Stampa CreaStampa()
        {
            if (ind == null)
                ind = new Stampa();
            return ind;
        }

        public void CreateElement(string text)
        {
            coda.Enqueue(text);
        }

        public string GetElement()
        {
            try
            {
                return coda.Dequeue();
            }
            catch(Exception)
            {
                return null;
            }
        }
    }
}
