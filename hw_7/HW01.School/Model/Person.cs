using System;
using System.Collections.Generic;
using System.Text;

namespace HW01.School.Model
{
    class Person
    {
        protected int _age;

        public void SetAge(int n)
        {
            _age = n;
        }

        public Person(int age)
        {
            _age = age;
        }

        public void SayHello()
        {
            Console.WriteLine($"Hello from {this.GetType()}");
        }
    }
}
