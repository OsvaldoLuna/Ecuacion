using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecuacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("La ecuacion debe tener tres elementos: ");
            Console.WriteLine("a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("c: ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("x°1: " + (Positivo(a, b, c) / (2 * a)));
            Console.WriteLine("x°2: " + (Negativo(a, b, c) / (2 * a)));
            Console.ReadKey();
        }

        static double Positivo(double a, double b, double c)
        {
            return ((0 - 1) * b) + (Math.Sqrt((Math.Pow(b, 2) - (4 * a * c))));

        }

        static double Negativo(double a, double b, double c)
        {
            return ((0 - 1) * b) - (Math.Sqrt((Math.Pow(b, 2) - (4 * a * c))));
        }
    }
}
