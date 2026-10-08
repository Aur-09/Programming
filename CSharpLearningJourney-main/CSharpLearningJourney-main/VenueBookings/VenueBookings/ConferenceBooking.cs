using System;

namespace VenueBookings
{
    //Class to represent conference booking that inherits from Booking
    public class ConferenceBooking : Booking
    {
        //Event detail specific to conference type
        public string Organisation { get; private set; }

        //Single class constructor to receive and initialise conference event details
        public ConferenceBooking(string clientName, DateTime eventDate, int numberOfGuests, int durationHours, string organisation)
            : base(clientName, eventDate, numberOfGuests, durationHours)
        {
            Organisation = organisation;
            TypeOfEvent = EventType.Conference;
        }

        //Override abstract method to return formatted file record
        public override string PrepareFileRecord()
        {
            return string.Join(";", TypeOfEvent, ClientName, EventDate.ToShortDateString(), NumberOfGuests, DurationHours, Organisation, CalculateQuote().ToString("0.00"));
        }
    }
}
