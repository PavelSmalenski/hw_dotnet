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
    public class GuidAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return Guid.TryParse((string)value, out _);
        }
    }
}
