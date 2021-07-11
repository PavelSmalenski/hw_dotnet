using System;
using System.Collections.Generic;
using System.Text;

namespace HW04.Booking.Com.Models
{
    class Apartment
    {
        public int RoomsCount { get; private set; }
        public int BedsCount { get; private set; }
        public int Cost { get; private set; }

        public Apartment(int roomsCount, int bedsCount, int cost)
        {
            RoomsCount = roomsCount;
            BedsCount = bedsCount;
            Cost = cost;
        }

        public override string ToString()
        {
            return $"Rooms: {RoomsCount} - Beds: {BedsCount} - Cost: {Cost}";
        }
    }
}
