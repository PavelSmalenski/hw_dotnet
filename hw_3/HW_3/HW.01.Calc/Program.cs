using System;

namespace HW03.Operators
{
    class Program
    {
        /// <summary>
        /// Representation of a list of implemented mathematical operations
        /// </summary>
        enum Operations
        {
            Add,
            Substract
        }

        /// <summary>
        /// Request integer input
        /// </summary>
        /// <param name="optMessage">(optional) Message to be printed before default request message</param>
        /// <returns>int: inputed integer</returns>
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

        /// <summary>
        /// Request operation to be performed on input
        /// </summary>
        /// <returns>Operations: operation to be performed</returns>
        static Operations RequestOperation()
        {
            string input;

            while (true)
            {
                Console.Write("Input operation to be performed: ");
                input = Console.ReadLine();

                if (input.Length > 1)
                {
                    Console.WriteLine($"All operations are one-char item, input '{input}' is not valid. Please, try again");
                    continue;
                }

                switch (input)
                {
                    case "+":
                        return Operations.Add;
                        break;
                    case "-":
                        return Operations.Substract;
                        break;
                    default:
                        Console.WriteLine($"Operation '{input}' is invalid or not yet supported. Please, try again");
                        break;
                }
            }
        }

        /// <summary>
        /// Summarize two numbers
        /// </summary>
        /// <param name="a">First num to summarize</param>
        /// <param name="b">Second num to summarize</param>
        /// <returns>int: sum result</returns>
        static int Add(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Substract second parameter from the first one
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <returns>int: substraction result</returns>
        static int Substract(int a, int b)
        {
            return a - b;
        }

        /// <summary>
        /// Compare provided number to value, requested in this method
        /// </summary>
        /// <param name="calcResult">Result of calculations that will be used for comparison</param>
        static void VerifyResult(int calcResult)
        {
            int valueToCheck = RequestInt(optMessage: "Value to compare with sum.");

            if (valueToCheck == calcResult)
            {
                Console.WriteLine($"Correct - inserted value ({valueToCheck}) matches the sum!");
            }
            else
            {
                Console.WriteLine($"Wrong - inserted value ({valueToCheck}) DOESN'T match the sum!");

                if (valueToCheck > calcResult)
                {
                    Console.WriteLine(" Correct sum value is LESS than input!");
                }
                else
                {
                    Console.WriteLine(" Correct sum value is GREATER than input!");
                }
            }
        }

        /// <summary>
        /// Method to perform inputs and calculations for provided inputs
        /// </summary>
        static void CalcProcessing()
        {
            while (true)
            {
                int firstValue = RequestInt(optMessage: "1."),
                    secondValue = RequestInt(optMessage: "2.");
                Operations operation = RequestOperation();

                switch (operation)
                {
                    case Operations.Add:
                        VerifyResult(Add(firstValue, secondValue));
                        break;
                    case Operations.Substract:
                        VerifyResult(Substract(firstValue, secondValue));
                        break;
                    default:
                        Console.WriteLine($"Invalid operation provided: {operation}");  // Is that... even possible?
                        break;
                }
            }
        }

        static void Main(string[] args)
        {
            CalcProcessing();
        }
    }
}
