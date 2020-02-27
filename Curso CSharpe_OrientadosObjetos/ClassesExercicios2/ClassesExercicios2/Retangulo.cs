using System;

namespace ClassesExercicios2
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return 2 * (Largura + Altura);
        }

        public double Diagonal()
        {
            double d = Largura * Largura; 
            double c = Altura * Altura;
            return Math.Sqrt(d + c);
        }
    }
}
