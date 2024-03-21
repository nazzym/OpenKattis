using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Read the initial inputs: number of contests and number of contestants
        string[] firstLine = Console.ReadLine().Split();
        int n = int.Parse(firstLine[0]); // Number of contests
        int m = int.Parse(firstLine[1]); // Number of contestants

        // Array to store the maximum possible scores of each contestant
        int[] maxScores = new int[m];

        // Read your scores and calculate your maximum possible aggregate score
        int[] yourScores = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int yourMaxScore = yourScores.OrderByDescending(score => score).Take(4).Sum(); // Your aggregate score

        // Read other contestants' scores and calculate their potential max scores after the last contest
        for (int i = 1; i < m; i++)
        {
            int[] scores = Console.ReadLine().Split().Select(int.Parse).ToArray();
            // Calculate max possible score for each contestant by assuming they could score 101 in the last contest
            int maxPossibleScore = scores.OrderByDescending(score => score).Take(3).Sum() + 101;
            maxScores[i] = maxPossibleScore;
        }

        // Determine your worst possible rank by comparing your score with others' maximum possible scores
        int worstRank = 1; // Start from 1, which means you are currently the top
        foreach (int score in maxScores)
        {
            if (score > yourMaxScore)
            {
                worstRank++; // Increase your rank if someone has a potential to score more than you
            }
        }

        // Print out the worst possible rank
        Console.WriteLine(worstRank);
    }
}
