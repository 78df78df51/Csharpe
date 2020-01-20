using System.Globalization;

namespace ConstrutoresEEncapsulamentoExercicios
{
    class ContaBancaria
    {
        public string _nome { get; set; }
        public int NumeroConta { get; private set; }
        public double Saldo { get; private set; }

        public ContaBancaria(string nome, int conta)
        {
            _nome = nome;
            NumeroConta = conta;
        }

        public int Conta
        {
            get { return NumeroConta; }
            
        }

        public double SaldoTotal
        {
            get { return Saldo; }
        }

        public string Nome
        {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double GetDeposito(double saldo)
        {
            return Saldo += saldo;
        }

        public double GetSaque(double saldo)
        {
            int taxa = 5;
            return Saldo = Saldo - saldo - taxa;
        }

        public override string ToString()
        {
            return "Conta " + NumeroConta + ", " +
               "Titular: " + _nome + ",  Saldo: $ " + 
               Saldo.ToString("f2", CultureInfo.InvariantCulture); 
        }

        public void ValorDepositoInicial()
        {
            double valor;
            System.Console.WriteLine("Entre com o valor Inicial: ");
            valor = double.Parse(System.Console.ReadLine(), CultureInfo.InvariantCulture);
            Saldo = valor;
        }

        public void ValorInicial(string valorInicial)
        {
            if (valorInicial == "s" || valorInicial == "S")
            {
                ValorDepositoInicial();
            }
            else
            {
                ToString();
            }
        }
    }
}