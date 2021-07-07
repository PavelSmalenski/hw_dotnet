using System;

namespace HW01.ArraysSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = ReadInt("Input array size");

            int[] userArray = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                userArray[i] = ReadInt($"Insert array value #{i + 1}");
            }

            int[] randArray = new int[arraySize];
            Random rand = new Random();
            for (int i = 0; i < arraySize; i++)
            {
                randArray[i] = rand.Next(-100, 101);
            }

            int[] sumArray = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                sumArray[i] = userArray[i] + randArray[i];
            }

            PrintArray(userArray, "User-inserted array:");
            PrintArray(randArray, "Random array:");
            PrintArray(sumArray, "Array with sum:");
        }

        static void PrintArray(int[] array, string message = null)
        {
            if (!string.IsNullOrEmpty(message))
            {
                Console.WriteLine(message);
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i != array.Length - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine();
        }

        static int ReadInt(string message)
        {
            Console.Write(message + ": ");

            int result;
            while (true)
            {
                string input = Console.ReadLine();

                if (int.TryParse(input, out result))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Inserted number is not int, try again!");
                }
            }

            return result;
        }
    }
}
