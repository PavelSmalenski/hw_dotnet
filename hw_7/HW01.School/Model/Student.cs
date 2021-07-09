using System;
using System.Collections.Generic;
using System.Text;

namespace HW01.School.Model
{
    class Student : Person
    {
        public void GoToClasses()
        {
            Console.WriteLine("I'm going to class");
        }

        public void ShowAge()
        {
            Console.WriteLine($"My age is {_age}");
        }

        public Student(int age) : base(age) { }
    }
}
