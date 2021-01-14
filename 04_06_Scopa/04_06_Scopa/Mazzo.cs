using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_06_Scopa
{
    class Mazzo
    {
        private List<Carta> Deck = new List<Carta>();
        Random rnd = new Random();

        public Mazzo()
        {
            for (int i = 1; i <= 10; i++)
            {
                Deck.Add(new Carta("Bastoni", i));
                Deck.Add(new Carta("Spade", i));
                Deck.Add(new Carta("Coppe", i));
                Deck.Add(new Carta("Ori", i));
            }
        }

        public void Mescola()
        {
            int n = rnd.Next(100, 200);
            for (int i = 0; i < n; i++)
            {
                int pos1, pos2;
                pos1 = rnd.Next(0, Deck.Count());
                do
                    pos2 = rnd.Next(0, Deck.Count());
                while (pos2 == pos1);
                Carta aus = Deck[pos1];
                Deck[pos1] = Deck[pos2];
                Deck[pos2] = aus;
            }
        }

        public Carta Pesca()
        {
            Carta pescata = Deck[0];
            Deck.RemoveAt(0);
            return pescata;
        }

        public List<Carta> VediMazzo()
        {
            return Deck;
        }
    }
}
