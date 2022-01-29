using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    class numberAndRisk
    {
        public int number { get; set; }
        public int risk { get; set; }
        public void UpdateRisk()
        {
            this.risk++;
        }
    }

    static int nonDivisibleSubset(int k, List<int> s)
    {
        List<numberAndRisk> riskList = new List<numberAndRisk>();
        int currentMax = 0;

        foreach (int item in s)
        {
            foreach (int carry in s)
            {
                if (item != carry)
                {
                    numberAndRisk currentItem = riskList.Find(f => f.number == item);
                    numberAndRisk currentCarryItem = riskList.Find(f => f.number == carry);
                    if ((item + carry) % k == 0)
                    {
                        if (currentItem == null)
                        {
                            riskList.Add(new numberAndRisk() { number = item, risk = 0 });
                        }
                        else
                        {
                            currentItem.UpdateRisk();
                        }
                        if (currentCarryItem == null)
                        {
                            riskList.Add(new numberAndRisk() { number = carry, risk = 0 });
                        }
                        else
                        {
                            currentCarryItem.UpdateRisk();
                        }
                    }
                }
            }
        }
        while (riskList.Find(w => w.risk > 0) != null)
        {
            numberAndRisk listMax = riskList.Find(w => w.risk == riskList.Max(m => m.risk));
            s.Remove(listMax.number);
            riskList.Clear();
            foreach (int item in s)
            {
                foreach (int carry in s)
                {
                    if (item != carry)
                    {
                        numberAndRisk currentItem = riskList.Find(f => f.number == item);
                        numberAndRisk currentCarryItem = riskList.Find(f => f.number == carry);
                        if ((item + carry) % k == 0)
                        {
                            if (currentItem == null)
                            {
                                riskList.Add(new numberAndRisk() { number = item, risk = 0 });
                            }
                            else
                            {
                                currentItem.UpdateRisk();
                            }
                            if (currentCarryItem == null)
                            {
                                riskList.Add(new numberAndRisk() { number = carry, risk = 0 });
                            }
                            else
                            {
                                currentCarryItem.UpdateRisk();
                            }
                        }
                    }
                }
            }
        }
        return s.Count;
    }

    static void Main(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int k = Convert.ToInt32(firstMultipleInput[1]);

        List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

        int result = nonDivisibleSubset(k, s);

        Console.WriteLine(result);
    }
}
