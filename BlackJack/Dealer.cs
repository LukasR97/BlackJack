using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Dealer
    {
        public int Count { get; set; } = 0;

        public List<Card> Cards = new List<Card>();

        public int CalculatAndGetTheCount()
        {
            Count = 0;
            foreach (Card card in Cards)
            {
                Count = Count + card.Value;
            }

            int result = Count;

            return result;
        }
        public int CalculatAndGetTheCount(bool containsAce)
        {
            Count = 0;
            foreach (Card card in Cards)
            {
                Count = Count + card.Value;
            }

            if (containsAce && Count > 21)
            {
                foreach (Card card in Cards)
                {
                    if (card.Face == "A")
                    {
                        Count = Count - 10;
                    }
                }
                if (Count + 10 <= 21)
                {
                    Count = Count + 10;
                }
            }

            int result = Count;

            return result;
        }
    }
}
