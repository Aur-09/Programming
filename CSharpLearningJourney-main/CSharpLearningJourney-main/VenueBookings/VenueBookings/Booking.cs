using System;

namespace VenueBookings
{
    public abstract class Booking
    {
        //Basic event detail properties
        public string ClientName { get; private set; }
        public DateTime EventDate { get; private set; }
        public int NumberOfGuests { get; private set; }
        public int DurationHours { get; private set; }

        //Protected property to represent event type
        public EventType TypeOfEvent { get; protected set; }

        //Protected constructor that accepts basic event information
        protected Booking(string clientName, DateTime eventDate, int numberOfGuests, int durationHours)
        {
            ClientName = clientName;
            EventDate = eventDate;
            NumberOfGuests = numberOfGuests;
            DurationHours = durationHours;
        }

        //Virtual method to calculate quote where quote is num of guests x rate per guest
        public virtual decimal CalculateQuote()
        {
            return NumberOfGuests * BookingManager.GetRatePerGuest(NumberOfGuests, DurationHours);
        }

        //Abstract method to prepare event details for file
        public abstract string PrepareFileRecord();
    }
}
