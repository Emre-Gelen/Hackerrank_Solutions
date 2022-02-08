using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    static string hackerrankInString(string s)
    {
        string hackerrank = "hackerrank";
        int letterCount = 0;

        for (int i = 0; i < s.Length && letterCount < hackerrank.Count(); i++)
        {
            if (s[i] == hackerrank[letterCount])
                letterCount++;
        }
        return letterCount == hackerrank.Count() ? "YES" : "NO";
    }
    static void Main(string[] args)
    {
        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s = Console.ReadLine();
            string result = hackerrankInString(s);
            Console.WriteLine(result);
        }
    }
}
