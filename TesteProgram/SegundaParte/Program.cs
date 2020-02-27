using System;
using System.Globalization;

namespace SegundaParte
{
    class Program
    {
        static void Main(string[] args)
        {
            Data_Time_Propriedades();
        }

        public static void Funcoes_para_string()
        {
            string original = "abcde FGHJI ABC abc DFGH";

            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");
            string s4 = original.Substring(3);
            string s1 = original.ToUpper();

            Console.WriteLine("Original: " + original);
            Console.WriteLine("ToUpper: " + s1);
            Console.WriteLine("IndexOf('bc'): " + n1);
            Console.WriteLine("LastIndexOf('bc'): " + n2);
            Console.WriteLine("Substring: " + s4);
        }

        public static void Data()
        {
            DateTime d1 = DateTime.Parse("2000-08-15");
            DateTime d2 = DateTime.Parse("1994-03-07 07:30");
            DateTime d3 = DateTime.Parse("21/09/2001 07:30:05");
            DateTime d4 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
        }

        public static void Time_span()
        {
            TimeSpan t1 = new TimeSpan(0, 1, 30);
            TimeSpan t2 = new TimeSpan(9000000000L);

            Console.WriteLine(t2);
        }

        public static void Data_Time_Propriedades()
        {
            DateTime d = new DateTime(2020, 3, 7, 07, 45, 58);

            DateTime d2 = d.AddHours(2);

            Console.WriteLine(d2);
        }
    }
}
