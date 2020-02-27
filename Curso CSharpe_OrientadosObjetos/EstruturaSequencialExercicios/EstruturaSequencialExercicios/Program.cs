using System;
using System.Globalization;

namespace EstruturaSequencialExercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercicio6();
        }

        public static void Exercicio1()
        {
            Console.WriteLine("Digite o valor 1:");
            int valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor 2:");
            int valor2 = int.Parse(Console.ReadLine());

            int result = valor1 + valor2;
            Console.WriteLine($"seu resultado é: {result}");
        }

        public static void Exercicio2()
        {
            double pi, raio, resultado;
            pi = 3.14159;
            Console.WriteLine("Digite o raio do circulo");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            resultado = pi * (raio * raio);
            Console.WriteLine("Seu raio é {0,10:0.0.0.0.0.}", resultado, CultureInfo.InvariantCulture);
        }

        public static void Exercicio3()
        {
            Console.WriteLine("Digite o valor de A: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de B: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de C: ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de D: ");
            int d = int.Parse(Console.ReadLine());

            int diferenca = (a * b - c * d);
            Console.WriteLine("Seu resultado é  = {0}", diferenca);
        }

        public static void Exercicio4()
        {
            int codigoFuncionario = 0;
            double horasTrabalhadas = 0;
            double valorHora = 0;
            bool validou = false;

            Console.WriteLine("Digite o código do Funcionário: ");
            while (validou == false)
            {
                try
                {
                    codigoFuncionario = int.Parse(Console.ReadLine());
                    validou = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Digite apenas números inteiro");
                }
            }
            validou = false;

            Console.WriteLine($"Horas trabalhadas do Funcionário do código:{codigoFuncionario}");
            while (validou == false)
            {
                try
                {
                    horasTrabalhadas = double.Parse(Console.ReadLine());
                    validou = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Digite apenas números...");
                }
            }
            validou = false;

            Console.WriteLine("Digite o valor de uma hora trabalhada do Funcionário {0}:", codigoFuncionario);
            while (validou == false)
            {
                try
                {
                    valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    validou = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Digite apenas números...");
                }

            }

            double calcular = horasTrabalhadas * valorHora;
            Console.WriteLine("O funcionário de código = " + codigoFuncionario + " recebe: U$ " + calcular.ToString("f2", CultureInfo.InvariantCulture));
        }

        public static void Exercicio5()
        {

            int codigoPeca1, numeroPeca1, codigoPeca2, numeroPeca2;
            double valorPeca1, valorPeca2, multiplicacao1, multiplicacao2, resultado;

            Console.WriteLine("Digite o código do peça um: ");
            codigoPeca1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade da peça um: ");
            numeroPeca1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da peça um: ");
            valorPeca1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o código do peça dois: ");
            codigoPeca2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade da peça dois: ");
            numeroPeca2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da peça dois: ");
            valorPeca2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            multiplicacao1 = numeroPeca1 * valorPeca1;
            multiplicacao2 = numeroPeca2 * valorPeca2;
            resultado = multiplicacao1 + multiplicacao2;

            Console.WriteLine("Valor a pagar é: R$ " + resultado.ToString("f2", CultureInfo.InvariantCulture));
        }

        public static void Exercicio6()
        {
            double a, b, c,areaTriangulo,areaCirculo, areaTrapezio, areaAltura, areaRetangulo;
            double pi = 3.14159;

            Console.WriteLine("Digite o valor de A: ");
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o valor de B: ");
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o valor de C");
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            areaTriangulo = (a * c) / 2;
            areaCirculo = pi * (c * c);
            areaTrapezio = (a + b) * c / 2;
            areaAltura = b * b;
            areaRetangulo = a * b;

            Console.WriteLine("A área do triangulo é: " + areaTriangulo.ToString("f3", CultureInfo.InvariantCulture));
            Console.WriteLine("A área do círculo é: " + areaCirculo.ToString("f3", CultureInfo.InvariantCulture));
            Console.WriteLine("A área do trapezio é: " + areaTrapezio.ToString("f3", CultureInfo.InvariantCulture));
            Console.WriteLine("A área do altura é: " + areaAltura.ToString("f3", CultureInfo.InvariantCulture));
            Console.WriteLine("A área do retangulo é: " + areaRetangulo.ToString("f3", CultureInfo.InvariantCulture));
        }
    }
}
