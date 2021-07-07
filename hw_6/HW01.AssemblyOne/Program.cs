using System;

namespace HW01.AssemblyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("AssemblyOne - classes test");
            var motorcycle = new Motorcycle();
            var motorcycleInternal = new MotorcycleInternal(); // same project - working fine

            Console.WriteLine("AssemblyOne - Motorcycle test:");
            // Constants
            Console.WriteLine(Motorcycle.MaxSpeedPublic);
            Console.WriteLine(Motorcycle.MaxSpeedInternal);
            //Console.WriteLine(Motorcycle.MaxSpeedProtected); - inaccessible as it is 'protected' and only accessible from class itself
            //Console.WriteLine(Motorcycle.MaxSpeedPrivate); - inaccessible as it is 'protected' and only accessible from class itself or it's child
            Console.WriteLine(Motorcycle.MaxSpeedProtectedInternal);
            //Console.WriteLine(Motorcycle.MaxSpeedPrivateProtected); - inaccessible even though it is in the same project - only accessible from class itself or it's child

            // Fields
            Console.WriteLine(motorcycle.vinNumberPublic);
            Console.WriteLine(motorcycle.vinNumberInternal);
            //Console.WriteLine(motorcycle.vinNumberProtected); - inaccessible as it is 'protected' and only accessible from class itself
            //Console.WriteLine(motorcycle.vinNumberPrivate); - inaccessible as it is 'protected' and only accessible from class itself or it's child
            Console.WriteLine(motorcycle.vinNumberProtectedInternal);
            //Console.WriteLine(motorcycle.vinNumberPrivateProtected); - inaccessible even though it is in the same project - only accessible from class itself or it's child

            // Properties
            Console.WriteLine(motorcycle.OdometerPublic);
            Console.WriteLine(motorcycle.OdometerInternal);
            //Console.WriteLine(motorcycle.OdometerProtected); - inaccessible as it is 'protected' and only accessible from class itself
            //Console.WriteLine(motorcycle.OdometerPrivate); - inaccessible as it is 'protected' and only accessible from class itself or it's child
            Console.WriteLine(motorcycle.OdometerProtectedInternal);
            //Console.WriteLine(motorcycle.OdometerPrivateProtected); - inaccessible even though it is in the same project - only accessible from class itself or it's child

            // Methods
            motorcycle.StartEnginePublic();
            motorcycle.StartEngineInternal();
            //motorcycle.StartEngineProtected(); - inaccessible as it is 'protected' and only accessible from class itself
            //motorcycle.StartEnginePrivate(); - inaccessible as it is 'protected' and only accessible from class itself or it's child
            motorcycle.StartEngineProtectedInternal();
            //motorcycle.StartEnginePrivateProtected(); - inaccessible even though it is in the same project - only accessible from class itself or it's child
        }
    }
}
