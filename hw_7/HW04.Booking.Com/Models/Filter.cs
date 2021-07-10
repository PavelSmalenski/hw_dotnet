using System;
using System.Collections.Generic;
using System.Text;

namespace HW04.Booking.Com.Models
{
    class Filter
    {
        public enum FilterType
        {
            Country,
            City,
            RoomsCount,
            BedsCount,
            CostGt,
            CostLt
        }

        public FilterType Type { get; private set; }
        public string Value { get; private set; }

        public Filter(Filter.FilterType type, string value)
        {
            Type = type;
            Value = value;
        }
    }
}
