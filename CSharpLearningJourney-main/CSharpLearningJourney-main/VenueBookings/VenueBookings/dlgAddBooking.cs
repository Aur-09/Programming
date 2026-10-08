using System;
using System.Windows.Forms;

namespace VenueBookings
{
    public partial class dlgAddBooking : Form
    {
        //Property store event booking details
        public Booking NewBooking { get; private set; }

        public dlgAddBooking()
        {
            InitializeComponent();

            //Populate ComboBox with EventType enum values
            cmbBookingType.DataSource = Enum.GetValues(typeof(EventType));
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //Catch any exceptions and return a message
            try
            {
                //Instantiate an object of the appropriate class depending on ComboBox selection
                if (cmbBookingType.SelectedItem.ToString() == "Wedding")
                    NewBooking = new WeddingBooking(txtClientName.Text, dtpEventDate.Value, (int)nudGuests.Value, int.Parse(txtDuration.Text), txtThemeOrOrganisation.Text);
                else if (cmbBookingType.SelectedItem.ToString() == "Conference")
                    NewBooking = new ConferenceBooking(txtClientName.Text, dtpEventDate.Value, (int)nudGuests.Value, int.Parse(txtDuration.Text), txtThemeOrOrganisation.Text);

                //Set DialogResult for button
                DialogResult = DialogResult.OK;
            }
            catch
            {
                MessageBox.Show("Empty field(s)/Incorrect information format", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbBookingType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Change label text based on booking type
            if (cmbBookingType.SelectedIndex == 0)
                lblThemeOrOrganisation.Text = "Organisation:";
            else if (cmbBookingType.SelectedIndex == 1)
                lblThemeOrOrganisation.Text = "Theme:";
        }
    }
}
