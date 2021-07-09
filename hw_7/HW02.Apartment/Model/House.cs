using System;
using System.Collections.Generic;
using System.Text;

namespace HW02.Apartment.Model
{
    class House
    {
        public int Area { get; set; }
        public Door HouseDoor { get; set; }

        public House(int area, string doorColor)
        {
            Area = area;
            HouseDoor = new Door(doorColor);
        }

        public void ShowData()
        {
            Console.WriteLine($"I am a house, my area is {Area} m2");
        }

        public class Door
        {
            public string Color { get; set; }

            public Door(string color)
            {
                Color = color;
            }

            public void ShowData()
            {
                Console.WriteLine($"I am a door, my color is {Color}");
            }
        }
    }
}
