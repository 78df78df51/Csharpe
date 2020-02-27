using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    public static int diagonalDifference(List<List<int>> arr)
    {
        var diagonal = new List<int>();
        for (int linha = 0; linha < arr.Count; linha++)
        {
            diagonal.Add(arr[linha][linha]);            
        }
        int x = diagonal.Sum();

        
        var diagonalSecundaria = new List<int>();
        for (int i = 0; i < arr.Count; i++)
        {
            for (int j = arr.Count - 1; j < arr.Count; j--)
            {
                diagonalSecundaria.Add(arr[i][j]);
            }
            
        }
        int y = diagonalSecundaria.Sum();

        return Math.Abs(y);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr);

        Console.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();

    }
}

