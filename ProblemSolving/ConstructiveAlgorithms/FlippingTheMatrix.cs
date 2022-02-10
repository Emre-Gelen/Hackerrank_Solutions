using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    static int flippingMatrix(List<List<int>> matrix)
    {
        int n = matrix[0].Count, sum = 0;

        for (int i = 0; i < n / 2; i++)
        {
            for (int j = 0; j < n / 2; j++)
            {
                int max = matrix[i][j];
                if (matrix[i][n - j - 1] > max)
                    max = matrix[i][n - j - 1];
                if (matrix[n - i - 1][j] > max)
                    max = matrix[n - i - 1][j];
                if (matrix[n - i - 1][n - j - 1] > max)
                    max = matrix[n - i - 1][n - j - 1];
                sum += max;
            }
        }
        return sum;
    }

    static void Main(string[] args)
    {
        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            List<List<int>> matrix = new List<List<int>>();

            for (int i = 0; i < 2 * n; i++)
            {
                matrix.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(matrixTemp => Convert.ToInt32(matrixTemp)).ToList());
            }

            int result = flippingMatrix(matrix);
            Console.WriteLine(result);
        }
    }
}
