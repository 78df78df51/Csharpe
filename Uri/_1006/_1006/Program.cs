using System;
using System.Globalization;

namespace _1006
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, m, n, x;

            n1 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            n2 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            n3 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            m = n1 * 2 + n2 * 3 + n3 * 5;
            n =  10;
            x = m / n;

            Console.WriteLine("MEDIA = " + x.ToString("0.0", CultureInfo.InvariantCulture));
        }
    }
}
