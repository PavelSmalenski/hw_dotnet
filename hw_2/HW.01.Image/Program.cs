using System;
using System.IO;

namespace HW._01.Image
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Open input text file
            //2. Read whole input text file into string
            //3. Split text (inside string) into separate "bytes"
            //4. Create array to store converted byte data
            //5. Process each text-like "byte" by converting it to numeric value and save into byte array
            //6. Write byte array into output file

            const string inFileLocation = @"C:\dotNetCourses\image.txt";
            const string outFileLocation = @"C:\dotNetCourses\image.png";

            StreamReader textReader = new StreamReader(inFileLocation);
            string textReaderResult = textReader.ReadToEnd();
            textReader.Dispose();

            string[] arrayOfTextResult = textReaderResult.Split(' ');
            byte[] imageBytes = new byte[arrayOfTextResult.Length - 1]; // Last item in arrayOfTextResult contain an empty item as 'space' char was written to output as last char
            for (int i = 0; i < arrayOfTextResult.Length - 1; i++)
            {
                imageBytes[i] = Convert.ToByte(arrayOfTextResult[i], 2);
            }

            File.WriteAllBytes(outFileLocation, imageBytes);
        }
    }
}
