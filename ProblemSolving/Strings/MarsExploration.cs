using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    static int marsExploration(string s)
    {
        int differentCount = 0;
        string SOS = "SOS";
        for (int i = 0; i < s.Length; i++)
        {
            if (SOS[i % 3] != s[i])
            {
                differentCount++;
            }
        }
        return differentCount;
    }

    static void Main(string[] args)
    {
        string s = Console.ReadLine();

        int result = marsExploration(s);

        Console.WriteLine(result);
    }
}
