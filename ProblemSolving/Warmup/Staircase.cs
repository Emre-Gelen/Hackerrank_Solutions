using System;

public class Solution
{
    static void staircase(int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("".PadLeft(i + 1, '#').PadLeft(n, ' '));
        }
    }
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        staircase(n);
    }
}
