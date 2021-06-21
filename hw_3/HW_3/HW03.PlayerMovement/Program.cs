using System;

namespace HW03.PlayerMovement
{
    class Program
    {
        static void Main(string[] args)
        {
            char currentRotation = 'w';

            while (true)
            {
                bool isInvalidKey = false;
                char inputKey = char.ToLower(Console.ReadKey().KeyChar);

                if (currentRotation == inputKey)
                {
                    Console.WriteLine(" -- rotation skipped --");
                    continue;
                }

                switch (inputKey)
                {
                    case 'w':
                        Console.WriteLine(" -- rotating UP --");
                        break;
                    case 'a':
                        Console.WriteLine(" -- rotating LEFT --");
                        break;
                    case 's':
                        Console.WriteLine(" -- rotating DOWN --");
                        break;
                    case 'd':
                        Console.WriteLine(" -- rotating RIGHT --");
                        break;
                    default:
                        isInvalidKey = true;
                        break;
                }

                if (!isInvalidKey)
                {
                    currentRotation = inputKey;
                }
                else
                {
                    isInvalidKey = false;
                }
            }
        }
    }
}
