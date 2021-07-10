using System;
using System.Collections.Generic;
using System.Text;

namespace HW04.Booking.Com.Models
{
    class Hotel
    {
        private List<Apartment> _apartments = new List<Apartment>();
        public string Country { get; private set; }
        public string City { get; private set; }
        public string Name { get; private set; }

        public Hotel(string country, string city, string name)
        {
            Country = country;
            City = city;
            Name = name;
        }

        internal void AddApartment(Apartment apartment)
        {
            _apartments.Add(apartment);
        }

        public Apartment[] GetApartments()
        {
            return _apartments.ToArray();
        }
    }
}
