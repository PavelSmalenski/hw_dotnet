using HW04.Booking.Com.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW04.Booking.Com.Controls
{
    static class ApartmentsFiltering
    {
        public static Apartment[] FilterApartments(Guid session, IEnumerable<Hotel> hotels, IEnumerable<Filter> filters)
        {
            if (AccessControl.VerifySession(session))
            {
                List<Apartment> result = new List<Apartment>();
                foreach (var hotel in hotels)
                {
                    bool isHotelMatch = true;
                    foreach (var apartment in hotel.GetApartments())
                    {
                        bool isApartmentMatch = true;
                        foreach (var filter in filters)
                        {
                            switch (filter.Type)
                            {
                                case Filter.FilterType.Country:
                                    if (hotel.Country != filter.Value)
                                    {
                                        isHotelMatch = false;
                                    }
                                    break;
                                case Filter.FilterType.City:
                                    if (hotel.City != filter.Value)
                                    {
                                        isHotelMatch = false;
                                    }
                                    break;
                                case Filter.FilterType.RoomsCount:
                                    if (apartment.RoomsCount < int.Parse(filter.Value))
                                    {
                                        isApartmentMatch = false;
                                    }
                                    break;
                                case Filter.FilterType.BedsCount:
                                    if (apartment.BedsCount < int.Parse(filter.Value))
                                    {
                                        isApartmentMatch = false;
                                    }
                                    break;
                                case Filter.FilterType.CostGt:
                                    if (apartment.Cost < int.Parse(filter.Value))
                                    {
                                        isApartmentMatch = false;
                                    }
                                    break;
                                case Filter.FilterType.CostLt:
                                    if (apartment.Cost > int.Parse(filter.Value))
                                    {
                                        isApartmentMatch = false;
                                    }
                                    break;
                                default:
                                    break;
                            }

                            if (isHotelMatch && isApartmentMatch)
                            {
                                result.Add(apartment);
                            }
                            else
                            {
                                break;
                            }
                        }

                        if (!isHotelMatch)
                        {
                            break;
                        }
                    }
                }
                return result.ToArray();
            }
            else
            {
                return new Apartment[0];
            }
        }
    }
}
