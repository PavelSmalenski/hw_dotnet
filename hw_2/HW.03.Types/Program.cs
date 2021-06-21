using System;

namespace HW._03.Types
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte @sbyte = 0;
            Console.WriteLine(@sbyte.GetType());
            SByte @SByte = 0;
            Console.WriteLine(@SByte.GetType());

            short @Short = 0;
            Console.WriteLine(@Short.GetType());
            Int16 @Int16 = 0;
            Console.WriteLine(@Int16.GetType());

            int @int = 0;
            Console.WriteLine(@int.GetType());
            Int32 @Int32 = 0;
            Console.WriteLine(@Int32.GetType());

            long @long = 0;
            Console.WriteLine(@long.GetType());
            Int64 @Int64 = 0;
            Console.WriteLine(@Int64.GetType());

            byte @byte = 0;
            Console.WriteLine(@byte.GetType());
            Byte @Byte = 0;
            Console.WriteLine(@Byte.GetType());

            ushort @ushort = 0;
            Console.WriteLine(@ushort.GetType());
            UInt16 @UInt16 = 0;
            Console.WriteLine(@UInt16.GetType());

            char @char = ' ';
            Console.WriteLine(@char.GetType());
            Char @Char = ' ';
            Console.WriteLine(@Char.GetType());

            uint @uint = 0;
            Console.WriteLine(@uint.GetType());
            UInt32 @UInt32 = 0;
            Console.WriteLine(@UInt32.GetType());

            ulong @ulong = 0;
            Console.WriteLine(@ulong.GetType());
            UInt64 @UInt64 = 0;
            Console.WriteLine(@UInt64.GetType());

            float @float = 0;
            Console.WriteLine(@float.GetType());
            Single @Single = 0;
            Console.WriteLine(@Single.GetType());

            double @double = 0;
            Console.WriteLine(@double.GetType());
            Double @Double = 0;
            Console.WriteLine(@Double.GetType());

            decimal @decimal = 0;
            Console.WriteLine(@decimal.GetType());
            Decimal @Decimal = 0;
            Console.WriteLine(@Decimal.GetType());

            object @object = 0;
            Console.WriteLine(@object.GetType());
            Object @Object = 0;
            Console.WriteLine(@Object.GetType());

            string @string = "abc";
            Console.WriteLine(@string.GetType());
            String @String = "abc";
            Console.WriteLine(@String.GetType());
        }
    }
}
