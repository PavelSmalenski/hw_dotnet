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

        static void VerifyResult(int sum)
        {
            int valueToCheck = RequestInt(optMessage: "Value to compare with sum.");

            if (valueToCheck == sum)
            {
                Console.WriteLine($"Correct - inserted value ({valueToCheck}) matches the sum!");
            }
            else
            {
                Console.WriteLine($"Wrong - inserted value ({valueToCheck}) DOESN'T match the sum!");
            }
        }

        static int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        static void Main(string[] args)
        {
            int firstValue = RequestInt(optMessage: "1."),
                secondValue = RequestInt(optMessage: "2.");

            VerifyResult(Add(firstValue, secondValue));
        }
    }
}
