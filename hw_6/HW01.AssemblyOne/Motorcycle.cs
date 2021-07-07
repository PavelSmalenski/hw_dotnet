using System;
using System.Collections.Generic;
using System.Text;

namespace HW01.AssemblyOne
{
    public class Motorcycle
    {
        public const ushort MaxSpeedPublic = 300;
        internal const ushort MaxSpeedInternal = 300;
        protected const ushort MaxSpeedProtected = 300;
        private const ushort MaxSpeedPrivate = 300;
        protected internal const ushort MaxSpeedProtectedInternal = 300;
        private protected const ushort MaxSpeedPrivateProtected = 300;

        public string vinNumberPublic = "@c777841-69BB-4647-A3C7-7CDB8521B816";
        internal string vinNumberInternal = "@c777841-69BB-4647-A3C7-7CDB8521B816";
        protected string vinNumberProtected = "@c777841-69BB-4647-A3C7-7CDB8521B816";
        private string vinNumberPrivate = "@c777841-69BB-4647-A3C7-7CDB8521B816";
        protected internal string vinNumberProtectedInternal = "@c777841-69BB-4647-A3C7-7CDB8521B816";
        private protected string vinNumberPrivateProtected = "@c777841-69BB-4647-A3C7-7CDB8521B816";

        public int OdometerPublic { get; set; } = 20000;
        internal int OdometerInternal { get; set; } = 20000;
        protected int OdometerProtected { get; set; } = 20000;
        private int OdometerPrivate { get; set; } = 20000;
        protected internal int OdometerProtectedInternal { get; set; } = 20000;
        private protected int OdometerPrivateProtected { get; set; } = 20000;

        public void StartEnginePublic()
        {
            Console.WriteLine("Public method");
        }
        internal void StartEngineInternal()
        {
            Console.WriteLine("Internal method");
        }
        protected void StartEngineProtected()
        {
            Console.WriteLine("Protected method");
        }
        private void StartEnginePrivate()
        {
            Console.WriteLine("Private method");
        }
        protected internal void StartEngineProtectedInternal()
        {
            Console.WriteLine("Protected Internal method");
        }
        private protected void StartEnginePrivateProtected()
        {
            Console.WriteLine("Private Protected method");
        }

        public Motorcycle()
        {
            // As expected - from inside the class everything wors fine
            Console.WriteLine("Motorcycle init:");
            // Constants
            Console.WriteLine(MaxSpeedPublic);
            Console.WriteLine(MaxSpeedInternal);
            Console.WriteLine(MaxSpeedProtected);
            Console.WriteLine(MaxSpeedPrivate);
            Console.WriteLine(MaxSpeedProtectedInternal);
            Console.WriteLine(MaxSpeedPrivateProtected);

            // Fields
            Console.WriteLine(vinNumberPublic);
            Console.WriteLine(vinNumberInternal);
            Console.WriteLine(vinNumberProtected);
            Console.WriteLine(vinNumberPrivate);
            Console.WriteLine(vinNumberProtectedInternal);
            Console.WriteLine(vinNumberPrivateProtected);

            // Properties
            Console.WriteLine(OdometerPublic);
            Console.WriteLine(OdometerInternal);
            Console.WriteLine(OdometerProtected);
            Console.WriteLine(OdometerPrivate);
            Console.WriteLine(OdometerProtectedInternal);
            Console.WriteLine(OdometerPrivateProtected);

            // Methods
            StartEnginePublic();
            StartEngineInternal();
            StartEngineProtected();
            StartEnginePrivate();
            StartEngineProtectedInternal();
            StartEnginePrivateProtected();
        }
    }

    internal class MotorcycleInternal : Motorcycle
    {

    }
}
