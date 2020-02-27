using System;

namespace EstruturaSequencialExe1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor 1:");
            int valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor 2:");
            int valor2 = int.Parse(Console.ReadLine());

            int result = valor1 + valor2;
            Console.WriteLine($"seu resultado é: {result}");
            Console.WriteLine(result);
        }
    }
}
