// See https://aka.ms/new-console-template for more information
using BlackJack;

#region seed
Card ace = new Card("A", 11);
Card king = new Card("K", 10);
Card queen = new Card("Q", 10);
Card jack = new Card("J", 10);
Card ten = new Card("T", 10);
Card nine = new Card("9", 9);
Card eight = new Card("8", 8);
Card seven = new Card("7", 7);
Card six = new Card("6", 6);
Card five = new Card("5", 5);
Card four = new Card("4", 4);
Card three = new Card("3", 3);
Card deuce = new Card("2", 2);
Shoe shoe = new Shoe();
shoe.AddCardToShoe(ace);
shoe.AddCardToShoe(ace);
shoe.AddCardToShoe(ace);
shoe.AddCardToShoe(ace);

shoe.AddCardToShoe(ace);
shoe.AddCardToShoe(ace);
shoe.AddCardToShoe(ace);
shoe.AddCardToShoe(ace);

shoe.AddCardToShoe(ace);
shoe.AddCardToShoe(ace);
shoe.AddCardToShoe(ace);
shoe.AddCardToShoe(ace);

shoe.AddCardToShoe(ace);
shoe.AddCardToShoe(ace);
shoe.AddCardToShoe(ace);
shoe.AddCardToShoe(ace);

shoe.AddCardToShoe(king);
shoe.AddCardToShoe(king);
shoe.AddCardToShoe(king);
shoe.AddCardToShoe(king);

shoe.AddCardToShoe(king);
shoe.AddCardToShoe(king);
shoe.AddCardToShoe(king);
shoe.AddCardToShoe(king);

shoe.AddCardToShoe(king);
shoe.AddCardToShoe(king);
shoe.AddCardToShoe(king);
shoe.AddCardToShoe(king);

shoe.AddCardToShoe(king);
shoe.AddCardToShoe(king);
shoe.AddCardToShoe(king);
shoe.AddCardToShoe(king);

shoe.AddCardToShoe(queen);
shoe.AddCardToShoe(queen);
shoe.AddCardToShoe(queen);
shoe.AddCardToShoe(queen);

shoe.AddCardToShoe(queen);
shoe.AddCardToShoe(queen);
shoe.AddCardToShoe(queen);
shoe.AddCardToShoe(queen);

shoe.AddCardToShoe(queen);
shoe.AddCardToShoe(queen);
shoe.AddCardToShoe(queen);
shoe.AddCardToShoe(queen);

shoe.AddCardToShoe(queen);
shoe.AddCardToShoe(queen);
shoe.AddCardToShoe(queen);
shoe.AddCardToShoe(queen);

shoe.AddCardToShoe(jack);
shoe.AddCardToShoe(jack);
shoe.AddCardToShoe(jack);
shoe.AddCardToShoe(jack);

shoe.AddCardToShoe(jack);
shoe.AddCardToShoe(jack);
shoe.AddCardToShoe(jack);
shoe.AddCardToShoe(jack);

shoe.AddCardToShoe(jack);
shoe.AddCardToShoe(jack);
shoe.AddCardToShoe(jack);
shoe.AddCardToShoe(jack);

shoe.AddCardToShoe(jack);
shoe.AddCardToShoe(jack);
shoe.AddCardToShoe(jack);
shoe.AddCardToShoe(jack);

shoe.AddCardToShoe(ten);
shoe.AddCardToShoe(ten);
shoe.AddCardToShoe(ten);
shoe.AddCardToShoe(ten);

shoe.AddCardToShoe(ten);
shoe.AddCardToShoe(ten);
shoe.AddCardToShoe(ten);
shoe.AddCardToShoe(ten);

shoe.AddCardToShoe(ten);
shoe.AddCardToShoe(ten);
shoe.AddCardToShoe(ten);
shoe.AddCardToShoe(ten);

shoe.AddCardToShoe(ten);
shoe.AddCardToShoe(ten);
shoe.AddCardToShoe(ten);
shoe.AddCardToShoe(ten);

shoe.AddCardToShoe(nine);
shoe.AddCardToShoe(nine);
shoe.AddCardToShoe(nine);
shoe.AddCardToShoe(nine);

shoe.AddCardToShoe(nine);
shoe.AddCardToShoe(nine);
shoe.AddCardToShoe(nine);
shoe.AddCardToShoe(nine);

shoe.AddCardToShoe(nine);
shoe.AddCardToShoe(nine);
shoe.AddCardToShoe(nine);
shoe.AddCardToShoe(nine);

