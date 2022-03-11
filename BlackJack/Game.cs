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
            string b = "";
            string c = "";
            string d = "";
            string e = "";
            string f = "";
            int i = 0;
            foreach (var card in player.Cards)
            {
                a += $"| {player.Cards[i].Face}      |";
                b += $"|        |";
                c += $"|        |";
                d += $"|        |";
                e += $"|      {player.Cards[i].Face} |";
                f += $" -------- ";
                i++;
            }

            Console.WriteLine($"                                {f}");
            Console.WriteLine($"                                {a}");
            Console.WriteLine($"                                {b}");
            Console.WriteLine($"                                {c}");
            Console.WriteLine($"                                {d}");
            Console.WriteLine($"                                {e}");
            Console.WriteLine($"                                {f}");
        }

        public static void DisplayDealerCards(Dealer dealer)
        {
            string a = "";
            string b = "";
            string c = "";
            string d = "";
            string e = "";
            string f = "";
            int i = 0;
            foreach (var card in dealer.Cards)
            {
                a += $"| {dealer.Cards[i].Face}      |";
                b += $"|        |";
                c += $"|        |";
                d += $"|        |";
                e += $"|      {dealer.Cards[i].Face} |";
                f += $" -------- ";
                i++;
            }

            Console.WriteLine($"                                {f}");
            Console.WriteLine($"                                {a}");
            Console.WriteLine($"                                {b}");
            Console.WriteLine($"                                {c}");
            Console.WriteLine($"                                {d}");
            Console.WriteLine($"                                {e}");
            Console.WriteLine($"                                {f}");
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
            string? enteredValue;
            bool conversionIsSuccessful = false;
            Console.WriteLine($"You have {player.Chips} chips.");
            Console.WriteLine($"Place your bet!");

            while (!conversionIsSuccessful)
            {
                enteredValue = Console.ReadLine();

                try
                {
                    Convert.ToDecimal(enteredValue);
                    conversionIsSuccessful = true;
                    result = Convert.ToDecimal(enteredValue);
                }
                catch (Exception)
                {
                    Console.WriteLine("Value was not a number");
                    Console.WriteLine("Try again.");
                }
            }
            return result;
        }

        public static void DisplayBet(decimal betSize)
        {
            Console.WriteLine($"                              Placed bet: {betSize}");
        }

        public static bool ValidatePlayerBet(Player player, decimal betSize)
        {
            Console.Clear();
            bool result = false;

            if (betSize > player.Chips)
            {
                Console.WriteLine($"You have {player.Chips} and you are trying to bet {betSize}... come on bro :)");
                result = false;
            }
            else if(betSize == 0)
            {
                Console.WriteLine("You have to bet atleast 1 chip");
                result = false;
            }
            else
            {
                result = true;
            }

            return result;
        }
    }
}
