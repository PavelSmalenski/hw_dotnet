using System;

namespace HW03.ParseTryParse.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string inValue = "123";

            int testParse = int.Parse(inValue);


            // As it looks - both this methods will try to use Number.Parsing.TryParseInt32IntegerStyle()
            //  inside them either way. TryParseInt32IntegerStyle as a result of handling provided
            //  parameters will try to return one of values of internal ENUM, called ParsingStatus.
            //  After that:
            //  - TryParse will compare this value to ParsingStatus.OK and return bool
            //  - Parse will also compare it to ParsingStatus.OK BUT instead of returning bool will throw exception instead of returning bool

            int testTryParse;
            int.TryParse(inValue, out testTryParse);
        }
    }
}
