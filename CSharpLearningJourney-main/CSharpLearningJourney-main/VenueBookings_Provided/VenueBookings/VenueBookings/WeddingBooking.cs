using System;

namespace VenueBookings
{
    /*2.4.1*/
    public class WeddingBooking: Booking
    {
        private const decimal DECOR_FEE = 8500m;

        /*2.4.2*/
        public string Theme { get; private set; }
        /*2.4.3*/
        public WeddingBooking(string client_name, DateTime event_date, int numberofguest, int duration, string theme) :base(client_name, event_date, numberofguest, duration)
        {
            Theme = theme;
        }
        /*2.4.4*/
        public override string PrepareFileRecord()
        {
            return $"{EventType.Wedding};{ClientName};{EventDate};{NumberOfGuests};{DurationHours};{Organization}";
        }
        /*2.4.5*/

    }
}
