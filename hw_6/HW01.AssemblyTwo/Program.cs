using HW01.AssemblyOne;
using System;

namespace HW01.AssemblyTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("AssemblyTwo - classes test");
            var motorcycle = new Motorcycle();
            //var motorcycleInternal = new MotorcycleInternal(); // different projects - not accessible

            Console.WriteLine("Assembly - Motorcycle test:");
            // Constants
            Console.WriteLine(Motorcycle.MaxSpeedPublic);
            //Console.WriteLine(Motorcycle.MaxSpeedInternal); - inaccessible as it is another project
            //Console.WriteLine(Motorcycle.MaxSpeedProtected); - inaccessible as it is 'protected' and only accessible from class itself
            //Console.WriteLine(Motorcycle.MaxSpeedPrivate); - inaccessible as it is 'protected' and only accessible from class itself or it's child
            //Console.WriteLine(Motorcycle.MaxSpeedProtectedInternal); - inaccessible as it is another project and NOT part of the code of child class (of any project)
            //Console.WriteLine(Motorcycle.MaxSpeedPrivateProtected); - inaccessible as 1) it is another project; 2)only accessible from class itself or it's child

            // Fields
            Console.WriteLine(motorcycle.vinNumberPublic);
            //Console.WriteLine(motorcycle.vinNumberInternal); - inaccessible as it is another project
            //Console.WriteLine(motorcycle.vinNumberProtected); - inaccessible as it is 'protected' and only accessible from class itself
            //Console.WriteLine(motorcycle.vinNumberPrivate); - inaccessible as it is 'protected' and only accessible from class itself or it's child
            //Console.WriteLine(motorcycle.vinNumberProtectedInternal); - inaccessible as it is another project and NOT part of the code of child class (of any project)
            //Console.WriteLine(motorcycle.vinNumberPrivateProtected); - inaccessible as 1) it is another project; 2)only accessible from class itself or it's child

            // Properties
            Console.WriteLine(motorcycle.OdometerPublic);
            //Console.WriteLine(motorcycle.OdometerInternal); - inaccessible as it is another project
            //Console.WriteLine(motorcycle.OdometerProtected); - inaccessible as it is 'protected' and only accessible from class itself
            //Console.WriteLine(motorcycle.OdometerPrivate); - inaccessible as it is 'protected' and only accessible from class itself or it's child
            //Console.WriteLine(motorcycle.OdometerProtectedInternal); - inaccessible as it is another project and NOT part of the code of child class (of any project)
            //Console.WriteLine(motorcycle.OdometerPrivateProtected); - inaccessible as 1) it is another project; 2)only accessible from class itself or it's child

            // Methods
            motorcycle.StartEnginePublic();
            //motorcycle.StartEngineInternal(); - inaccessible as it is another project
            //motorcycle.StartEngineProtected(); - inaccessible as it is 'protected' and only accessible from class itself
            //motorcycle.StartEnginePrivate(); - inaccessible as it is 'protected' and only accessible from class itself or it's child
            //motorcycle.StartEngineProtectedInternal(); - inaccessible as it is another project and NOT part of the code of child class (of any project)
            //motorcycle.StartEnginePrivateProtected(); - inaccessible as 1) it is another project; 2)only accessible from class itself or it's child
        }
    }
}
