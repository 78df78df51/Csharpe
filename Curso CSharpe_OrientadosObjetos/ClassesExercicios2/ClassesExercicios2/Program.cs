using System;
using System.Globalization;

namespace ClassesExercicios2
{
    class Program
    {
        static void Main(string[] args)
        {
            ExercicioFixicao();
        }

        public static void Exercicio1()
        {
            Retangulo r = new Retangulo();

            Console.WriteLine("Entre com Largura e Altura do retângulo (Na mesma linha, SEPARADO POR UM ESPAÇO)");
            string[] vetor = Console.ReadLine().Split(' ');
            r.Largura = double.Parse(vetor[0], CultureInfo.InvariantCulture);
            r.Altura = double.Parse(vetor[1], CultureInfo.InvariantCulture);

            Console.WriteLine($"\n AREA = {r.Area()} \n PERÍMETRO = {r.Perimetro()} \n DIAGONAL = {r.Diagonal()}");
        }

        public static void Exercicio2()
        {
            Funcionario f = new Funcionario();

            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine(" Funcionário: " + f);
            Console.Write("Digite a porcentagem para aumentar o salário:");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.AumentarSalario(porcentagem);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + f);
        }

        public static void Exercicio3()
        {
            Alunos alunos = new Alunos();

            Console.WriteLine("Nome do Aluno: ");
            alunos.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno (Na mesma linha, SEPARADO POR UM ESPAÇO) ");
            string[] vs = Console.ReadLine().Split(' ');
            alunos.A = double.Parse(vs[0], CultureInfo.InvariantCulture);
            alunos.B = double.Parse(vs[1], CultureInfo.InvariantCulture);
            alunos.C = double.Parse(vs[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Nota Final = " + alunos.NotaFinal().ToString("f2", CultureInfo.InvariantCulture));

            if (alunos.Aprovado())
            {
                Console.WriteLine("Aluno Aprovado");
            }
            else
            {
                Console.WriteLine("\n 'Reprovado' \n Faltaram " + alunos.NotaRestante().ToString("f2", CultureInfo.InvariantCulture)
                    + " pontos");
            }
        }

        public static void ExercicioFixicao()
        {
            Console.WriteLine("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantos dólares você vai comprar? ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = ConversorDeMoeda.DolarParaReal(quantia, cotacao);

            Console.WriteLine("Seu resultado é: " + result.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}
