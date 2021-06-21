using System;

namespace HW._01.Calc
{
    class Program
    {
        static int RequestInt(string optMessage = "")
        {
            string input;
            int outputInt;

            while (true)
            {
                Console.Write($"{optMessage} Input an integer: ");
                input = Console.ReadLine();

                bool isParsedSuccessfully = int.TryParse(input, out outputInt);
                if (!isParsedSuccessfully)
                {
                    Console.WriteLine($"'{input}' is not a valid integer value! Try again");
                }
                else
                {
                    break;
                }
            }

            return outputInt;
        }

        static int Add(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine($"Add was called. Sum of tw0 provided integers is: {sum}");
            return sum;
        }

        static void Main(string[] args)
        {
            int firstValue = RequestInt(optMessage: "1."),
                secondValue = RequestInt(optMessage: "2.");

            Add(firstValue, secondValue);
        }
    }
}
