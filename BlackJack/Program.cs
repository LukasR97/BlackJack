﻿// See https://aka.ms/new-console-template for more information
using BlackJack;

#region seed
Card ace = new Card("A", 11);
Card king = new Card("K", 10);
Card queen = new Card("Q", 10);
Card jack = new Card("J", 10);
Card ten = new Card("10", 10);
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

//shoe.AddCardToShoe(queen);
//shoe.AddCardToShoe(queen);
//shoe.AddCardToShoe(queen);
//shoe.AddCardToShoe(queen);

//shoe.AddCardToShoe(queen);
//shoe.AddCardToShoe(queen);
//shoe.AddCardToShoe(queen);
//shoe.AddCardToShoe(queen);

//shoe.AddCardToShoe(queen);
//shoe.AddCardToShoe(queen);
//shoe.AddCardToShoe(queen);
//shoe.AddCardToShoe(queen);

//shoe.AddCardToShoe(queen);
//shoe.AddCardToShoe(queen);
//shoe.AddCardToShoe(queen);
//shoe.AddCardToShoe(queen);

//shoe.AddCardToShoe(jack);
//shoe.AddCardToShoe(jack);
//shoe.AddCardToShoe(jack);
//shoe.AddCardToShoe(jack);

//shoe.AddCardToShoe(jack);
//shoe.AddCardToShoe(jack);
//shoe.AddCardToShoe(jack);
//shoe.AddCardToShoe(jack);

//shoe.AddCardToShoe(jack);
//shoe.AddCardToShoe(jack);
//shoe.AddCardToShoe(jack);
//shoe.AddCardToShoe(jack);

//shoe.AddCardToShoe(jack);
//shoe.AddCardToShoe(jack);
//shoe.AddCardToShoe(jack);
//shoe.AddCardToShoe(jack);

//shoe.AddCardToShoe(ten);
//shoe.AddCardToShoe(ten);
//shoe.AddCardToShoe(ten);
//shoe.AddCardToShoe(ten);

//shoe.AddCardToShoe(ten);
//shoe.AddCardToShoe(ten);
//shoe.AddCardToShoe(ten);
//shoe.AddCardToShoe(ten);

//shoe.AddCardToShoe(ten);
//shoe.AddCardToShoe(ten);
//shoe.AddCardToShoe(ten);
//shoe.AddCardToShoe(ten);

//shoe.AddCardToShoe(ten);
//shoe.AddCardToShoe(ten);
//shoe.AddCardToShoe(ten);
//shoe.AddCardToShoe(ten);

//shoe.AddCardToShoe(nine);
//shoe.AddCardToShoe(nine);
//shoe.AddCardToShoe(nine);
//shoe.AddCardToShoe(nine);

//shoe.AddCardToShoe(nine);
//shoe.AddCardToShoe(nine);
//shoe.AddCardToShoe(nine);
//shoe.AddCardToShoe(nine);

//shoe.AddCardToShoe(nine);
//shoe.AddCardToShoe(nine);
//shoe.AddCardToShoe(nine);
//shoe.AddCardToShoe(nine);

//shoe.AddCardToShoe(nine);
//shoe.AddCardToShoe(nine);
//shoe.AddCardToShoe(nine);
//shoe.AddCardToShoe(nine);

//shoe.AddCardToShoe(eight);
//shoe.AddCardToShoe(eight);
//shoe.AddCardToShoe(eight);
//shoe.AddCardToShoe(eight);

//shoe.AddCardToShoe(eight);
//shoe.AddCardToShoe(eight);
//shoe.AddCardToShoe(eight);
//shoe.AddCardToShoe(eight);

//shoe.AddCardToShoe(eight);
//shoe.AddCardToShoe(eight);
//shoe.AddCardToShoe(eight);
//shoe.AddCardToShoe(eight);

//shoe.AddCardToShoe(eight);
//shoe.AddCardToShoe(eight);
//shoe.AddCardToShoe(eight);
//shoe.AddCardToShoe(eight);

//shoe.AddCardToShoe(seven);
//shoe.AddCardToShoe(seven);
//shoe.AddCardToShoe(seven);
//shoe.AddCardToShoe(seven);

//shoe.AddCardToShoe(seven);
//shoe.AddCardToShoe(seven);
//shoe.AddCardToShoe(seven);
//shoe.AddCardToShoe(seven);

