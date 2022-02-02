using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    static void miniMaxSum(List<int> arr)
    {
        long min = arr[0], max = arr[0], sum = 0;
        foreach (int item in arr)
        {
            sum += item;
            if (item > max)
            {
                max = item;
            }
            if (item < min)
            {
                min = item;
            }
        }
        Console.WriteLine((sum - max) + " " + (sum - min));
    }

    static void Main(string[] args)
    {
        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
        miniMaxSum(arr);
    }
}
