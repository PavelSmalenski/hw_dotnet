using System;
using System.Collections.Generic;
using System.Text;

namespace HW02.Apartment.Model
{
    class Person
    {
        House _house;
        public string Name { get; set; }

        public Person(string name, House house)
        {
            Name = name;
            _house = house;
        }

        public void ShowData()
        {
            Console.WriteLine($"Hi, my name is {Name}");

            Console.Write("I have a house: ");
            _house.ShowData();

            Console.Write("This house have a door: ");
            _house.HouseDoor.ShowData();
        }
    }
}
