using HW02.Apartment.Model;
using System;

namespace HW02.Apartment
{
    class Program
    {
        static void Main(string[] args)
        {
            var house = new SmallApartment("Red");
            var person = new Person("Bob", house);

            person.ShowData();
        }
    }
}
