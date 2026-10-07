using System;
using System.Windows.Forms;
using System.IO;

namespace VenueBookings
{
    public partial class frmVenueBookings : Form
    {
        public frmVenueBookings()
        {
            InitializeComponent();
        }

        private void btnAddABooking_Click(object sender, EventArgs e)
        {
            /*2.6.1*/

        }

        private void btnSaveList_Click(object sender, EventArgs e)
        {
            /*2.6.2*/
        }

        private void btnViewBookingList_Click(object sender, EventArgs e)
        {
            try
            {
                listViewBookings.Items.Clear();

                /*2.6.3*/

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Uncomment the method below when you are ready to test your program
        /*
        private void AddBookingToListView(Booking booking)
        {
            //Get theme or organisation depending on object type
            string detailColumn = "";
            if (booking is WeddingBooking wedding)
                detailColumn = wedding.Theme;
            else if (booking is ConferenceBooking conference)
                detailColumn = conference.Organisation;

            //Declare, instantiate, and initialise ListViewItem with array
            ListViewItem item = new ListViewItem(new string[] { booking.TypeOfEvent.ToString(), booking.ClientName, booking.EventDate.ToString("d"), booking.NumberOfGuests.ToString(), booking.DurationHours.ToString(), detailColumn, booking.CalculateQuote().ToString("0.00") });

            //Add ListViewItem to ListView
            listViewBookings.Items.Add(item);
        }//AddBookingToListView*/
    }
}
