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
            //Instantiate dialog form object to link to main form
            using (dlgAddBooking dlg = new dlgAddBooking())
            {
                //If user clicks OK button and event booking detailsa are provided, add to list and display to ListView
                if (dlg.ShowDialog() == DialogResult.OK && dlg.NewBooking != null)
                {
                    BookingManager.AddBookingToList(dlg.NewBooking);
                    AddBookingToListView(dlg.NewBooking);
                }
            }
        }

        private void btnSaveList_Click(object sender, EventArgs e)
        {
            //Allow user to select file to save event details to
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                //Open a connection and StreamWriter
                using (FileStream fs = new FileStream(dlgSave.FileName, FileMode.Append, FileAccess.Write))
                {
                    using (StreamWriter w = new StreamWriter(fs))
                    {
                        //Iterate through updated list of bookings and write details to file 
                        foreach (Booking booking in BookingManager.GetListOfBookings())
                        {
                            w.WriteLine(booking.PrepareFileRecord());
                        }

                        MessageBox.Show("Venue bookings updated successfully.");
                    }
                }
            }
        }

        private void btnViewBookingList_Click(object sender, EventArgs e)
        {
            //Catch any exceptions and return a message
            try
            {
                listViewBookings.Items.Clear();

                //Allow user to select file to open/access
                if (dlgOpen.ShowDialog() == DialogResult.OK)
                {
                    //Open a connection and StreamReader
                    using (FileStream fs = new FileStream(dlgOpen.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (StreamReader r = new StreamReader(fs))
                        {
                            string line;

                            //Read file line by line until end of file is reach
                            while ((line = r.ReadLine()) != null)
                            {
                                //Split each record using appropriate delimiter
                                string[] data = line.Split(';');

                                //Check if current row is header row and skip (i.e., do not add to ListView) otherwise add details to ListView
                                if (data[0] != "BookingType") 
                                    listViewBookings.Items.Add(new ListViewItem(data));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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
        }//AddBookingToListView
    }
}