shoe.AddCardToShoe(nine);
shoe.AddCardToShoe(nine);
shoe.AddCardToShoe(nine);
shoe.AddCardToShoe(nine);

shoe.AddCardToShoe(eight);
shoe.AddCardToShoe(eight);
shoe.AddCardToShoe(eight);
shoe.AddCardToShoe(eight);

shoe.AddCardToShoe(eight);
shoe.AddCardToShoe(eight);
shoe.AddCardToShoe(eight);
shoe.AddCardToShoe(eight);

shoe.AddCardToShoe(eight);
shoe.AddCardToShoe(eight);
shoe.AddCardToShoe(eight);
shoe.AddCardToShoe(eight);

shoe.AddCardToShoe(eight);
shoe.AddCardToShoe(eight);
shoe.AddCardToShoe(eight);
shoe.AddCardToShoe(eight);

shoe.AddCardToShoe(seven);
shoe.AddCardToShoe(seven);
shoe.AddCardToShoe(seven);
shoe.AddCardToShoe(seven);

shoe.AddCardToShoe(seven);
shoe.AddCardToShoe(seven);
shoe.AddCardToShoe(seven);
shoe.AddCardToShoe(seven);

shoe.AddCardToShoe(seven);
shoe.AddCardToShoe(seven);
shoe.AddCardToShoe(seven);
shoe.AddCardToShoe(seven);

shoe.AddCardToShoe(seven);
shoe.AddCardToShoe(seven);
shoe.AddCardToShoe(seven);
shoe.AddCardToShoe(seven);

shoe.AddCardToShoe(six);
shoe.AddCardToShoe(six);
shoe.AddCardToShoe(six);
shoe.AddCardToShoe(six);

shoe.AddCardToShoe(six);
shoe.AddCardToShoe(six);
shoe.AddCardToShoe(six);
shoe.AddCardToShoe(six);

shoe.AddCardToShoe(six);
shoe.AddCardToShoe(six);
shoe.AddCardToShoe(six);
shoe.AddCardToShoe(six);

shoe.AddCardToShoe(six);
shoe.AddCardToShoe(six);
shoe.AddCardToShoe(six);
shoe.AddCardToShoe(six);

shoe.AddCardToShoe(five);
shoe.AddCardToShoe(five);
shoe.AddCardToShoe(five);
shoe.AddCardToShoe(five);

shoe.AddCardToShoe(five);
shoe.AddCardToShoe(five);
shoe.AddCardToShoe(five);
shoe.AddCardToShoe(five);

shoe.AddCardToShoe(five);
shoe.AddCardToShoe(five);
shoe.AddCardToShoe(five);
shoe.AddCardToShoe(five);

shoe.AddCardToShoe(five);
shoe.AddCardToShoe(five);
shoe.AddCardToShoe(five);
shoe.AddCardToShoe(five);

shoe.AddCardToShoe(four);
shoe.AddCardToShoe(four);
shoe.AddCardToShoe(four);
shoe.AddCardToShoe(four);

shoe.AddCardToShoe(four);
shoe.AddCardToShoe(four);
shoe.AddCardToShoe(four);
shoe.AddCardToShoe(four);

shoe.AddCardToShoe(four);
shoe.AddCardToShoe(four);
shoe.AddCardToShoe(four);
shoe.AddCardToShoe(four);

shoe.AddCardToShoe(four);
shoe.AddCardToShoe(four);
shoe.AddCardToShoe(four);
shoe.AddCardToShoe(four);

shoe.AddCardToShoe(three);
shoe.AddCardToShoe(three);
shoe.AddCardToShoe(three);
shoe.AddCardToShoe(three);

shoe.AddCardToShoe(three);
shoe.AddCardToShoe(three);
shoe.AddCardToShoe(three);
shoe.AddCardToShoe(three);

shoe.AddCardToShoe(three);
shoe.AddCardToShoe(three);
shoe.AddCardToShoe(three);
shoe.AddCardToShoe(three);

shoe.AddCardToShoe(deuce);
shoe.AddCardToShoe(deuce);
shoe.AddCardToShoe(deuce);
shoe.AddCardToShoe(deuce);

shoe.AddCardToShoe(deuce);
shoe.AddCardToShoe(deuce);
shoe.AddCardToShoe(deuce);
shoe.AddCardToShoe(deuce);

shoe.AddCardToShoe(deuce);
shoe.AddCardToShoe(deuce);
shoe.AddCardToShoe(deuce);
shoe.AddCardToShoe(deuce);