//shoe.AddCardToShoe(seven);
//shoe.AddCardToShoe(seven);
//shoe.AddCardToShoe(seven);
//shoe.AddCardToShoe(seven);

//shoe.AddCardToShoe(seven);
//shoe.AddCardToShoe(seven);
//shoe.AddCardToShoe(seven);
//shoe.AddCardToShoe(seven);

//shoe.AddCardToShoe(six);
//shoe.AddCardToShoe(six);
//shoe.AddCardToShoe(six);
//shoe.AddCardToShoe(six);

//shoe.AddCardToShoe(six);
//shoe.AddCardToShoe(six);
//shoe.AddCardToShoe(six);
//shoe.AddCardToShoe(six);

//shoe.AddCardToShoe(six);
//shoe.AddCardToShoe(six);
//shoe.AddCardToShoe(six);
//shoe.AddCardToShoe(six);

//shoe.AddCardToShoe(six);
//shoe.AddCardToShoe(six);
//shoe.AddCardToShoe(six);
//shoe.AddCardToShoe(six);

//shoe.AddCardToShoe(five);
//shoe.AddCardToShoe(five);
//shoe.AddCardToShoe(five);
//shoe.AddCardToShoe(five);

//shoe.AddCardToShoe(five);
//shoe.AddCardToShoe(five);
//shoe.AddCardToShoe(five);
//shoe.AddCardToShoe(five);

//shoe.AddCardToShoe(five);
//shoe.AddCardToShoe(five);
//shoe.AddCardToShoe(five);
//shoe.AddCardToShoe(five);

//shoe.AddCardToShoe(five);
//shoe.AddCardToShoe(five);
//shoe.AddCardToShoe(five);
//shoe.AddCardToShoe(five);

//shoe.AddCardToShoe(four);
//shoe.AddCardToShoe(four);
//shoe.AddCardToShoe(four);
//shoe.AddCardToShoe(four);

//shoe.AddCardToShoe(four);
//shoe.AddCardToShoe(four);
//shoe.AddCardToShoe(four);
//shoe.AddCardToShoe(four);

//shoe.AddCardToShoe(four);
//shoe.AddCardToShoe(four);
//shoe.AddCardToShoe(four);
//shoe.AddCardToShoe(four);

//shoe.AddCardToShoe(four);
//shoe.AddCardToShoe(four);
//shoe.AddCardToShoe(four);
//shoe.AddCardToShoe(four);

//shoe.AddCardToShoe(three);
//shoe.AddCardToShoe(three);
//shoe.AddCardToShoe(three);
//shoe.AddCardToShoe(three);

//shoe.AddCardToShoe(three);
//shoe.AddCardToShoe(three);
//shoe.AddCardToShoe(three);
//shoe.AddCardToShoe(three);

//shoe.AddCardToShoe(three);
//shoe.AddCardToShoe(three);
//shoe.AddCardToShoe(three);
//shoe.AddCardToShoe(three);

//shoe.AddCardToShoe(deuce);
//shoe.AddCardToShoe(deuce);
//shoe.AddCardToShoe(deuce);
//shoe.AddCardToShoe(deuce);

//shoe.AddCardToShoe(deuce);
//shoe.AddCardToShoe(deuce);
//shoe.AddCardToShoe(deuce);
//shoe.AddCardToShoe(deuce);

//shoe.AddCardToShoe(deuce);
//shoe.AddCardToShoe(deuce);
//shoe.AddCardToShoe(deuce);
//shoe.AddCardToShoe(deuce);

//shoe.AddCardToShoe(deuce);
//shoe.AddCardToShoe(deuce);
//shoe.AddCardToShoe(deuce);
//shoe.AddCardToShoe(deuce);
#endregion

shoe.ShuffleCards();

Player player = new Player(1000);
Dealer dealer = new Dealer();

//game logic:
//Dealing phase:

PlayAHand();

