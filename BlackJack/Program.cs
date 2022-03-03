// See https://aka.ms/new-console-template for more information
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

Player player = new Player(1000);
Dealer dealer = new Dealer();

//game logic:
//Dealing phase:


//Card for player
player.Cards.Add(shoe.Deal());

//Card for dealer
dealer.Cards.Add(shoe.Deal());

//Card for player
player.Cards.Add(shoe.Deal());

Console.Clear();
Console.WriteLine("Welcome to BlackJack v.1.0");

Console.WriteLine($"                            Dealer is showing: {dealer.CalculatAndGetTheCount()}");
Console.WriteLine($"                                | {dealer.Cards[0].Face}  ||    |");
Console.WriteLine($"                                          ");
Console.WriteLine($"                                          ");
Console.WriteLine($"                                          ");
Console.WriteLine($"                                          ");
Console.WriteLine($"                               Your cards: {player.CalculatAndGetTheCount()}");
Console.WriteLine($"                                | {player.Cards[0].Face}  || {player.Cards[1].Face}  |");
Console.WriteLine("Would you like to hit ? y / n");
var entry = Console.ReadLine();

switch (entry)
{
    case "y":
        player.Cards.Add(shoe.Deal());
        Console.Clear();
        Console.WriteLine($"                            Dealer is showing: {dealer.CalculatAndGetTheCount()}");
        Console.WriteLine($"                                | {dealer.Cards[0].Face}  ||    |");
        Console.WriteLine($"                                          ");
        Console.WriteLine($"                                          ");
        Console.WriteLine($"                                          ");
        Console.WriteLine($"                                          ");
        Console.WriteLine($"                               Your cards: {player.CalculatAndGetTheCount()}");
        Console.WriteLine($"                                | {player.Cards[0].Face}  || {player.Cards[1].Face}  || {player.Cards[2].Face}  |");
        break;
}

// Question for another day, If or switch.