shoe.AddCardToShoe(deuce);
shoe.AddCardToShoe(deuce);
shoe.AddCardToShoe(deuce);
shoe.AddCardToShoe(deuce);
#endregion

shoe.ShuffleCards();
Console.WriteLine("                         Welcome to BlackJack v.1.0");

Player player = Game.GetPlayerChipCountFromUserInput();

if (player.Chips == 0)
{
    while (player.Chips == 0)
    {
        Console.WriteLine("Try again.");
        player = Game.GetPlayerChipCountFromUserInput();
    }
}

Dealer dealer = new Dealer();

//game logic:
//Dealing phase:

PlayAHand();

void PlayAHand()
{
    Console.Clear();
    if (player.Chips <= 0)
    {
        Console.WriteLine("I'm sorry, but you're out of chips, thanks for playing! :)");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
        return;
    }

    player.Cards.Clear();
    dealer.Cards.Clear();
    int dealerResult;
    int playerResult;
    decimal betSize;

    bool playersTurn = true;
    bool playerBusted = false;
    bool dealerBusted = false;
    bool playerHitBlackJack = false;
    bool playerBetValidation = false;

    string? entry;

    betSize = Game.AskPlayerToPlaceABet(player);
    playerBetValidation = Game.ValidatePlayerBet(player, betSize);

    while (!playerBetValidation)
    {
        Console.WriteLine("Try again...");
        betSize = Game.AskPlayerToPlaceABet(player);
        playerBetValidation = Game.ValidatePlayerBet(player, betSize);
    }

    player.Chips = player.Chips - betSize;

    //Card for player
    player.Cards.Add(shoe.Deal());

    //Card for dealer
    dealer.Cards.Add(shoe.Deal());

    //Card for player
    player.Cards.Add(shoe.Deal());

    Console.Clear();
    Console.WriteLine($"                            Dealer is showing: {dealer.CalculatAndGetTheCount(dealer.Cards.Any(x => x.Face == "A"))}");
    Game.DisplayDealerCards(dealer);
    Console.WriteLine($"                                          ");
    Console.WriteLine($"                                          ");
    Game.DisplayBet(betSize);
    Console.WriteLine($"                                          ");
    Console.WriteLine($"                                          ");
    Console.WriteLine($"                               Your cards: {player.CalculatAndGetTheCount(player.Cards.Any(x => x.Face == "A"))}");
    Game.DisplayPlayerCards(player);
    Game.DisplayPlayerChipCount(player);


    if (player.CalculatAndGetTheCount(player.Cards.Any(x => x.Face == "A")) == 21)
    {
        Console.WriteLine("                                 BLACKJACK!!!");
        playersTurn = false;
        dealerResult = dealer.CalculatAndGetTheCount(dealer.Cards.Any(x => x.Face == "A"));
        playerResult = player.CalculatAndGetTheCount(player.Cards.Any(x => x.Face == "A"));
        playerHitBlackJack = true;
        GameResult(dealerResult, playerResult, playerBusted, dealerBusted, betSize, player, playerHitBlackJack);
    }
    //Player drawing
    while (player.CalculatAndGetTheCount(player.Cards.Any(x => x.Face == "A")) < 21 && playersTurn)
    {
        Console.WriteLine("Would you like to hit? y/n, d - double down");
        entry = Console.ReadLine();
        switch (entry)
        {
            case "y":
                Console.Clear();
                player.Cards.Add(shoe.Deal());
                Console.WriteLine($"                            Dealer is showing: {dealer.CalculatAndGetTheCount(dealer.Cards.Any(x => x.Face == "A"))}");
                Game.DisplayDealerCards(dealer);
                Console.WriteLine($"                                          ");
                Console.WriteLine($"                                          ");
                Game.DisplayBet(betSize);
                Console.WriteLine($"                                          ");
                Console.WriteLine($"                                          ");
                Console.WriteLine($"                               Your cards: {player.CalculatAndGetTheCount(player.Cards.Any(x => x.Face == "A"))}");
                Game.DisplayPlayerCards(player);
                Game.DisplayPlayerChipCount(player);
                if (player.CalculatAndGetTheCount(player.Cards.Any(x => x.Face == "A")) > 21) { playerBusted = true; playersTurn = false; }
                break;

            case "n":
                playersTurn = false;
                break;

            case "d":
                Console.Clear();
                player.Cards.Add(shoe.Deal());
                Console.WriteLine($"                            Dealer is showing: {dealer.CalculatAndGetTheCount(dealer.Cards.Any(x => x.Face == "A"))}");
                Game.DisplayDealerCards(dealer);
                Console.WriteLine($"                                          ");
                Console.WriteLine($"                                          ");
                Game.DisplayBet(betSize);
                Console.WriteLine($"                                          ");
                Console.WriteLine($"                                          ");
                Console.WriteLine($"                               Your cards: {player.CalculatAndGetTheCount(player.Cards.Any(x => x.Face == "A"))}");
                Game.DisplayPlayerCards(player);
                Game.DisplayPlayerChipCount(player);
                if (player.CalculatAndGetTheCount(player.Cards.Any(x => x.Face == "A")) > 21) { playerBusted = true; playersTurn = false; }
                if(player.Chips - betSize < 0)
                {
                    Console.WriteLine("Not enough chips to double your bet.");
                }
                else
                {
                    player.Chips = player.Chips - betSize;
                    betSize = betSize * 2;
                    playersTurn = false;
                    Thread.Sleep(1000);
                }
                break;

        }
    }

    if (playerBusted)
    {
        dealerResult = dealer.CalculatAndGetTheCount(dealer.Cards.Any(x => x.Face == "A"));
        playerResult = player.CalculatAndGetTheCount(player.Cards.Any(x => x.Face == "A"));
        GameResult(dealerResult, playerResult, playerBusted, dealerBusted, betSize, player, playerHitBlackJack);
    }
    //Dealer drawing
    while (dealer.CalculatAndGetTheCount(dealer.Cards.Any(x => x.Face == "A")) <= 16 && !playerBusted)
    {
        Console.Clear();
        dealer.Cards.Add(shoe.Deal());
        Console.WriteLine($"                            Dealer is showing: {dealer.CalculatAndGetTheCount(dealer.Cards.Any(x => x.Face == "A"))}");
        Game.DisplayDealerCards(dealer);
        Console.WriteLine($"                                          ");
        Console.WriteLine($"                                          ");
        Game.DisplayBet(betSize);
        Console.WriteLine($"                                          ");
        Console.WriteLine($"                                          ");
        Console.WriteLine($"                               Your cards: {player.CalculatAndGetTheCount(player.Cards.Any(x => x.Face == "A"))}");
        Game.DisplayPlayerCards(player);
        Game.DisplayPlayerChipCount(player);
        if (dealer.CalculatAndGetTheCount(dealer.Cards.Any(x => x.Face == "A")) > 21) { dealerBusted = true; }
        Thread.Sleep(1000);
    }

    if (!playerBusted)
    {
        dealerResult = dealer.CalculatAndGetTheCount(dealer.Cards.Any(x => x.Face == "A"));
        playerResult = player.CalculatAndGetTheCount(player.Cards.Any(x => x.Face == "A"));

        GameResult(dealerResult, playerResult, playerBusted, dealerBusted, betSize, player, playerHitBlackJack);
    }

}

