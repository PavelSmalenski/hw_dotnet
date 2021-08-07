using HW01.ValidationAttribute.Models;
using System;

namespace HW01.ValidationAttribute
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] creditCardNumbers = new string[] { "123", "1234-5678-9012-3456", "1234 5678 9012 3456" };

            foreach (var creditCardNumber in creditCardNumbers)
            {
                var purchaseMotorcycle = new PurchaseMotorcycle(creditCardNumber);

                if (purchaseMotorcycle.Validate())
                {
                    Console.WriteLine($"{creditCardNumber} is a valid value");
                }
                else
                {
                    Console.WriteLine($"{creditCardNumber} is NOT a valid value");
                }
            }

        }
    }
}
