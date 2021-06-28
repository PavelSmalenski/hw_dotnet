using System;
using System.Text;

namespace HW02.CharactersModification
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your string:");
            StringBuilder inputSB = new StringBuilder(Console.ReadLine());

            int i = 0;
            bool isQuestionMarkProcessed = false;
            while (i < inputSB.Length)
            {
                switch (inputSB[i])
                {
                    case '!':
                    case '.':
                        inputSB.Remove(i, 1);
                        break;
                    case '?':
                        isQuestionMarkProcessed = true;
                        break;
                    default:
                        i++;
                        break;
                }

                if (isQuestionMarkProcessed)
                {
                    break;
                }
            }

            inputSB.Replace(' ', '_', i, inputSB.Length - i); // "Length - index" = length of a substring to the right of this index's position + char at position of index

            Console.WriteLine($"Result: {inputSB.ToString()}");
        }
    }
}
