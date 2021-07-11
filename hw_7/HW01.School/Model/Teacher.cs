using System;
using System.Collections.Generic;
using System.Text;

namespace HW01.School.Model
{
    class Teacher : Person
    {
        private string _subject;

        public void Explain()
        {
            Console.WriteLine($"Explanation begins: {_subject}");
        }

        public Teacher(int age, string subject) : base(age)
        {
            _subject = subject;
        }
    }
}
