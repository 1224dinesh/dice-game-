// using System;
// using System.Diagnostics;

// public class Testing
// {
//     public void RunTests()
//     {
//         TestSevensOutGame();
//         TestThreeOrMoreGame();
//     }

//     private void TestSevensOutGame()
//     {
//         SevensOut sevensOut = new SevensOut();
//         Die die1 = new Die();
//         Die die2 = new Die();
//         int roll1 = die1.Roll();
//         int roll2 = die2.Roll();
//         int sum = roll1 + roll2;

//         // Check if the game correctly handles rolling a 7
//         if (sum == 7)
//         {
//             Debug.Assert(sevensOut.ShouldStop(sum), "The game should stop if 7 is rolled.");
//         }
//         else
//         {
//             Debug.Assert(!sevensOut.ShouldStop(sum), "The game should continue if the sum is not 7.");
//         }
//     }

//     private void TestThreeOrMoreGame()
//     {
//         ThreeOrMore threeOrMore = new ThreeOrMore();
        
//         // Assume you have a method to simulate one round of dice rolls
//         threeOrMore.PlayRound();  // This should simulate rolling all dice once and updating the score accordingly

//         // Assume a method to check the score after one round
//         // This is fictional and must be replaced with actual game logic checks
//         Debug.Assert(threeOrMore.GetCurrentScore() > 0, "Score should be updated after playing a round.");

//         // Further tests could be added to verify specific game mechanics, such as scoring for specific dice roll outcomes
//     }
// }
