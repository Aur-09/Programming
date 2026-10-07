using System;

namespace VenueBookings
{
    /*2.3.1*/
    public abstract class Booking
    {
        public string ClientName { get; private set; }
        public DateTime EventDate { get; private set; }
        public int NumberOfGuests { get; private set; }
        public int DurationHours { get; private set; }

        /*2.3.2*/
        public EventType selctedtype { get; private set; }
        /*2.3.3*/
        public Booking(string client_name, DateTime event_date, int numberofguest,int duration)
        {
            ClientName = client_name;
            EventDate = event_date;
            NumberOfGuests = numberofguest;
            DurationHours = duration;
        }

        /*2.3.4*/
        public abstract string PrepareFileRecord();

        /*2.3.5*/
        static abstract decimal CalculateQuote()
        {

            const decimal onceoff_decore = 8500;
             //standard_qoute = NumberOfGuests * BookingManager.GetRatePerGuest;
        }
    }
}
