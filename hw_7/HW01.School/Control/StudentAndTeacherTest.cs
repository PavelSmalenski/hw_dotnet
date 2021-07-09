using HW01.School.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW01.School.Control
{
    class StudentAndTeacherTest
    {
        public static void PersonSayHello()
        {
            var person = new Person(18);
            person.SayHello();
        }

        public static void StudentSayHello()
        {
            var student = new Student(21);
            student.SayHello();
            student.ShowAge();
        }

        public static void TeacherExplain()
        {
            var teacher = new Teacher(30, "Math");
            teacher.SayHello();
            teacher.Explain();
        }
    }
}
