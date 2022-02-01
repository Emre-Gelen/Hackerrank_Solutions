using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    static int diagonalDifference(List<List<int>> arr)
    {
        int n = arr[0].Count;
        int primaryDiagonal = 0;
        int secondaryDiagonal = 0;
        for (int i = 0; i < n; i++)
        {
            primaryDiagonal += arr[i][i];
            secondaryDiagonal += arr[i][n - 1 - i];
        }
        return primaryDiagonal > secondaryDiagonal ?
            primaryDiagonal - secondaryDiagonal
            : secondaryDiagonal - primaryDiagonal;
    }
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }
        int result = diagonalDifference(arr);
        Console.WriteLine(result);
    }
}
