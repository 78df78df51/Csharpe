using System;

namespace EstruturaRepetitiva2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidades de valores: ");
            int n = int.Parse(Console.ReadLine());
   
            int soma = 0;
            for (int i = 1; i <= n; i++)
            {

                Console.WriteLine($"Valor : #{i}: ");
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }
            Console.WriteLine("Soma = " + soma);
        }
    }
}
