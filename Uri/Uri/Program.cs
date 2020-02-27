using System;
using System.Globalization;

namespace Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            _1012();
        }

        public static void _1001()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int x = a + b;
            Console.WriteLine($"X = {x}");
        }

        public static void _1002()
        {
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pi = 3.14159;
            double area = pi * Math.Pow(raio, 2);
            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));
        }

        public static void _1003()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int SOMA = A + B;
            Console.WriteLine("SOMA = " + SOMA);
        }

        public static void _1004()
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int prod = x * y;
            Console.WriteLine("PROD = " + prod);
        }

        public static void _1005()
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int prod = x * y;
            Console.WriteLine("PROD = " + prod);
        }

        public static void _1006()
        {
            double n1, n2, n3, m, n, x;

            n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            m = n1 * 2 + n2 * 3 + n3 * 5;
            n = 10;
            x = m / n;

            Console.WriteLine("MEDIA  = " + x.ToString("f1", CultureInfo.InvariantCulture));
        }

        public static void _1007()
        {
            int a, b, c, d, diferenca;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            diferenca = (a * b - c * d);
            Console.WriteLine("DIFERENCA = " + diferenca);
        }

        public static void _1008()
        {
            int number = int.Parse(Console.ReadLine());
            int quant = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            var value = quant * salary;

            Console.WriteLine($"Number = {number}");
            Console.WriteLine($"Salary = U$ { value.ToString("f2", CultureInfo.InvariantCulture)}");
        }

        public static void _1009()
        {
            string name = Console.ReadLine();
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double sales = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double porcent = (15 * sales) / 100;
            double sum = porcent + salary;
            Console.WriteLine("TOTAL = R$ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }

        public static void _1010()
        {
            int cod1, unid1, cod2, unid2;
            double value1, value2, count1,count2, sum;

            string[] vs1 = Console.ReadLine().Split(' ');
            string[] vs2 = Console.ReadLine().Split(' ');

            cod1 = int.Parse(vs1[0]);
            unid1 = int.Parse(vs1[1]);
            value1 = double.Parse(vs1[2], CultureInfo.InvariantCulture);

            cod2 = int.Parse(vs2[0]);
            unid2 = int.Parse(vs2[1]);
            value2 = double.Parse(vs2[2], CultureInfo.InvariantCulture);

            count1 = unid1 * value1;
            count2 = unid2 * value2;

            sum = count1 + count2;

            Console.WriteLine("VALOR A PAGAR: R$ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }

        public static void _1011()
        {
            double pi = 3.14159;
            int m = 3;

            double n = int.Parse(Console.ReadLine());
            
            n = Math.Pow(n, m);
            double conta = (4 * pi * n) / 3;
            Console.WriteLine("VOLUME = " + conta.ToString("f3", CultureInfo.InvariantCulture));
        }

        public static void _1012()
        {
            double trianguloRetangulo, raioCirculo, areaTrapezio, quadrado, areaRetangulo, pi;
            pi = 3.14159;

            string[] vs = Console.ReadLine().Split(' ');
            double a = double.Parse(vs[0], CultureInfo.InvariantCulture);
            double b = double.Parse(vs[1], CultureInfo.InvariantCulture);
            double c = double.Parse(vs[2], CultureInfo.InvariantCulture);

            trianguloRetangulo = (a * c) / 2;
            raioCirculo = pi * Math.Pow(c,2);
            areaTrapezio = ((a + b) * c ) / 2;
            quadrado = b * b;
            areaRetangulo = a * b;

            Console.WriteLine("TRIANGULO: " + trianguloRetangulo.ToString("f3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + raioCirculo.ToString("f3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + areaTrapezio.ToString("f3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("f3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + areaRetangulo.ToString("f3", CultureInfo.InvariantCulture));
        }
    }
}
