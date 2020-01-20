using System;
using System.Globalization;

namespace EstruturaCondicionalExercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercicio8();
        }

        public static void Exercicio1()
        {
            Console.WriteLine("Digite um valor inteiro");
            int numero = int.Parse(Console.ReadLine());
            if (numero < 0)
            {
                Console.WriteLine("NEGATIVO");
            }
            else
            {
                Console.WriteLine("NÃO NEGATIVO");
            }
        }

        public static void Exercicio2()
        {
            Console.WriteLine("Digite um valor inteiro");
            int numero = int.Parse(Console.ReadLine());
            if (numero % 2 == 0)
            {
                Console.WriteLine("Par!");
            }
            else
            {
                Console.WriteLine("Impar!");
            }
        }

        public static void Exercicio3()
        {
            Console.WriteLine("Digite o valor de A e B (Na mesma linha, separado por um espaço)");
            string[] vs = Console.ReadLine().Split(' ');
            int A = int.Parse(vs[0]);
            int B = int.Parse(vs[1]);

            if (A % B == 0 || B % A == 0)
            {
                Console.WriteLine("São Multiplos");
            }
            else
            {
                Console.WriteLine("Não são Multiplos");
            }
        }

        public static void Exercicio4()
        {
            Console.WriteLine("Digite o horário inicial e final do jogo (na mesma linha, separado por espaço)");
            string[] vs = Console.ReadLine().Split(' ');
            double inicio = double.Parse(vs[0]);
            double final = double.Parse(vs[1]);

            double duracao;
            if (inicio < final)
            {
                duracao = final - inicio;
            }
            else
            {
                duracao = 24 - inicio + final;
            }

            Console.WriteLine($"O jogo durou {duracao} horas");
        }

        public static void Exercicio5()
        {
            Console.WriteLine("Digite o código do pedido mais a quantidade (na mesma linha separado por um espaço)");
            string[] vs = Console.ReadLine().Split(' ');
            int cod = int.Parse(vs [0]);
            int quant = int.Parse(vs[1]);

            double total;
            if (cod == 1)
            {
                total = quant * 4;
            }
            else if (cod == 2)
            {
                total = quant * 4.5;
            }
            else if(cod == 3)
            {
                total = quant * 5;
            }
            else if(cod == 4)
            {
                total = quant * 2;
            }
            else
            {
                total = quant * 1.5;
            }

            Console.WriteLine("Seu total é: " + total.ToString("f2", CultureInfo.InvariantCulture));
        }

        public static void Exercicio6()
        {
            Console.WriteLine("Digite um valor qualquer");
            double N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (N < 0.0  || N > 100.00)
            {
                Console.WriteLine("Está fora do intervalo");
            }
            else if( N <= 25.0)
            {
                Console.WriteLine("Esta dentro do intervalo [0.25]");
            }
            else if (N <= 50.0)
            {
                Console.WriteLine("Esta dentro do intervalo [25.50]");
            }
            else if (N <= 75.0)
            {
                Console.WriteLine("Esta dentro do intervalo [50.75]");
            }
            else
            {
                Console.WriteLine("Esta dentro do intervalo [75.100]");
            }
        }

        public static void Exercicio7()
        {
            Console.WriteLine("Digite o valor de X e Y, respectativamente (na mesma linha separado por um espaço)");
            string[] vs = Console.ReadLine().Split(' ');
            double x = double.Parse(vs[0]);
            double y = double.Parse(vs[1]);

            double resultado;
            if (x == 0.0 || y == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0.0 )
            {
                Console.WriteLine("Eixo X");
            }
            else if (y == 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (x > 0.0 && y > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0.0 && y < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }
        }

        public static void Exercicio8()
        {
            Console.WriteLine("Digite o valor do salario de Lisarb");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double imposto;
            if (salario <= 2000.0)
            {
                imposto = 0.0;
            }
            else if (salario <= 3000.0)
            {
                imposto = (salario - 2000.0) * 0.08;
            }
            else if (salario <= 4500.0)
            {
                imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
            }
            else
            {
                imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }

            if (imposto == 0.0)
            {
                Console.WriteLine("isento");
            }
            else
            {
                Console.WriteLine("o imposto pago será de R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
