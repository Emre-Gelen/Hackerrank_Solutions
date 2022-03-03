class Result
{
    public static string balancedSums(List<int> arr)
    {
        int leftSum = 0;
        int rightSum = 0;

        for (int k = 1; k < arr.Count; k++)
        {
            rightSum += arr[k];
        }

        if (arr.Count == 1)
            return "YES";

        for (int i = 0; i < arr.Count - 1; i++)
        {
            if (leftSum == rightSum)
            {
                return "YES";
            }
            leftSum += arr[i];
            rightSum -= arr[i + 1];
        }

        return "NO";
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int T = Convert.ToInt32(Console.ReadLine().Trim());

        for (int TItr = 0; TItr < T; TItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            string result = Result.balancedSums(arr);

            Console.WriteLine(result);
        }
    }
}
