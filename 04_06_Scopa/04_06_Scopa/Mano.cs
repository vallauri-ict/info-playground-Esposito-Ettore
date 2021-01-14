using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_06_Scopa
{
    class Mano
    {
        protected List<Carta> Hand = new List<Carta>();

        public Mano()
        {
            Hand.RemoveRange(0, Hand.Count());
        }

        public List<Carta> Lettura()
        {
            return Hand;
        }

        public Carta Gioca(int index)
        {
            Carta giocata = Hand[index];
            Hand.RemoveAt(index);
            return giocata;
        }

        public void Pesca(Carta nuova)
        {
            Hand.Add(nuova);
        }
    }
}
