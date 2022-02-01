using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    static void plusMinus(List<int> arr)
    {
        List<float> result = new List<float>() { 0, 0, 0 };
        foreach (var item in arr)
        {
            if (item > 0)
                result[0] += 1;
            else if (item < 0)
                result[1] += 1;
            else
                result[2] += 1;
        }

        Console.WriteLine(string.Format("{0:0.000000}", result[0] / arr.Count));
        Console.WriteLine(string.Format("{0:0.000000}", result[1] / arr.Count));
        Console.WriteLine(string.Format("{0:0.000000}", result[2] / arr.Count));
    }
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        plusMinus(arr);
    }
}
