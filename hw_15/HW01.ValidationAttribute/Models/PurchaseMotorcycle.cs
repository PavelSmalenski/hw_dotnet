using HW01.ValidationAttribute.Controls.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW01.ValidationAttribute.Models
{
    class PurchaseMotorcycle
    {
        [CreditCard]
        public string CreditCardNumber { get; set; }

        public PurchaseMotorcycle(string creditCardNumber)
        {
            CreditCardNumber = creditCardNumber;
        }

        public bool Validate()
        {
            foreach (var propertyInfo in this.GetType().GetProperties())
            {
                foreach (var attribute in propertyInfo.GetCustomAttributes(true))
                {
                    var creditCardAttribute = attribute as CreditCardAttribute;
                    if (creditCardAttribute != null)
                    {
                        if (!creditCardAttribute.IsValid(propertyInfo.GetValue(this) as string))
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}
