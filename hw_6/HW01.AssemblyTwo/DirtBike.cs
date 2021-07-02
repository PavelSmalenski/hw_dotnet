using HW01.AssemblyOne;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW01.AssemblyTwo
{
    public class DirtBike : Motorcycle
    {
        public DirtBike()
        {
            Console.WriteLine("DirtBike init:");
            // Constants
            Console.WriteLine(MaxSpeedPublic);
            //Console.WriteLine(MaxSpeedInternal); - doesn't work from child class in another project
            Console.WriteLine(MaxSpeedProtected);
            //Console.WriteLine(MaxSpeedPrivate); - doesn't work from child class
            Console.WriteLine(MaxSpeedProtectedInternal); // Working fine as this is a child class
            //Console.WriteLine(MaxSpeedPrivateProtected); - doesn't work from another project

            // Fields
            Console.WriteLine(vinNumberPublic);
            //Console.WriteLine(vinNumberInternal); - doesn't work from child class in another project
            Console.WriteLine(vinNumberProtected);
            //Console.WriteLine(vinNumberPrivate); - doesn't work from child class
            Console.WriteLine(vinNumberProtectedInternal); // Working fine as this is a child class
            //Console.WriteLine(vinNumberPrivateProtected); - doesn't work from another project

            // Properties
            Console.WriteLine(OdometerPublic);
            //Console.WriteLine(OdometerInternal); - doesn't work from child class in another project
            Console.WriteLine(OdometerProtected);
            //Console.WriteLine(OdometerPrivate); - doesn't work from child class
            Console.WriteLine(OdometerProtectedInternal); // Working fine as this is a child class
            //Console.WriteLine(OdometerPrivateProtected); - doesn't work from another project

            // Methods
            StartEnginePublic();
            //StartEngineInternal(); - doesn't work from child class in another project
            StartEngineProtected();
            //StartEnginePrivate(); - doesn't work from child class
            StartEngineProtectedInternal(); // Working fine as this is a child class
            //StartEnginePrivateProtected(); - doesn't work from another project
        }
    }
}
