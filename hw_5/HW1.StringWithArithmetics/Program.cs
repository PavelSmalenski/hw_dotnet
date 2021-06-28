using System;
using System.Text;

namespace HW1.StringWithArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your string:");
            string input = Console.ReadLine();

            int operandLeft, operandRight;
            char arithmeticOperator;

            ParseStringToArithmetics(input, out operandLeft, out operandRight, out arithmeticOperator);

            Console.WriteLine($"Result of processing: {operandLeft}{arithmeticOperator}{operandRight}={CalculateExpression(operandLeft, operandRight, arithmeticOperator)}");
        }

        static void ParseStringToArithmetics(string str, out int operandLeft, out int operandRight, out char oper)
        {
            oper = ' ';

            bool isLeftProcessed = false;
            StringBuilder operandLeftSB = new StringBuilder("");
            StringBuilder operandRightSB = new StringBuilder("");

            foreach (var ch in str)
            {
                switch (ch)
                {
                    case '+':
                    case '-':
                    case '*':
                    case '/':
                        oper = ch;
                        isLeftProcessed = true;
                        continue;
                    case char c when Char.IsDigit(ch):
                        if (!isLeftProcessed)
                        {
                            operandLeftSB.Append(c);
                        }
                        else
                        {
                            operandRightSB.Append(c);
                        }
                        break;
                    default:
                        break;
                }
            }

            // Using 'Parse' here to perform value validation. Either way, even user-validation would've just printed a message and threw conversion exception
            operandLeft = int.Parse(operandLeftSB.ToString());
            operandRight = int.Parse(operandRightSB.ToString());
        }

        static int CalculateExpression(int operandLeft, int operandRight, char oper)
        {
            Func<int, int, int> operFunc;

            switch (oper)
            {
                case '+':
                    operFunc = (x, y) => { return x + y; };
                    break;
                case '-':
                    operFunc = (x, y) => { return x - y; };
                    break;
                case '*':
                    operFunc = (x, y) => { return x * y; };
                    break;
                case '/':
                    operFunc = (x, y) => { return x / y; };
                    break;
                default:
                    throw new ArithmeticException($"Unknown operator: {oper}");
            }

            return operFunc(operandLeft, operandRight);
        }
    }
}
