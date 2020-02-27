using System.Collections.Generic;
using System.Linq;
using System;

class Solution
{
    static List<int> compareTriplets(List<int> a, List<int> b)
    {
        int alice = 0, bob = 0;
        for (int i = 0; i < a.Count; i++)
        {
            if (a.ElementAt(i) > b.ElementAt(i))
            {
                alice += 1;
            }
            else if (a.ElementAt(i) < b.ElementAt(i))
            {
                bob += 1;
            }
        }

        return new List<int> { alice, bob };
    }

    static void Main(string[] args)
    {
        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

        List<int> result = compareTriplets(a, b);

        Console.WriteLine(String.Join(" ", result));
    }
}