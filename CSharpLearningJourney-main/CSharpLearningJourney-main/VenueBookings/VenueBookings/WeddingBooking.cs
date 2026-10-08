using System;

namespace VenueBookings
{
    //Class to represent wedding booking that inherits from Booking
    public class WeddingBooking : Booking
    {
        //Flat rate for decor
        private const decimal DECOR_FEE = 8500m;

        //Event detail specific to wedding
        public string Theme { get; private set; }

        //Single class constructor to receive and initialise wedding event details
        public WeddingBooking(string clientName, DateTime eventDate, int numberOfGuests, int durationHours, string theme)
            : base(clientName, eventDate, numberOfGuests, durationHours)
        {
            Theme = theme;
            TypeOfEvent = EventType.Wedding;
        }

        //Override CalculateQuote to apply decor fee to standard quote
        public override decimal CalculateQuote()
        {
            return base.CalculateQuote() + DECOR_FEE;
        }

        //Override abstract method to return formatted file record
        public override string PrepareFileRecord()
        {
            return string.Join(";", TypeOfEvent, ClientName, EventDate.ToShortDateString(), NumberOfGuests, DurationHours, Theme, CalculateQuote().ToString("0.00"));
        }
    }
}
