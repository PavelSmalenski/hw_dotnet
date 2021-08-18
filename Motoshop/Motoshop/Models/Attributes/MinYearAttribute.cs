using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Motoshop.Models.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    // According to definitions (decompile/interfaces description) Validation Attributes were
    //    inherited from ValidationAttribute and not DataTypeAttribute
    public class MinYearAttribute : ValidationAttribute
    {
        private int _minYear;

        public MinYearAttribute(int minYear)
        {
            _minYear = minYear;
        }

        public override bool IsValid(object value)
        {
            return ((DateTime)value).Year >= _minYear && (DateTime)value <= DateTime.Now;
        }
    }
}
