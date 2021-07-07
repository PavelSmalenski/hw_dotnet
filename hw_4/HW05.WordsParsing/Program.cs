using System;
using System.Linq;
using System.Text;

namespace HW05.WordsParsing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input string:");
            string input = Console.ReadLine();

            Console.WriteLine($"String without longest word: {RemoveLongestWord(input)}");
            Console.WriteLine($"LW and SW swapped: {SwapLongestAndShortest(input)}");
            int lettersCount, punctuationCount;
            CountLettersAndPunctuation(input, out lettersCount, out punctuationCount);
            Console.WriteLine($"Letters count: {lettersCount}; Punctuation count: {punctuationCount}");
            Console.WriteLine($"Sorted by words length descending: {string.Join(" ", SortWordsByLength(input))}");
        }

        static string RemoveLongestWord(string str)
        {
            var sb = new StringBuilder(str);

            string lw = GetLongestWord(str);
            if (!string.IsNullOrEmpty(lw))
            {
                int lwPosition = str.IndexOf(lw);
                sb = sb.Remove(lwPosition, lw.Length);

                return sb.Replace("  ", " ").ToString();
            }
            else
            {
                return str;
            }
        }

        static string SwapLongestAndShortest(string str)
        {
            var sb = new StringBuilder(str);

            string sw = GetShortestWord(str);
            string lw = GetLongestWord(str);

            int sw_pos = str.IndexOf(sw);
            int lw_pos = str.IndexOf(lw);

            // First replace the item in the most RIGHT of the string to maintain it's position
            if (sw_pos < lw_pos)
            {
                sb.Replace(lw, sw, lw_pos, lw.Length);
                sb.Replace(sw, lw, sw_pos, sw.Length);
            }
            else
            {
                sb.Replace(sw, lw, sw_pos, sw.Length);
                sb.Replace(lw, sw, lw_pos, lw.Length);
            }

            return sb.ToString();
        }

        static void CountLettersAndPunctuation(string str, out int lettersCount, out int punctuationCount)
        {
            lettersCount = 0;
            punctuationCount = 0;

            foreach (var ch in str)
            {
                if (char.IsPunctuation(ch))
                {
                    punctuationCount++;
                }
                if (char.IsLetter(ch))
                {
                    lettersCount++;
                }
            }
        }

        static string[] SortWordsByLength(string str)
        {
            string[] words = GetWords(str);
            return words.OrderByDescending(s => s.Length).ToArray();
        }

        static string RemovePunctuation(string str)
        {
            var sb = new StringBuilder();
            
            foreach (char ch in str)
            {
                if (!char.IsPunctuation(ch))
                    sb.Append(ch);
            }

            return sb.ToString();
        }

        static string? GetLongestWord(string str)
        {
            // Will return FIRST longest word
            str = RemovePunctuation(str);

            string[] words = GetWords(str);
            if (words.Length == 0)
            {
                return null;
            }

            string longestWord = words[0];
            foreach (var word in words)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }

            return longestWord;
        }

        static string GetShortestWord(string str)
        {
            // Will return FIRST shortest word
            str = RemovePunctuation(str);

            string[] words = GetWords(str);
            if (words.Length == 0)
            {
                return null;
            }

            string shortestWord = words[0];
            foreach (var word in words)
            {
                if (word.Length < shortestWord.Length)
                {
                    shortestWord = word;
                }
            }

            return shortestWord;
        }

        static string[] GetWords(string str)
        {
            str = RemovePunctuation(str);
            return str.Split(' ');
        }
    }
}
