using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    static int sockMerchant(int n, List<int> ar)
    {
        int result = 0;
        ar.Sort();

        for (int i = 0; i < ar.Count - 1;)
        {
            if (ar[i] == ar[i + 1])
            {
                result++;
                i += 2;
                continue;
            }
            i++;
        }
        return result;
    }
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

        int result = sockMerchant(n, ar);

        Console.WriteLine(result);
    }
}
