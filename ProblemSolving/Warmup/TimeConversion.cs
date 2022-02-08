using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    static string timeConversion(string s)
    {
        string[] splittedStr = s.Split(':');
        int hour = int.Parse(splittedStr[0]);
        string period = splittedStr[2].Substring(2);

        if (period == "PM" && hour != 12)
            hour = (hour + 12) % 24;
        else if (period == "AM" && hour == 12)
            hour = 0;

        if (hour < 12)
            return "0" + hour + ":" + splittedStr[1] + ":" + splittedStr[2].Substring(0, 2);
        return hour + ":" + splittedStr[1] + ":" + splittedStr[2].Substring(0, 2);
    }

    static void Main(string[] args)
    {
        string s = Console.ReadLine();
        string result = timeConversion(s);
        Console.WriteLine(result);
    }
}
