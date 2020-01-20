using System;

namespace VetoresExerciciosFixicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos vão ser alugados?: ");
            int n = int.Parse(Console.ReadLine());

            Estudantes[] estudantes = new Estudantes[10];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Quartos Ocupado: " + i);
                Console.Write("\nNome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Número do Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                estudantes[quarto] = new Estudantes(nome, email);
            }

            Console.WriteLine("\nQuantidade de quartos Ocupado: ");
            for (int i = 0; i < 10; i++)
            {
                if (estudantes[i] != null)
                {
                    Console.WriteLine(i + " : " + estudantes[i]);
                }
            }
        }
    }
}
