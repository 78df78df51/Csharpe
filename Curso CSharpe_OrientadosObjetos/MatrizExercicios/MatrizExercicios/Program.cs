using System;

namespace MatrizExercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o valor de M: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Entre com o valor de N: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                Console.WriteLine("Informe os valores a serem adicionados na Matriz na mesma" +
                    "linha separado por UM ESPAÇO");
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Informe a posição de um número X dentro da Matriz");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] == x)
                    {
                        Console.WriteLine($"Posição: {i},{j} ");
                        if (j > 0)
                        {
                            Console.WriteLine($"Esquerda: {mat[i, j - 1]}");
                        }
                        if (i > 0)
                        {
                            Console.WriteLine($"Cima: {mat[i - 1, j]}");
                        }
                        if (j < n - 1)
                        {
                            Console.WriteLine($"Direita: {mat[i, j + 1]}");
                        }
                        if (i < m - 1)
                        {
                            Console.WriteLine($"Baixo: {mat[i + 1, j]}");
                        }
                    }
                }
            }
        }
    }
}
