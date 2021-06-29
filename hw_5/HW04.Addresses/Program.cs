using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace HW04.Addresses
{
    class Program
    {
        static void Main(string[] args)
        {
            string addresses = "123 Main Street St. Louisville OH 43071,432 Main Long Road St. Louisville OH 43071,786 High Street Pollocksville NY 56432";

            Console.WriteLine("Approach using Regex:");
            Console.WriteLine(Travel(addresses, "OH 43071"));
            Console.WriteLine(Travel(addresses, "NY 56432"));
            Console.WriteLine(Travel(addresses, "NY 5643"));
            Console.WriteLine();

            Console.WriteLine("Approach WITHOUT using Regex:");
            Console.WriteLine(TravelNoRegex(addresses, "OH 43071"));
            Console.WriteLine(TravelNoRegex(addresses, "NY 56432"));
            Console.WriteLine(TravelNoRegex(addresses, "NY 5643"));
        }

        static string Travel(string addresses, string zipcode)
        {
            List<string> streetsAndTowns = new List<string>();
            List<string> houseNumbers = new List<string>();

            // regex to parse address and extract house number and zipcode
            // (group 1: house number) "\d+" - more than one digit
            // (group 2: street and town) "([^,]*)" any character except ',' (to omit splitting the string with addresses)
            // (group 3: zipcode) "[A-Z]{2}\s\d{5}" - 2 capital letters, whitespace and 5 digits
            Regex regex = new Regex(@"(\d+)\s([^,]*)\s([A-Z]{2}\s\d{5})");
            var matches = regex.Matches(addresses);
            foreach (Match match in matches)
            {
                if (zipcode.Equals(match.Groups[3].Value))
                {
                    houseNumbers.Add(match.Groups[1].Value);
                    streetsAndTowns.Add(match.Groups[2].Value);
                }
            }

            return $"{zipcode}:{string.Join(',', streetsAndTowns)}/{string.Join(',', houseNumbers)}";
        }

        static string TravelNoRegex(string addresses, string zipcode)
        {
            List<string> streetsAndTowns = new List<string>();
            List<string> houseNumbers = new List<string>();

            string[] addressesArray = addresses.Split(',');
            foreach (var address in addressesArray)
            {
                List<string> addressPositions = new List<string>(address.Split(' '));
                if (addressPositions.Count >= 4) // Single address item should have at least 3 whitespaces (resulting into at least 4 items): 1) After houseNumber 2)before zipcode 3) inside zipcode
                {
                    if (int.TryParse(addressPositions[0], out _) && // Check that first item is numeric == house number
                        addressPositions[addressPositions.Count - 2].Length == 2 && CheckStrCapitalCharsOnly(addressPositions[addressPositions.Count - 2]) && //... second item from the end of array is 2-char part of zipcode
                        addressPositions[addressPositions.Count - 1].Length == 5 && int.TryParse(addressPositions[addressPositions.Count - 1], out _)) //... first item from the end of array is 5-digit part of zipcode
                    {
                        if (zipcode.Equals($"{addressPositions[addressPositions.Count - 2]} {addressPositions[addressPositions.Count - 1]}"))
                        {
                            houseNumbers.Add(addressPositions[0]);
                            streetsAndTowns.Add(string.Join(' ', addressPositions.GetRange(1, addressPositions.Count - 3))); // Exclude first and two last items from the set == extract "street and town" part of address
                        }
                    }
                }
            }

            return $"{zipcode}:{string.Join(',', streetsAndTowns)}/{string.Join(',', houseNumbers)}";
        }

        static bool CheckStrCapitalCharsOnly(string str)
        {
            bool result = true;
            foreach (var ch in str)
            {
                if (!('A' <= ch && ch <= 'Z'))
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
    }
}
