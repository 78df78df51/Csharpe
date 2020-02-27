using System;
using System.Collections.Generic;
using System.Linq;


namespace testdome
{
    public class MergeNames
    {
        public static string[] UniqueNames(string[] names1, string[] names2)
        {
            var unio = names1.Union(names2).ToArray<string>();
            return unio;

            /* outra forma de fazer
            List<string> temp = names1.ToList<string>();
            foreach (var i in names1)
            {
                if (!names2.Contains(i))
                {
                    temp.Add(i);
                }
            }
            String[] vs = temp.ToArray<string>();

            return vs;
            */
        }

        //public static void Main(string[] args)
        //{
        //    string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
        //    string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };
        //    Console.WriteLine(string.Join(", ", MergeNames.UniqueNames(names1, names2))); // should print Ava, Emma, Olivia, Sophia
        //}
    }
}
