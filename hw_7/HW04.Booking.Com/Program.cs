using HW04.Booking.Com.Controls;
using HW04.Booking.Com.Models;
using System;

namespace HW04.Booking.Com
{
    class Program
    {
        static void Main(string[] args)
        {
            var catalog = new ApartmentsCatalog();
            AccessControl.RegisterUser("admin", "admin");

            Guid? session = AccessControl.Logon("admin", "admin");
            if (session != null)
            {
                Apartment[] apartments = catalog.SearchForApartment((Guid)session, new Filter[1] { new Filter(Filter.FilterType.RoomsCount, "3") });

                // For example, we want first one+
                catalog.BookApartment((Guid)session, apartments[0]);
            }
            else
            {
                Console.WriteLine("Failed to logon!");
            }
        }
    }
}
