using System;

namespace HW._02.Casting
{
    class Program
    {
        static void Main(string[] args)
        {

            // Task a = explicit conversion
            int i = 99;

            uint a_uint = (uint)i;
            ushort a_ushort = (ushort)i;
            short a_short = (short)i;
            char a_char = (char)i;
            byte a_byte = (byte)i;

            // Task b - implicit conversion
            byte b = 128;

            ushort b_ushort = b;
            uint b_uint = b;
            short b_short = b;
            int b_int = b;
            long b_long = b;

            // Task c - boxing
            object c_ushort = (object)b_ushort;
            object c_uint = (object)b_uint;
            object c_short = (object)b_short;
            object c_int = (object)b_int;
            object c_long = (object)b_long;

            // Task d - unboxing
            ushort d_ushort = (ushort)c_ushort;
            uint d_uint = (uint)c_uint;
            short d_short = (short)c_short;
            int d_int = (int)c_int;
            long d_long = (long)c_long;
        }
    }
}
