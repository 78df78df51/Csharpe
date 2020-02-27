using System;
using System.Globalization;

namespace _1005
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, e, m;
             a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c = 3.5;
            d = 7.5;
            a *= c;
            b *= d;
            e = c + d;
            m = (a + b) / e;
            Console.WriteLine("MEDIA = " + m.ToString("f5", CultureInfo.InvariantCulture));
        }
    }
}
