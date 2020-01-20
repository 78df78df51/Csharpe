using System;
using System.Globalization;

namespace ConstrutoresEEncapsulamentoExercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria c;

            double dinheiro;
            int conta;
            string nome;

            Console.Write("Bem vindo, entre com o número da conta: ");
            conta = int.Parse(Console.ReadLine());


            Console.Write("Entre com o titular da conta: ");
            nome = Console.ReadLine();

            c = new ContaBancaria(nome, conta);

            Console.Write("Haverá depósito inicial (s/n)? ");
            string valorInicial = Console.ReadLine();
            c.ValorInicial(valorInicial);

            Console.WriteLine("Dados da Conta: \n" + c);

            Console.Write("Entre com um valor para Depósito: ");
            dinheiro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.GetDeposito(dinheiro);

            Console.WriteLine("Dados da Conta Atualizados: \n" + c.ToString(), CultureInfo.InvariantCulture);

            Console.Write("Entre com um valor para Saque: ");
            dinheiro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.GetSaque(dinheiro);

            Console.WriteLine("Dados da Conta Atualizados: \n" + c.ToString(), CultureInfo.InvariantCulture);
        }
    }
}
