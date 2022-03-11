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
            decimal chips;

            Console.WriteLine("How many chips will you be playing?");
            var enteredValue = Console.ReadLine();
            try
            {
                Convert.ToDecimal(enteredValue);
            }
            catch (Exception)
            {
                Console.WriteLine("Entered value is not a number.");
                return new Player(0);
            }

            chips = Convert.ToDecimal(enteredValue);

            var result = new Player(chips);
            return result;
        }

        public static void DisplayPlayerChipCount(Player player)
        {
            Console.WriteLine($"                                                      Your chips - {player.Chips}");
        }

        public static decimal AskPlayerToPlaceABet(Player player)
        {
            decimal result = 0;
            Console.WriteLine($"You have {player.Chips} chips.");
            Console.WriteLine($"Place your bet!");
            var enteredValue = Console.ReadLine();

            result = Convert.ToDecimal(enteredValue);

            return result;
        }

        public static void DisplayBet(decimal betSize)
        {
            Console.WriteLine($"                              Placed bet: {betSize}");
        }
    }
}
