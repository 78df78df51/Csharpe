using System;
using System.Globalization;

namespace EstruturaRepetitiva
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            double n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (n >= 0.0)
            {
                double raiz = n * n;
                Console.WriteLine(raiz.ToString("f3", CultureInfo.InvariantCulture));
                Console.WriteLine("Digite outro número");
                n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine("Numero negativo!");

        }
    }
}
