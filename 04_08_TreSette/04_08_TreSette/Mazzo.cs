using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_08_TreSette
{
    class Mazzo
    {
        public List<Carta> Deck = new List<Carta>();
        private Random rnd = new Random();

        public Mazzo()
        {
            Deck.Clear();
            for (int i = 1; i <= 10; i++)
            {
                Deck.Add(new Carta("Cuore", i));
                Deck.Add(new Carta("Picche", i));
                Deck.Add(new Carta("Fiore", i));
                Deck.Add(new Carta("Quadri", i));
            }
        }

        public void AggiungiCarta(Carta nuova)
        {
            int i = 0;
            bool trovata = false;
            while(trovata = false && i < Deck.Count())
            {
                if (Deck[i].Stampa() == nuova.Stampa())
                    trovata = true;
                i++;
            }
            if (!trovata)
                Deck.Add(nuova);
        }

        public Carta DammiCarta(int index = 0)
        {
            Carta tolta = Deck[index];
            Deck.RemoveAt(index);
            return tolta;
        }

        public void Mescola()
        {
            int n = rnd.Next(100, 200);
            for (int i = 0; i < n; i++)
            {
                int pos1 = rnd.Next(0, Deck.Count()), pos2;
                do
                    pos2 = rnd.Next(0, Deck.Count());
                while (pos1 == pos2);
                Carta aus = Deck[pos1];
                Deck[pos1] = Deck[pos2];
                Deck[pos2] = aus;
            }
        }
    }
}