void GameResult(int dealerResult, int playerResult, bool playerBusted, bool dealerBusted, decimal betSize, Player player, bool playerHitBlackJack)
{
    if (playerBusted)
    {
        Console.WriteLine($"                               YOU BUSTED! You lost - {betSize} chips");
        //player.Chips = player.Chips - betSize;
    }
    else if (dealerBusted)
    {
        Console.WriteLine($"                         Dealer busts! YOU WIN - {betSize * 2} chips!");
        player.Chips = player.Chips + (betSize * 2);

    }
    else if (dealerResult > playerResult)
    {
        Console.WriteLine($"                               Dealer WINS! You lost - {betSize} chips");
        //player.Chips = player.Chips - betSize;
    }
    else if (playerHitBlackJack)
    {
        Console.WriteLine($"                                YOU HIT BLACKJACK! YOU WIN - {(betSize * 2) + (betSize / 2)}");
        player.Chips = player.Chips + (betSize * 2) + (betSize / 2);
    }
    else if (dealerResult < playerResult)
    {
        Console.WriteLine($"                                 YOU WIN - {betSize * 2} chips!");
        player.Chips = player.Chips + (betSize * 2);
    }
    else if (dealerResult == playerResult)
    {
        Console.WriteLine($"                                  PUSH! You got back your {betSize} chips!");
        player.Chips = player.Chips + betSize;
    }

    Console.WriteLine("Would you like to play another hand? y/n");
    var entry = Console.ReadLine();

    switch (entry)
    {
        case "y":
            PlayAHand();
            break;

        case "n":
            Console.WriteLine("Thank you for playing, the game will close in 3 seconds");
            Thread.Sleep(3000);
            Environment.Exit(0);
            break;

        default:
            PlayAHand();
            break;
    }
    
}