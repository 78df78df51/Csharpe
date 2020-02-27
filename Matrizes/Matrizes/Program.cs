using System;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            Matriz_exercicio4();
        }

        public static void Vetor()
        {
            Random r = new Random();
            int[] vs = new int[4] { r.Next(10), r.Next(10), r.Next(10), r.Next(10) };
            int total = vs[0] + vs[1] + vs[2] + vs[3];
            vs[0] = vs[1] = vs[2] = vs[3] = 0;
            Console.WriteLine(total);

            for (int i = 0; i < vs.Length; i++)
            {
                Console.WriteLine(i);
            }

            foreach (var item in vs)
            {
                Console.WriteLine(item);
            }
        }

        public static void Vetor_Inverso()
        {
            int[] x = new int[10];
            int i;
            Console.WriteLine("Digite 10 valores inteiros ");

            for (i = 0; i < 10; i++)
            {
                x[i] = int.Parse(Console.ReadLine());
            }

            for (i = 9; i >= 0; i--)
            {
                Console.WriteLine(x[i]);
                Console.WriteLine();
            }
        }

        public static void Matriz()
        {
            int[,] mat = new int[3, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
            int i, j;
            Console.WriteLine("Matriz");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    Console.WriteLine("{0,5}", mat[i, j]);
                }
            }

            Console.WriteLine("\nTransposta ");
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.WriteLine("{0,5}", mat[j, i]);
                    Console.WriteLine();
                }
            }
        }

        public static void Vetor_Exercicio1()
        {
            int[] vetor = new int[] { 6, 5, 7, 8, 1, 5, 4, 9, 2, 1};
            int maior = vetor[0], menor = vetor[0], i;
            for (i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine($"Vetores de 10, posições {i}: " + vetor[i]);
            }

            for (i = 9; i >= 0; i--)
            {

            Console.WriteLine($"Ordem Inversa {i}: " + vetor[i]);
            }

        }

        public static void Vetor_Exercicio2()
        {
            int[] vetor = new int[] { 6, 5, 7, 8, 1, 5, 4, 9, 2, 1 };
            int maior = vetor[0], menor = vetor[0], i;
            for (i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine($"Vetores de 10, posições {i}: " + vetor[i]);

                if (vetor[i] > maior)
                {
                    maior = vetor[i];
                }
                else if (vetor[i] < menor)
                {
                    menor = vetor[i];
                }
            }
            Console.WriteLine("Maior: " + maior + " Menor: " + menor);
        }

        public static void Matriz_exercicio3()
        {
            int[,] matriz = new int [4,4] { { 9, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 8, 15, 4, 6 } };
            int linha, coluna, maior, menor, soma;
            menor = matriz[0, 0];
            maior = 0;

            for (linha = 0; linha < 4; linha++)
            {
                for (coluna = 0; coluna < 4; coluna++)
                {
                    Console.WriteLine(matriz[linha, coluna]);
                    if (matriz[linha, coluna] > maior)
                    {
                        maior = matriz[linha, coluna];
                    }
                    else if (matriz[linha, coluna] < menor)
                    {
                        menor = matriz[linha, coluna];
                    }
                }
            }

            Console.WriteLine("Maior valor: " + maior);
            Console.WriteLine("Menor valor: " + menor);
            soma = maior + menor;
            Console.WriteLine("A soma entre o maior e o menor valor é: " + soma);
        }

        public static void Matriz_exercicio4()
        {
            int[,] matriz = new int[4, 4] { { 9, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 8, 15, 4, 6 } };
            int soma = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine(matriz[i,j]);
                }
            }

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("\nDiagonal principal: " + matriz[i,i]);
                soma += matriz[i, i];
            }

            Console.WriteLine("\nA soma das diagonais são: " + soma);
        }
    }
}