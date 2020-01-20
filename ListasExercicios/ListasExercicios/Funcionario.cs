using System.Globalization;

namespace ListasExercicios
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public double AumentoSalario(double salario)
        {
            return Salario += (Salario * salario / 100.0);
        }

        public override string ToString()
        {
            return Id + ", " + Nome + ", " + Salario.ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}