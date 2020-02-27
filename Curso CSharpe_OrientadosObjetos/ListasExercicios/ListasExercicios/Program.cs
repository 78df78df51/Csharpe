using System;
using System.Collections.Generic;
using System.Globalization;

namespace ListasExercicios
{
    class Program
    {
        static void Main(string[] args)
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
    }
}
