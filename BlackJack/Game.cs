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
            foreach (var card in player.Cards)
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

        public static Player GetPlayerChipCountFromUserInput()
        {
            int chips;

            Console.WriteLine("How many chips will you be playing?");
            var enteredValue = Console.ReadLine();
            try
            {
                Convert.ToInt32(enteredValue);
            }
            catch (Exception)
            {
                Console.WriteLine("Entered value is not a number.");
                return new Player(0);
            }

            chips = Convert.ToInt32(enteredValue);

            var result = new Player(chips);
            return result;
        }

        public static void DisplayPlayerChipCount(Player player)
        {
            Console.WriteLine($"                             Your chips - {player.Chips}");
        }
    }
}
