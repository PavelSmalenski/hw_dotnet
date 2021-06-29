using System;

namespace HW03.Alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            for (char i = 'z' ; i >= 'a' ; i--)  // As char is a (kind of) numeric type - it can be used in iteration directly)
            {
                Console.WriteLine(i);
            }
        }
    }
}
