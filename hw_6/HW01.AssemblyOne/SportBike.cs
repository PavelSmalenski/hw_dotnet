using System;
using System.Collections.Generic;
using System.Text;

namespace HW01.AssemblyOne
{
    class SportBike : Motorcycle
    {
        public SportBike()
        {
            Console.WriteLine("SportBike init:");
            // Constants
            Console.WriteLine(MaxSpeedPublic);
            Console.WriteLine(MaxSpeedInternal);
            Console.WriteLine(MaxSpeedProtected);
            //Console.WriteLine(MaxSpeedPrivate); - doesn't work from child class even in the same project
            Console.WriteLine(MaxSpeedProtectedInternal);
            Console.WriteLine(MaxSpeedPrivateProtected);

            // Fields
            Console.WriteLine(vinNumberPublic);
            Console.WriteLine(vinNumberInternal);
            Console.WriteLine(vinNumberProtected);
            //Console.WriteLine(vinNumberPrivate); - doesn't work from child class even in the same project
            Console.WriteLine(vinNumberProtectedInternal);
            Console.WriteLine(vinNumberPrivateProtected);

            // Properties
            Console.WriteLine(OdometerPublic);
            Console.WriteLine(OdometerInternal);
            Console.WriteLine(OdometerProtected);
            //Console.WriteLine(OdometerPrivate); - doesn't work from child class even in the same project
            Console.WriteLine(OdometerProtectedInternal);
            Console.WriteLine(OdometerPrivateProtected);

            // Methods
            StartEnginePublic();
            StartEngineInternal();
            StartEngineProtected();
            //StartEnginePrivate(); - doesn't work from child class even in the same project
            StartEngineProtectedInternal();
            StartEnginePrivateProtected();
        }
    }
}
