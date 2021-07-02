using System;

namespace HW02.MotorcycleCompany
{
    class Program
    {
        static string GetString(string msg)
        {
            Console.WriteLine(msg);
            return Console.ReadLine();
        }

        static int GetInt(string msg)
        {
            Console.WriteLine(msg);

            string input;
            int parsedInput;
            while (true)
            {
                input = Console.ReadLine();
                if (int.TryParse(input, out parsedInput))
                {
                    break;
                }
            }

            return parsedInput;
        }

        static void Main(string[] args)
        {
            Motorcycle[] motorcycles = new Motorcycle[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Creating motorcycle #{i + 1}:");
                string model = GetString(" Input model:");
                string manufacturer = GetString(" Input manufacturer:");
                int mileage = GetInt(" Input mileage:");
                int volume = GetInt(" Input volume:");
                int power = GetInt(" Input power:");

                motorcycles[i] = new Motorcycle(
                    model, manufacturer, mileage, volume, power, Motorcycle.Engine.EngineType.Gasoline); // Task had nothing re EngineType input!
            }

            foreach (var motorcycle in motorcycles)
            {
                Console.WriteLine(motorcycle);
            }
        }
    }
}
