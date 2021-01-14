using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_06_Scopa
{
    class Giocatore : Mano
    {
        List<Carta> Prese = new List<Carta>();
        public string Nome;

        public Giocatore (string Nome)
        {
            Hand.RemoveRange(0, Hand.Count());
            Prese.RemoveRange(0, Prese.Count());
            this.Nome = Nome;
        }

        public List<Carta> LetturaPrese()
        {
            return Prese;
        }

        public void MettiPrese(Carta nuova)
        {
            Prese.Add(nuova);
        }
    }
}
