using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_03_ClasseSingleton
{
    class Singleton
    {
        private int val = 0;
        private static Singleton ind = null;

        private Singleton(int val)
        {
            this.val = val;
        }

        public static Singleton CreaSingleton(int val)
        {
            if (ind == null) //se non è mai stato creato l'oggetto ne crea uno
                ind = new Singleton(val);
            else
                ind.val = val;
            return ind;
        }

        public int GetValore()
        {
            return val;
        }
    }
}
