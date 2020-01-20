using Course;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace TesteProgram
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Conjuntos();
        }

        public static void ExtensionMethods2()
        {
            int[] ints = { 10, 45, 15, 39, 21, 26 };
            var result = ints.OrderBy(g => g);
            foreach (var i in result)
            {
                System.Console.Write(i + " ");
            }
        }

        public static int WordCount(this String str)
        {
            return str.Split(new char[] { ' ', '.', '?' },
                             StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static void Executar()
        {
            double desconto = 0.0;

            double preco = double.Parse(Console.ReadLine());

            if (preco > 100.0)
            {
                desconto = preco * 0.1;
            }

            Console.WriteLine(desconto);
        }

        public static void Exemplo1()
        {
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("medidas do triangulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("medidas do triangulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine("Area de x igual: " + areaX.ToString("f4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de x igual: " + areaY.ToString("f4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior area é X");
            }
            else
            {
                Console.WriteLine("Maior area é Y");
            }
        }

        public static void Exemplo2()
        {

            //Console.WriteLine("Entre com os dados do produto: ");
            //Console.Write("Nome: ");
            //string nome = Console.ReadLine();

            //Console.Write("Preço: ");
            //double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto p = new Produto("Tv", 900.00, 5);




            //p._quantidade = 500.00;

            //double precoLegal;
            //precoLegal = 500;

            //Console.WriteLine(p.Nome);
            //Console.Write("Atualize seu produto: ");
            //string nome = Console.ReadLine();
            //p.Nome = nome;
            ////p.Preco = precoLegal;
            //Console.WriteLine("Seu novo produto é: " + p.Nome);
            //Console.WriteLine("Preço: " + p._preco);
            p.Nome = "Jão";
            Console.WriteLine(p.Nome + "  " + p.Nome);
            Console.WriteLine(p.Nome);



            //Console.WriteLine("Dados do produto: " + p);

            //Console.Write("\nDigite o número de produtos a serem adicionados ao estoque: ");
            //int mais = int.Parse(Console.ReadLine());
            //p.AdicionarProdutos(mais);

            //Console.WriteLine("Dados atualizados: " + p);

            //Console.Write("\nDigite o número de produtos a serem removido do estoque: ");
            //int menos = int.Parse(Console.ReadLine());
            //p.RemoverProdutos(menos);

            //Console.WriteLine("Dados atualizados: " + p);
        }

        public static void Exemplo3()
        {
            double pi = 3.14159;
            Console.WriteLine("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.raioR(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("\n o valor do raio é: " + circ.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume " + volume.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("valor de pi: " + pi.ToString("f2", CultureInfo.InvariantCulture));
        }

        public static void TesteNullable()
        {
            double? x = null;
            double y = x ?? 10.0;

            Console.WriteLine(y);
        }

        public static void Vetor()
        {
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                sum += vect[i];
            }

            double avg = sum / n;
            Console.WriteLine("Sua média é: {0}", avg.ToString("f2", CultureInfo.InvariantCulture));
        }

        public static void Vetor2()
        {
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product { Nome = name, Preco = price };
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i].Preco;
            }

            double avg = sum / n;
            Console.WriteLine("Sua média é: {0}", avg.ToString("f2", CultureInfo.InvariantCulture));
        }

        public static void AtividadeQuarto()
        {
            Console.Write("Quantos quartos vão ser alugados?: ");
            int n = int.Parse(Console.ReadLine());

            Quartos[] q = new Quartos[10];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Quartos Ocupado: " + i);
                Console.Write("\nNome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Número do Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                q[quarto] = new Quartos(nome, email);
            }

            Console.WriteLine("\nQuantidade de quartos Ocupado: ");
            for (int i = 0; i < 10; i++)
            {
                if (q[i] != null)
                {
                    Console.WriteLine(i + " : " + q[i]);
                }
            }
        }

        public static void Parametros()
        {
            int s1 = Calculator.Sum(2, 3);

            Console.WriteLine(s1);
        }

        public static void Foreach()
        {
            string[] vect = new string[] { "Maria", "Bob", "Alex" };
            foreach (string obj in vect)
            {
                Console.WriteLine(obj);
            }
        }

        public static void Listas()
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Dalila");
            list.Add("Joao");
            list.Add("Emerson");
            list.Add("Estevão");
            list.Insert(1, "Chaves");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Lista Count: " + list.Count);

            string s1 = list.Find(x => x[0] == 'E');
            Console.WriteLine("Find: => " + s1);

            string s2 = list.FindLast(x => x[0] == 'E');
            Console.WriteLine("Last: => " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'E');
            Console.WriteLine("Find position => " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'E');
            Console.WriteLine("Find Last position => " + pos2);

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine();

            foreach (var item in list2)
            {
                Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^");
                Console.WriteLine(item);
            }

            list.RemoveAt(2);
            foreach (var obj in list)
            {
                Console.WriteLine(obj);
                Console.WriteLine("-------------------------------");
            }

            list.RemoveAll(x => x[0] == 'J');
            foreach (var obj in list)
            {
                Console.WriteLine(obj);
            }
        }

        public static void ListaExercicio()
        {
            Console.Write("Quantos funcionários serão registrados? ");
            int quant = int.Parse(Console.ReadLine());
            List<Funcionario> funcionarios = new List<Funcionario>();

            for (int i = 1; i <= quant; i++)
            {
                Console.Write("\nFuncionário# " + i);
                Console.Write("\nId: ");
                int id = int.Parse(Console.ReadLine());
                
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                funcionarios.Add(new Funcionario(id, nome, salario));
            }

            Console.WriteLine("\nQual id do funcionário que terá aumento? ");
            int idFuncionario = int.Parse(Console.ReadLine());

            Funcionario func = funcionarios.Find(x => x.Id == idFuncionario);
            if (func != null)
            {
                Console.WriteLine("Qual o valor da porcentagem? ");
                double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                func.AumentoSalario(porcent);
            }
            else
            {
                Console.WriteLine("Este Funcionário não existe! ");
            }

            Console.WriteLine("\n Aumento registrado com sucesso! ");
            foreach (var item in funcionarios)
            {
                Console.WriteLine(item);
            }
        }

        public static void Matriz()
        {
            int n = int.Parse(Console.ReadLine());

            double[,] mat = new double[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Valores na diagonal: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(mat[i,i] + "");
            }
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.Write("Valores negativo: " + count);
        }

        public static void Matriz2()
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i,j] == x)
                    {
                        Console.WriteLine($"Posição: {i}, {j}: ");
                        if (j > 0)
                        {
                            Console.WriteLine($"Esquerda: {mat[i,j - 1]}");
                        }
                        if (i > 0)
                        {
                            Console.WriteLine($"Cima: {mat[i-1,j]}");
                        }
                        if (j < n -1)
                        {
                            Console.WriteLine($"Direita: {mat[i, j + 1]}");
                        }
                        if (i < m - 1)
                        {
                            Console.WriteLine($"Baixo: {mat[i + 1,j]}");
                        }
                    }
                }
            }
        }

        public static void Conjuntos()
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();

            A.Add(3);
            A.Add(5);
            A.Add(2);
            A.Add(1);

            B.Add(9);
            B.Add(4);
            B.Add(1);

            foreach (var item in A)
            {
                Console.WriteLine(item);
            }

            Console.Write("Digite um número inteiro: ");
            int n = int.Parse(Console.ReadLine());

            if (B.Contains(n))
            {
                Console.WriteLine(n + "  contém dentro do conjunto " + B);
            }
            else
            {
                Console.WriteLine(n + "  Não pertence ao conjunto " +  B);
            }
        }

        public static void Cj()
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();

            Console.WriteLine("O curso A possui quantos alunos? ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso A: ");
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                A.Add(x);
            }

            Console.WriteLine("Digite os códigos dos alunos do curso B: ");
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                B.Add(x);
            }

            Console.WriteLine("Digite os códigos dos alunos do curso C: ");
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                C.Add(x);
            }

            HashSet<int> Novo = new HashSet<int>();
            Novo.UnionWith(A);
            Novo.UnionWith(A);
            Novo.UnionWith(A);
            Console.WriteLine("Total de Alunos " + Novo.Count);
        }
    }
}
