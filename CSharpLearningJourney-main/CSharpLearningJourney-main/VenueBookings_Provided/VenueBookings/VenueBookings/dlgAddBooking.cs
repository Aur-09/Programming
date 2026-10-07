using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VenueBookings
{
    public partial class dlgAddBooking : Form
    {
        /*2.5.1*/
        public dlgAddBooking()
        {
            InitializeComponent();
            cmbBookingType.DataSource = Enum.GetValues(typeof(EventType));
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                /*2.5.2*/
                if (cmbBookingType.SelectedItem.ToString() == "Wedding")
                {

                }
                else if (cmbBookingType.SelectedItem.ToString() == "Conference")
                {

                }

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
