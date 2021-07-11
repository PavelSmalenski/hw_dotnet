using HW04.Booking.Com.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW04.Booking.Com.Controls
{
    class ApartmentsCatalog
    {
        List<Hotel> _hotels = new List<Hotel>();


        public ApartmentsCatalog()
        {
            DataInit();
        }
        private void DataInit() //For some random data initialization
        {
            _hotels.Add(new Hotel("Belarus", "Minsk", "SomeMinskHotel1"));
            _hotels[0].AddApartment(new Apartment(1, 1, 100));
            _hotels[0].AddApartment(new Apartment(2, 2, 200));
            _hotels[0].AddApartment(new Apartment(3, 3, 300));
            _hotels.Add(new Hotel("Belarus", "Minsk", "SomeMinskHotel2"));
            _hotels[1].AddApartment(new Apartment(1, 1, 100));
            _hotels[1].AddApartment(new Apartment(2, 2, 200));
            _hotels[1].AddApartment(new Apartment(3, 3, 300));
            _hotels.Add(new Hotel("Lithuania", "Vilnus", "SomeVilnusHotel1"));
            _hotels[2].AddApartment(new Apartment(1, 1, 100));
            _hotels[2].AddApartment(new Apartment(2, 2, 200));
            _hotels[2].AddApartment(new Apartment(3, 3, 300));
            _hotels.Add(new Hotel("Lithuania", "Vilnus", "SomeVilnusHotel2"));
            _hotels[3].AddApartment(new Apartment(1, 1, 100));
            _hotels[3].AddApartment(new Apartment(2, 2, 200));
            _hotels[3].AddApartment(new Apartment(3, 3, 300));
            _hotels.Add(new Hotel("USA", "Washington D.C.", "SomeWDCHotel1"));
            _hotels[4].AddApartment(new Apartment(1, 1, 100));
            _hotels[4].AddApartment(new Apartment(2, 2, 200));
            _hotels[4].AddApartment(new Apartment(3, 3, 300));
        }

        public Apartment[] SearchForApartment(Guid session, Filter[] filters)
        {
            if (AccessControl.VerifySession(session))
            {
                return ApartmentsFiltering.FilterApartments(session, _hotels, filters);
            }
            else
            {
                Console.WriteLine("User is not authorised or has no access!");
                return new Apartment[0];
            }
        }

        public void BookApartment(Guid session, Apartment apartment)
        {
            if (AccessControl.VerifySession(session))
            {
                Console.WriteLine($"Apartment: {apartment} has been booked!");
            }
            else
            {
                Console.WriteLine("Failed to book apartment - access denied!");
            }
        }
    }
}
