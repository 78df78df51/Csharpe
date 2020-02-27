using System;

class Solution
{
    static long aVeryBigSum(long[] ar)
    {
        long sum = 0;
        for (int i = 0; i < ar.Length; i++)
        {
            sum += ar[i];
        }
        return sum;
    }

    static void Main(string[] args)
    {
        int arCount = Convert.ToInt32(Console.ReadLine());

        long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp));
        long result = aVeryBigSum(ar);

        Console.WriteLine(result);
    }
}
