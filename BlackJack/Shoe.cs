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
            var dealtCard = new Card(Cards[i].Face, Cards[i].Value);
            
            Console.WriteLine($"Card dealt - {dealtCard.Face} value - {dealtCard.Value}");
            i++;

            return dealtCard;
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
