/*Noluthando Buda
 * 2028419741
 * CSIS1624 Semester Test 2 
 * 08 October 2026
 */
using System;
using System.Windows.Forms;

namespace BlueBookStoresApp
{
    public partial class frmBookDetails : Form
    {
        public frmBookDetails()
        {
            InitializeComponent();
        }
        public void BookDetails(CBook cBook)/// TODO: Add the needed parameter code
        {
            //populate the label with the book information
            lblBookDetails.Text = cBook.DisplayBookDetails();

            //Display the current form as a ,odal dialog box
            this.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
