using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    static int simpleArraySum(List<int> ar)
    {
        int result = 0;
        foreach (int item in ar)
        {
            result += item;
        }
        return result;
    }
    static void Main(string[] args)
    {
        int arCount = Convert.ToInt32(Console.ReadLine().Trim());
        List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

        int result = simpleArraySum(ar);

        Console.WriteLine(result);
    }
}
