using System;
using System.Collections.Generic;
using System.Linq;


public class Solution
{
    static int queensAttack(int n, int k, int r_q, int c_q, List<List<int>> obstacles)
    {
        int result = 0;
        //move right
        for (int i = c_q + 1; i <= n; i++)
        {
            if (obstacles.Find(w => w[0] == r_q && w[1] == i) == null)
            {
                result++;
            }
            else
                break;
        }
        //move left
        for (int i = c_q - 1; i >= 1; i--)
        {
            if (obstacles.Find(w => w[0] == r_q && w[1] == i) == null)
            {
                result++;
            }
            else
                break;
        }
        //move up
        for (int i = r_q + 1; i <= n; i++)
        {
            if (obstacles.Find(w => w[0] == i && w[1] == c_q) == null)
            {
                result++;
            }
            else
                break;
        }
        //move down
        for (int i = r_q - 1; i >= 1; i--)
        {
            if (obstacles.Find(w => w[0] == i && w[1] == c_q) == null)
            {
                result++;
            }
            else
                break;
        }
        //move up and right
        for (int i = r_q + 1, j = c_q + 1; i <= n && j <= n; i++, j++)
        {
            if (obstacles.Find(w => w[0] == i && w[1] == j) == null)
            {
                result++;
            }
            else
                break;
        }
        //move up and left
        for (int i = r_q + 1, j = c_q - 1; i <= n && j >= 1; i++, j--)
        {
            if (obstacles.Find(w => w[0] == i && w[1] == j) == null)
            {
                result++;
            }
            else
                break;
        }
        //move down and right
        for (int i = r_q - 1, j = c_q + 1; i >= 1 && j <= n; i--, j++)
        {
            if (obstacles.Find(w => w[0] == i && w[1] == j) == null)
            {
                result++;
            }
            else
                break;
        }
        //move down and left
        for (int i = r_q - 1, j = c_q - 1; i >= 1 && j >= 1; i--, j--)
        {
            if (obstacles.Find(w => w[0] == i && w[1] == j) == null)
            {
                result++;
            }
            else
                break;
        }
        return result;
    }
    
    public static void Main(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int k = Convert.ToInt32(firstMultipleInput[1]);

        string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int r_q = Convert.ToInt32(secondMultipleInput[0]);

        int c_q = Convert.ToInt32(secondMultipleInput[1]);

        List<List<int>> obstacles = new List<List<int>>();

        for (int i = 0; i < k; i++)
        {
            obstacles.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(obstaclesTemp => Convert.ToInt32(obstaclesTemp)).ToList());
        }

        int result = queensAttack(n, k, r_q, c_q, obstacles);

        Console.WriteLine(result);
    }
}
