using System;

public class ThreeOrMore
{
    private Dice dice = new Dice();

    public void PlayGame(Player player1, Player player2)
    {
        // Assume player1 is always human and player2 is either human or computer.
        Player currentPlayer = player1;
        bool playerOneTurn = true; // Start with player1's turn.

        while (player1.Score < 20 && player2.Score < 20)
        {
            Console.WriteLine($"{currentPlayer.Name}'s turn!");

            // Check if the current player is a computer.
            if (!currentPlayer.IsComputer)
            {
                Console.WriteLine("Press any key to roll the dice...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Computer is rolling the dice automatically...");
            }

            // Rolling the dice
            int[] rolls = dice.RollMultiple(5);
            Console.WriteLine($"Rolled: {string.Join(", ", rolls)}");

            // Analyzing the rolls for scoring
            int[] counts = new int[7]; // Array to count occurrences of each die face (1-6)
            foreach (var roll in rolls)
            {
                counts[roll]++;
            }

            // Scoring based on counts of dice faces
            for (int i = 1; i < counts.Length; i++)
            {
                if (counts[i] >= 3) // Scoring starts from three of a kind
                {
                    int points = counts[i] == 3 ? 3 : counts[i] == 4 ? 6 : 12;
                    currentPlayer.Score += points;
                    Console.WriteLine($"Scored {points} points for {counts[i]} of a kind!");
                    break;
                }
            }

            Console.WriteLine($"Current score: {currentPlayer.Score}");

            // Switch turns
            playerOneTurn = !playerOneTurn;
            currentPlayer = playerOneTurn ? player1 : player2;
        }

        // Announcing the game result
        Console.WriteLine("Game over.");
        Console.WriteLine($"{player1.Name}'s final score: {player1.Score}");
        Console.WriteLine($"{player2.Name}'s final score: {player2.Score}");
    }
}
