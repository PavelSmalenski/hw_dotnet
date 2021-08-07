using HW01.ValidationAttribute.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace HW01.ValidationAttribute.Controls.Attributes
{
    [AttributeUsage(System.AttributeTargets.Property)]
    class CreditCardAttribute : Attribute
    {
        public bool IsValid(string value)
        {
            if (value is null)
            {
                return false;
            }

            Regex regex = new Regex(@"\d{4}([\s-]\d{4}){3}");
            if (regex.Match(value).Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
