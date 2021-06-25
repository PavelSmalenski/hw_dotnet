using System;

namespace HW02.ArrayShifting
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = ReadInt("Pass array length");

            int[] userArray = new int[arraySize];
            for (int i = 0; i < arraySize - 1; i++)
            {
                userArray[i] = ReadInt($"Insert array value #{i + 1}");
            }
            PrintArray(userArray, "Before");

            int insertVal = ReadInt("Pass value to insert into array");
            int arrayPos = ReadArrayPosition(arraySize);

            InsertValueInArray(ref userArray, arrayPos, insertVal);
            PrintArray(userArray, "After");
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

        static int ReadArrayPosition(int arrayLength)
        {
            int arrayPos;

            while (true)
            {
                arrayPos = ReadInt("Pass position");
                if (arrayPos < 0 || arrayPos >= arrayLength)
                {
                    Console.WriteLine($"Position {arrayPos} is not valid! Correct position shoul be in [0..{arrayLength - 1}]");
                }
                else
                {
                    break;
                }
            }

            return arrayPos;
        }

        static void InsertValueInArray(ref int[] array, int pos, int val)
        {
            int oldVal, newVal = val;
            for (int i = pos; i < array.Length; i++)
            {
                oldVal = array[i];
                array[i] = newVal;
                newVal = oldVal;
            }
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
    }
}
