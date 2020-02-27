using System;

namespace testdome
{
    class QuadraticEquation
    {
        public static Tuple<double, double> FindRoots(double a, double b, double c)
        {
            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
            return Tuple.Create(x1, x2);

        }

        //public static void Main(string[] args)
        //{
        //    Tuple<double, double> roots = QuadraticEquation.FindRoots(2, 10, 8);
        //    Console.WriteLine("Roots: " + roots.Item1 + ", " + roots.Item2);

        //}
    }
}
