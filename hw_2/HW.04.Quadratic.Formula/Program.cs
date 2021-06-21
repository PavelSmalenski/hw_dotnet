using System;

namespace HW._04.Quadratic.Formula
{
    class Program
    {
        static double GetQuadraticParameter(string variableName)
        {
            string input;
            double param;

            do
            {
                Console.Write($"Input parameter '{variableName}': ");
                input = Console.ReadLine();
            } while (!double.TryParse(input, out param));

            return param;
        }

        static void CalculateQuadraticRoots(double a, double b, double c, out double x1, out double x2)
        {
            x1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
            x2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
            return;
        }

        static void Main(string[] args)
        {
            double a, b, c, x1, x2;

            a = GetQuadraticParameter("A");
            b = GetQuadraticParameter("B");
            c = GetQuadraticParameter("C");

            CalculateQuadraticRoots(a, b, c, out x1, out x2);

            if (double.IsNaN(x1) || double.IsNaN(x2))
            {
                Console.WriteLine($"Parameters A='{a}', B='{b}', C='{c}' doesn't have roots that can be represented without 'imaginary unit (i)'!");
            }
            else
            {
                Console.WriteLine($"Roots for parameters A='{a}', B='{b}', C='{c}' are:\n '{x1}', '{x2}'");
            }
        }
    }
}
