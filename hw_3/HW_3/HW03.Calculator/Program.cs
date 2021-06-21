using System;

namespace HW03.Calculator
{
    class Calculator
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Substract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static int Div(int a, int b)
        {
            return a / b;
        }

        public static int Mod(int a, int b)
        {
            return a % b;
        }

        public static double CircleArea(int radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            string inputStr;


            Console.WriteLine("-- Add --");
            int add_a, add_b;

            Console.WriteLine("Input first value: ");
            inputStr = Console.ReadLine();
            add_a = Convert.ToInt32(inputStr);

            Console.WriteLine("Input second value: ");
            inputStr = Console.ReadLine();
            add_b = Convert.ToInt32(inputStr);

            Console.WriteLine($"Add result: {Calculator.Add(add_a, add_b)}");


            Console.WriteLine("-- Substract --");
            int sub_a, sub_b;

            Console.WriteLine("Input first value: ");
            inputStr = Console.ReadLine();
            sub_a = Convert.ToInt32(inputStr);

            Console.WriteLine("Input second value: ");
            inputStr = Console.ReadLine();
            sub_b = Convert.ToInt32(inputStr);

            Console.WriteLine($"Substract result: {Calculator.Substract(sub_a, sub_b)}");


            Console.WriteLine("-- Multiply --");
            int mult_a, mult_b;

            Console.WriteLine("Input first value: ");
            inputStr = Console.ReadLine();
            mult_a = Convert.ToInt32(inputStr);

            Console.WriteLine("Input second value: ");
            inputStr = Console.ReadLine();
            mult_b = Convert.ToInt32(inputStr);

            Console.WriteLine($"Multiply result: {Calculator.Multiply(mult_a, mult_b)}");


            Console.WriteLine("-- Div --");
            int div_a, div_b;

            Console.WriteLine("Input first value: ");
            inputStr = Console.ReadLine();
            div_a = Int32.Parse(inputStr);

            Console.WriteLine("Input second value: ");
            inputStr = Console.ReadLine();
            div_b = Int32.Parse(inputStr);

            Console.WriteLine($"Div result: {Calculator.Div(div_a, div_b)}");


            Console.WriteLine("-- Mod --");
            int mod_a, mod_b;

            Console.WriteLine("Input first value: ");
            inputStr = Console.ReadLine();
            mod_a = Int32.Parse(inputStr);

            Console.WriteLine("Input second value: ");
            inputStr = Console.ReadLine();
            mod_b = Int32.Parse(inputStr);

            Console.WriteLine($"Mod result: {Calculator.Mod(mod_a, mod_b)}");


            Console.WriteLine("-- CircleArea --");
            int area_radius;

            Console.WriteLine("Input radius value: ");
            inputStr = Console.ReadLine();
            area_radius = Int32.Parse(inputStr);

            Console.WriteLine($"CircleArea result: {Calculator.CircleArea(area_radius)}");
        }
    }
}
