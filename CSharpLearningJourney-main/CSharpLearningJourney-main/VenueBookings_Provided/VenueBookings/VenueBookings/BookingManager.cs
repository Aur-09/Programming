using System;
using System.Collections.Generic;

namespace VenueBookings
{
    public static class BookingManager
    {
        private static List<Booking> bookings = new List<Booking>();

        /*2.2.1*/
        private static decimal[,] ratesPerGuest = new decimal[3, 3];
        public static void AddBookingToList(Booking booking)
        {
            bookings.Add(booking);
        }

        public static List<Booking> GetListOfBookings()
        {
            return bookings;
        }

        public static decimal GetRatePerGuest(int numberOfGuests, int durationHours)
        {
            //Determine the row based on number of guests (range)
            int row;
            if (numberOfGuests <= 50)
                row = 0;
            else if (numberOfGuests <= 150)
                row = 1;
            else
                row = 2;

            //Determine the column based on duration
            int col;
            if (durationHours <= 4)
                col = 0;
            else if (durationHours <= 8)
                col = 1;
            else
                col = 2;

            //Use indexes to return fee per guest based on duration
            return ratesPerGuest[row, col];
        }
    }
}
