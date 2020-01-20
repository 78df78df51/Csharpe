using System;
using System.Globalization;

namespace ClassesExercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercicio2();
        }

        public static void Exercicio1()
        {
            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Pessoa();


            Console.WriteLine("Qual é seu nome: ");
            pessoa1.Nome = Console.ReadLine();

            Console.WriteLine("Qual sua idade? ");
            pessoa1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual é o nome da Pessoa que está ao seu lado?");
            pessoa2.Nome = Console.ReadLine();

            Console.WriteLine("Qual sua idade?");
            pessoa2.Idade = int.Parse(Console.ReadLine());

            if (pessoa1.Idade > pessoa2.Idade)
            {
                Console.WriteLine("Pessoa mais velha é: " + pessoa1.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha é: " + pessoa2.Nome);
            }
        }

        public static void Exercicio2()
        {
            Funcionarios f1 = new Funcionarios();
            Funcionarios f2 = new Funcionarios();

            Console.WriteLine("Qual é seu nome: ");
            f1.Nome = Console.ReadLine();

            Console.WriteLine("Salário? ");
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Qual é o nome da Pessoa que está ao seu lado?");
            f2.Nome = Console.ReadLine();

            Console.WriteLine("Salário");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (f1.Salario + f2.Salario) / 2;
            Console.WriteLine("\n\n O salário médio dos funcionarios é:" + media.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}
