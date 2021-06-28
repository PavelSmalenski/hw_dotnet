using System;
using System.Collections.Generic;

namespace HW03.StrArrayConditionalSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] a1 = { "arp", "live", "strong" };
            //string[] a1 = { "tarp", "mice", "bull" };
            string[] a1 = { "live", "arp", "strong", "test" };
            string[] a2 = { "lively", "alive", "harp", "sharp", "armstrong" };
            string[] r;

            List<string> a1Sorted = new List<string>(CleanArrayOnSubstrExistence(a1, a2));
            a1Sorted.Sort(StringComparer.Ordinal);
            r = a1Sorted.ToArray();

            Console.WriteLine($"Result: {string.Join(", ", r)}");
        }

        static string[] CleanArrayOnSubstrExistence(string[] arr, string[] conditionArray)
        {
            List<string> listCleaned = new List<string>();
            foreach (var arrWord in arr)
            {
                bool isSubstr = false;
                foreach (var conditionArrayWord in conditionArray)
                {
                    if (conditionArrayWord.Contains(arrWord))
                    {
                        isSubstr = true;
                        break;
                    }
                }

                if (isSubstr)
                {
                    listCleaned.Add(arrWord);
                }
            }
            return listCleaned.ToArray();
        }
    }
}
