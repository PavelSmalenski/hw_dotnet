using System;

namespace HW03.Birthday
{
    class Program
    {
        /// <summary>
        /// Request integer value from user
        /// </summary>
        /// <param name="message">Message to be printed before input</param>
        /// <returns>int: integer value from input</returns>
        static int ReadInt(string message)
        {
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();
                int resultingInt;

                if (!int.TryParse(input, out resultingInt))
                {
                    Console.WriteLine($"'{input}' is not a valid integer value, try again");
                    continue;
                }

                return resultingInt;
            }
        }

        /// <summary>
        /// Request month value
        /// </summary>
        /// <returns>int: month value</returns>
        static int ReadMonth()
        {
            while (true)
            {
                int month = ReadInt("Input month: ");

                if (month < 1 || month > 12)
                {
                    Console.WriteLine($"Invalid month value: {month}");
                    continue;
                }

                return month;
            }
        }

        /// <summary>
        /// Request year value
        /// </summary>
        /// <returns>int: year value</returns>
        static int ReadYear()
        {
            while (true)
            {
                int year = ReadInt("Input year: ");

                if (year < 0)
                {
                    Console.WriteLine($"Invalid year value: {year}");
                    continue;
                }

                return year;
            }
        }



        static void Main(string[] args)
        {
            Console.WriteLine("-- Input birthday date:");
            int bdMonth = ReadMonth();
            int bdYear = ReadYear();
            Console.WriteLine("-- Input current date:");
            int currMonth = ReadMonth();
            int currYear = ReadYear();

            int yearDiff = currYear - bdYear;
            int age = (yearDiff > 0) ? yearDiff - ((currMonth - bdMonth >= 0) ? 0 : 1) : yearDiff;

            Console.WriteLine($"Current age (years): {age}");
        }
    }
}
