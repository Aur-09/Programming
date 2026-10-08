using System;
using System.Collections.Generic;

namespace VenueBookings
{
    public static class BookingManager
    {
        private static List<Booking> bookings = new List<Booking>();

        //Rate card (rand per guest)
        //Columns - duration range: 1 - 4 hrs, 5 - 8 hrs,  more than 8 hrs
        private static decimal[,] ratesPerGuest =
        {
            { 320m, 450m, 560m }, //1 - 50 guests
            { 280m, 390m, 490m }, //51 - 150 guests
            { 240m, 340m, 430m }  //>150
        };

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
