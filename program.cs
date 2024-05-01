using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Welcome to the Dice Games!");
        Console.WriteLine("Enter your name:");
        string playerName = Console.ReadLine();

        Console.WriteLine("Which game would you like to play?");
        Console.WriteLine("1. Sevens Out");
        Console.WriteLine("2. Three Or More");
        string gameChoice = Console.ReadLine();

        Console.WriteLine("Do you want to play against another player or the computer?");
        Console.WriteLine("1. Another Player");
        Console.WriteLine("2. Computer");
        string opponentType = Console.ReadLine();

        Player player1 = new Player(playerName);
        Player player2;

        if (opponentType == "2")
        {
            player2 = new Player("Computer", true);
        }
        else
        {
            Console.WriteLine("Enter second player's name:");
            string player2Name = Console.ReadLine();
            player2 = new Player(player2Name);
        }

        if (gameChoice == "1")
        {
            SevensOut sevensOut = new SevensOut();
            sevensOut.PlayGame(player1, player2);
        }
        else if (gameChoice == "2")
        {
            ThreeOrMore threeOrMore = new ThreeOrMore();
            threeOrMore.PlayGame(player1, player2);
        }
    }
}