void PlayAHand()
{
    player.Cards.Clear();
    dealer.Cards.Clear();
    int dealerResult;
    int playerResult;

    bool playersTurn = true;
    bool playerBusted = false;
    bool dealerBusted = false;

    string? entry;

    //Card for player
    player.Cards.Add(shoe.Deal());

    //Card for dealer
    dealer.Cards.Add(shoe.Deal());

    //Card for player
    player.Cards.Add(shoe.Deal());

    Console.Clear();
    Console.WriteLine("Welcome to BlackJack v.1.0");
    Console.WriteLine($"                            Dealer is showing: {dealer.CalculatAndGetTheCount(dealer.Cards.Any(x => x.Face == "A"))}");
    Game.DisplayDealerCards(dealer);
    Console.WriteLine($"                                          ");
    Console.WriteLine($"                                          ");
    Console.WriteLine($"                                          ");
    Console.WriteLine($"                                          ");
    Console.WriteLine($"                               Your cards: {player.CalculatAndGetTheCount(player.Cards.Any(x => x.Face == "A"))}");
    Game.DisplayPlayerCards(player);

    if (player.CalculatAndGetTheCount(player.Cards.Any(x => x.Face == "A")) == 21)
    {
        Console.WriteLine("                                 BLACKJACK!!!");
        playersTurn = false;
        dealerResult = dealer.CalculatAndGetTheCount(dealer.Cards.Any(x => x.Face == "A"));
        playerResult = player.CalculatAndGetTheCount(player.Cards.Any(x => x.Face == "A"));
        GameResult(dealerResult, playerResult, playerBusted, dealerBusted);
    }

    while (player.CalculatAndGetTheCount(player.Cards.Any(x => x.Face == "A")) < 21 && playersTurn)
    {
        Console.WriteLine("Would you like to hit? y/n");
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
                Console.WriteLine($"                                          ");
                Console.WriteLine($"                                          ");
                Console.WriteLine($"                               Your cards: {player.CalculatAndGetTheCount(player.Cards.Any(x => x.Face == "A"))}");
                Game.DisplayPlayerCards(player);
                if (player.CalculatAndGetTheCount(player.Cards.Any(x => x.Face == "A")) > 21) { playerBusted = true; playersTurn = false; }
                break;

            case "n":
                playersTurn = false;
                break;
        }
    }

    if (playerBusted)
    {
        dealerResult = dealer.CalculatAndGetTheCount(dealer.Cards.Any(x => x.Face == "A"));
        playerResult = player.CalculatAndGetTheCount(player.Cards.Any(x => x.Face == "A"));
        GameResult(dealerResult, playerResult, playerBusted, dealerBusted);
    }

    while (dealer.CalculatAndGetTheCount(dealer.Cards.Any(x => x.Face == "A")) <= 16 && !playerBusted)
    {
        Console.Clear();
        dealer.Cards.Add(shoe.Deal());
        Console.WriteLine($"                            Dealer is showing: {dealer.CalculatAndGetTheCount(dealer.Cards.Any(x => x.Face == "A"))}");
        Game.DisplayDealerCards(dealer);
        Console.WriteLine($"                                          ");
        Console.WriteLine($"                                          ");
        Console.WriteLine($"                                          ");
        Console.WriteLine($"                                          ");
        Console.WriteLine($"                               Your cards: {player.CalculatAndGetTheCount(player.Cards.Any(x => x.Face == "A"))}");
        Game.DisplayPlayerCards(player);
        if (dealer.CalculatAndGetTheCount(dealer.Cards.Any(x => x.Face == "A")) > 21) { dealerBusted = true; }
        Console.WriteLine("Press any key to continue the game...");
        Console.ReadLine();
    }

    if (!playerBusted)
    {
        dealerResult = dealer.CalculatAndGetTheCount(dealer.Cards.Any(x => x.Face == "A"));
        playerResult = player.CalculatAndGetTheCount(player.Cards.Any(x => x.Face == "A"));

        GameResult(dealerResult, playerResult, playerBusted, dealerBusted);
    }
    
}

void GameResult(int dealerResult, int playerResult, bool playerBusted, bool dealerBusted)
{
    if (playerBusted)
    {
        Console.WriteLine("                               YOU BUSTED!");
    }else if (dealerBusted)
    {
        Console.WriteLine("                         Dealer busts! YOU WIN!");
    }
    else if (dealerResult > playerResult)
    {
        Console.WriteLine("                               Dealer WINS!");
    }
    else if (dealerResult < playerResult) 
    {
        Console.WriteLine("                                 YOU WIN!");
    }else if( dealerResult == playerResult)
    {
        Console.WriteLine("                                  PUSH!");
    }

    Console.WriteLine("Would you like to play another hand? y/n");
    var entry = Console.ReadLine();
    if(entry == "y")
    {
        PlayAHand();
    }
}