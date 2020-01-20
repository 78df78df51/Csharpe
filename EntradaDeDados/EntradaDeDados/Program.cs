using System;
using System.Globalization;

namespace EntradaDeDados
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            string nomeCompleto = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quarto = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com seu último nome, idade e altura (na mesma linha): ");
            string[] vs = Console.ReadLine().Split(' ');
            string nome = vs[0];
            int idade = int.Parse(vs[1]);
            double altura = double.Parse(vs[2], CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine(nomeCompleto);
            Console.WriteLine(quarto);
            Console.WriteLine(preco);
            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}