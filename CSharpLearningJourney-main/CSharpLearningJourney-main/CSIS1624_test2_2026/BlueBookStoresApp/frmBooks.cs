/*Noluthando Buda
 * 2028419741
 * CSIS1624 Semester Test 2 
 * 08 October 2026
 */
using System;
using System.Windows.Forms;

namespace BlueBookStoresApp
{
    public partial class frmBooks : Form
    {
        /// TODO: Add the needed code here <summary>
        /// TODO: Add the needed code here
        public CBook Typed;
        /// </summary>
        public frmBooks()
        {
            InitializeComponent();
        }
        private void radHorror_CheckedChanged(object sender, EventArgs e)
        {
            txtTitle.Text = txtAuthor.Text = "";
            cmbPublicationYear.SelectedIndex = -1;
            numScareFactorLevel.Value = 0;

            lblScareFactorLevel.Visible = radHorror.Checked;
            numScareFactorLevel.Visible = radHorror.Checked;
            chkHasMagicSystem.Visible = radFantasy.Checked;
        }
        public void Instantiate()
        {
            //int dgfd = int.Parse(cmbPublicationYear.SelectedItem.ToString());
            /// TODO: Add the needed code here
            if (radHorror.Checked)
            {
                Typed = new CHorror(txtTitle.Text, txtAuthor.Text, int.Parse(cmbPublicationYear.Text), (int)numScareFactorLevel.Value);
            }
            else if (radFantasy.Checked)
            {
                Typed = new CFantasy(txtTitle.Text, txtAuthor.Text, int.Parse(cmbPublicationYear.Text), chkHasMagicSystem.Checked);
            }
            else
            {
                MessageBox.Show("Select the genre of the book", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            Instantiate();
            /// TODO: Add the needed code here
            if (Typed != null)
            {
                try
                {
                    using (frmBookDetails frmbd = new frmBookDetails())
                    {
                        frmbd.BookDetails(Typed);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
