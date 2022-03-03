using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Shoe
    {
        private static Random rng = new Random();
        public List<Card> Cards = new List<Card>();
        private static int i = 0;

        public Card Deal()
        {
            Console.WriteLine($"Card dealt - {Cards[i].Face} value - {Cards[i].Value}");
            i++;

            return Cards[i];
        }

        public void AddCardToShoe(Card card)
        {
            Cards.Add(card);
        }

        public void CheckShoeContent()
        {
            foreach (Card card in Cards)
            {
                Console.WriteLine($"{card.Face}");
            }
        }

        public void ShuffleCards()
        {
            Cards = Cards.OrderBy(x => rng.Next()).ToList();
        }
    }
}
