using System;
using System.Globalization;

namespace EstruturaRepetitiva2Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercicio2();
        }

        public static void Exercicio1()
        {
            Console.WriteLine("Digite um valor inteiro");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void Exercicio2()
        {
            Console.WriteLine("Digite um valor inteiro");
            int n = int.Parse(Console.ReadLine());

            int cont_in = 0;
            int cont_out = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite um valor inteiro");
                int x = int.Parse(Console.ReadLine());

                if (x >= 10 && x <= 20)
                {
                    cont_in += 1;
                }
                else
                {
                    cont_out += 1;
                }
            }
            Console.WriteLine("\n\n cont in: {0} \n\n count out: {1}", cont_in, cont_out);
        }

        public static void Exercicio3()
        {
            Console.WriteLine("Digite um valor inteiro");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("digite 3 valores reais na mesma linha separados por espaço");
                string[] vs = Console.ReadLine().Split(' ');
                double a = double.Parse(vs[0], CultureInfo.InvariantCulture);
                double b = double.Parse(vs[1], CultureInfo.InvariantCulture);
                double c = double.Parse(vs[2], CultureInfo.InvariantCulture);

                double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10;

                Console.WriteLine("Sua média é: " + media.ToString("f1", CultureInfo.InvariantCulture));
            }
        }

        public static void Exercicio4()
        {
            Console.WriteLine("Digite um valor inteiro");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("digite 3 valores reais na mesma linha separados por espaço");
                string[] vs = Console.ReadLine().Split(' ');
                double a = double.Parse(vs[0], CultureInfo.InvariantCulture);
                double b = double.Parse(vs[1], CultureInfo.InvariantCulture);

                if (b == 0)
                {
                    Console.WriteLine("Divisão Impossivel");
                }
                else
                {
                    double divisao = a / b;
                    Console.WriteLine("Sua divisão é: " + divisao.ToString("f1", CultureInfo.InvariantCulture));
                }
            }
        }

        public static void Exercicio5()
        {
            Console.WriteLine("Digite um valor inteiro");
            int n = int.Parse(Console.ReadLine());

            int fatoral = n;
            for (int i = 1; i < n; i++)
            {
                fatoral = fatoral * i ;
                
            }
            Console.WriteLine(n + " fatorial= " + fatoral);
        }

        public static void Exercicio6()
        {
            Console.WriteLine("Digite um número inteiro: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("Seu divisor é: " + i);
                }
            }
        } 

        public static void Exercicio7()
        {
            Console.WriteLine("Digite um número inteiro: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int a = i;
                int b = i * i;
                int c = i * i * i;
                Console.WriteLine($"Número da linha: {a}, quadradado da linha: {b} e valor ao cubo: {c}");
            }
        }
    }
}
