using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    static List<int> climbingLeaderboard(List<int> ranked, List<int> player)
    {
        List<int> uniqueRankedList = ranked.Distinct().ToList();
        List<int> result = new List<int>();
        int lastPlayerIndex = uniqueRankedList.Count - 1;

        foreach (int item in player)
        {
            int currentIndex = uniqueRankedList.Count + 1;
            for (int i = lastPlayerIndex; i > -1; i--)
            {
                if (item >= uniqueRankedList[i])
                {
                    currentIndex = i + 1;
                }
                else
                {
                    break;
                }
            }
            if (currentIndex > uniqueRankedList.Count)
                lastPlayerIndex = uniqueRankedList.Count - 1;
            else
                lastPlayerIndex = currentIndex - 1;

            result.Add(currentIndex);
        }
        return result;
    }
    static void Main(string[] args)
    {
        int rankedCount = Convert.ToInt32(Console.ReadLine().Trim());
        List<int> ranked = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(rankedTemp => Convert.ToInt32(rankedTemp)).ToList();

        int playerCount = Convert.ToInt32(Console.ReadLine().Trim());
        List<int> player = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(playerTemp => Convert.ToInt32(playerTemp)).ToList();

        List<int> result = climbingLeaderboard(ranked, player);

        Console.WriteLine(String.Join("\n", result));
    }
}
