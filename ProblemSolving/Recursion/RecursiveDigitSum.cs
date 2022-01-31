using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    static int superDigit(string n, int k)
    {

        if (n.Length == 1)
        {
            return Convert.ToInt32(n);
        }
        else
        {
            long sum = 0;
            foreach (var item in n)
            {
                sum += long.Parse(item.ToString());
            }
            n = (sum * (k % 9)).ToString();
            return superDigit(n, 1);
        }
    }

    public static void Main(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        string n = firstMultipleInput[0];

        int k = Convert.ToInt32(firstMultipleInput[1]);
        int result = superDigit(n, k);

        Console.WriteLine(result);
    }
}
