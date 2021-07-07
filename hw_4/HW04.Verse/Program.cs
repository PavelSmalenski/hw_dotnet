using System;

namespace HW04.Verse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a verse, with rows separated by ';'");
            string input = Console.ReadLine();

            string[] rows = input.Split(';');

            // P.S.: I'd assume that in this task order of actions is immutable. Because, replace-split would've been easier than split-replace
            for (int i = 0; i < rows.Length; i++)
            {
                rows[i] = rows[i].Replace('O', 'A').Trim();
                if (!String.IsNullOrEmpty(rows[i]))
                {
                    Console.WriteLine("- " + rows[i]);
                }
            }
        }
    }
}
