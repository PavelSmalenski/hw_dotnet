using System;
using System.Diagnostics;

namespace HW03.ArrayReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] array = new int[100_000_000];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next();
            }

            Stopwatch sw = new Stopwatch();

            // PrintArray(array, "Before");
            sw.Start();
            Reverse(ref array);
            sw.Stop();
            Console.WriteLine($"User-func - Elapsed time: {sw.ElapsedMilliseconds} ms");
            // PrintArray(array, "After");

            sw.Reset();
            sw.Start();
            Array.Reverse(array);
            sw.Stop();
            Console.WriteLine($"Default-func - Elapsed time: {sw.ElapsedMilliseconds} ms");
        }

        static void Reverse(ref int[] array)
        {
            for (int i = 0, j = array.Length - 1; i < j; i++, j--)
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
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
