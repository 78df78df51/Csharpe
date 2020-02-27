using System;

namespace EstruturaRepetitivaExercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercicio2();
        }

        public static void Exercicio1()
        {
            Console.WriteLine("Digite sua senha: ");
            int x = int.Parse(Console.ReadLine());
            int senha = 2002;

            while (senha != x)
            {
                Console.Clear();
                Console.WriteLine("Senha Inválida, Digite Novamente:");
                x = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido :p ");
        }

        public static void Exercicio2()
        {
            Console.WriteLine("Digite o valor de X e Y, respectativamente (na mesma linha separado por um espaço)");
            string[] vs = Console.ReadLine().Split(' ');
            double x = double.Parse(vs[0]);
            double y = double.Parse(vs[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Primeiro, Digite o valor de X e Y, respectativamente (na mesma linha separado por um espaço)");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Segundo, Digite o valor de X e Y, respectativamente (na mesma linha separado por um espaço)");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Terceiro, Digite o valor de X e Y, respectativamente (na mesma linha separado por um espaço)");
                }
                else
                {
                    Console.WriteLine("Quarto, Digite o valor de X e Y, respectativamente (na mesma linha separado por um espaço)");
                }

                vs = Console.ReadLine().Split();
                x = double.Parse(vs[0]);
                y = double.Parse(vs[1]);
            }
                Console.WriteLine("Fim!");
        }

        public static void Exercicio3()
        {
            Console.WriteLine("Qual Combustível você prefere? ");
            int x = int.Parse(Console.ReadLine());
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            while (x != 4)
            {
                if (x == 1)
                {
                    alcool += 1;
                }
                else if (x == 2)
                {
                    gasolina += 1;
                }
                else if (x == 3)
                {
                    diesel += 1;
                }

                Console.WriteLine("Digite um novo código");
                x = int.Parse(Console.ReadLine());

            }
            Console.WriteLine($"\n\nMuito Obrigado \n\n Alcool: {alcool} \n\n Gasolina: {gasolina} \n\n Diesel: {diesel}");
        }
    }
}
