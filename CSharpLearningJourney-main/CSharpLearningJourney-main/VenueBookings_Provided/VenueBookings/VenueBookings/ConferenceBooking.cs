using System;

namespace VenueBookings
{
    /*2.4.1*/
    public class ConferenceBooking : Booking
    {
        /*2.4.2*/
        public string Organization { get;private set; }
        /*2.4.3*/
        public ConferenceBooking(string client_name, DateTime event_date, int numberofguest, int duration, string organization) :base(client_name, event_date, numberofguest, duration)
        {
            Organization= organization;
        }
        /*2.4.4*/
        public override string PrepareFileRecord()
        {
            return $"{EventType.Wedding};{ClientName};{EventDate};{NumberOfGuests};{DurationHours};{Organization};{}";
        }
    }
}
