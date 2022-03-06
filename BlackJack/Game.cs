using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Game
    {
        public static void DisplayPlayerCards(Player player)
        {
            string a = "";
            int i = 0;
            foreach(var card in player.Cards)
            {
                a += $"| {player.Cards[i].Face}  |";
                i++;
            }

            Console.WriteLine($"                                {a}");
        }

        public static void DisplayDealerCards(Dealer dealer)
        {
            string a = "";
            int i = 0;
            foreach (var card in dealer.Cards)
            {
                a += $"| {dealer.Cards[i].Face}  |";
                i++;
            }

            Console.WriteLine($"                                {a}");
        }
    }
}
