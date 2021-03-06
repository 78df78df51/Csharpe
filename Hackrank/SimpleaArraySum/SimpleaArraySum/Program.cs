﻿using System;
using System.IO;

class Solution
{

    static int simpleArraySum(int[] ar)
    {
        int len = ar.Length;
        int sum = 0;
        for (int i = 0; i < len; i++)
        {
            sum += ar[i];
        }
        return sum;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arCount = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
        int result = simpleArraySum(ar);

        Console.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
