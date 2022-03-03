using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Player
    {
        public int Chips { get; set; }
        public int Count { get; set; } = 0;
        
        public List<Card> Cards = new List<Card>();

        public Player(int chips)
        {
            Chips = chips; 
        }

        public int CalculatAndGetTheCount()
        {
            Count = 0;
            foreach(Card card in Cards)
            {
                Count = Count + card.Value;
            }

            int result = Count;

            return result;
        }
    }
}
