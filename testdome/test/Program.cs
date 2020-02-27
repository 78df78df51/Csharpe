using System;
using System.Collections.Generic;

namespace test
{
    class Program
    {
        public static Tuple<int, int> FindTwoSum(IList<int> list, int sum)
        {
            /* outra forma de fazer
            //var result = from n1 in list
            //             from n2 in list
            //             where n1 + n2 == sum
            //             select new Tuple<int, int>(list.IndexOf(n1), list.IndexOf(n2));
            //return result.FirstOrDefault();
            */

            HashSet<int> vs = new HashSet<int>();
            for (int i = 0; i < list.Count; i++)
            {
                var conta = sum - list[i];
                if (vs.Contains(conta))
                {
                    return Tuple.Create(list.IndexOf(conta), i);
                }
                vs.Add(list[i]);
            }
            return null;
        }

        public static void Main(string[] args)
        {
            Tuple<int, int> indices = FindTwoSum(new List<int>() { 3, 1, 5, 7, 5, 9 }, 10);
            Console.WriteLine(indices.Item1 + " " + indices.Item2);
        }
    }
}
