using System;

public class Dice
{
    private Random random = new Random();

    public int Roll()
    {
        return random.Next(1, 7); // Generates a number between 1 and 6
    }

    public int[] RollMultiple(int count)
    {
        int[] results = new int[count];
        for (int i = 0; i < count; i++)
        {
            results[i] = Roll();
        }
        return results;
    }
}
