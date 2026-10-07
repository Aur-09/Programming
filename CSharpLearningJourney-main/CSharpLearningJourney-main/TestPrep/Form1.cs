using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace UniversityFacultyPerformance
{
    public partial class frmUniFacultyPerformance : Form
    {
        // Class-level variable to store the selected faculty
        string selectedFaculty;
        // String array to store faculty names
        string[] faculties;
        // String array to store programme levels
        string[] programmes;
        // ... array to store enrolment numbers for each faculty across four programme levels
        // Row index corresponds to faculty (0=Science, 1=Commerce, 2=Humanities)
        // Column index corresponds to programme level (0=Undergraduate, 1=Honours, 2=Masters, 3=Doctoral)
        // Science
        // Commerce
        // Humanities
        int[,] enrolmentNumbers = new int[3,4];

        // Jagged array to store research projects for each faculty
        // Each faculty has a different number of research projects
        // Science research projects
        // Commerce research projects
        // Humanities research projects
        string[][] researchProjects = new string[3][];

        public frmUniFacultyPerformance()
        {
            InitializeComponent();
            // Select Science faculty by default when the form loads
            radScience.Checked = true;
        }

        /// <summary>
        /// Displays enrolment numbers for the selected faculty in the lstEnrolment ListBox.
        /// </summary>
        /// <param name="facultyIndex">Index of the selected faculty</param>
        void DisplayEnrolment(string facultyIndex)
        {
            // Clear the ListBox before adding new data

            // Iterate through programmes and build display string

        }


        /// <summary>
        /// Displays research projects for the selected faculty in the lstProjects ListBox.
        /// </summary>
        /// <param name="facultyIndex">Index of the selected faculty</param>
        void DisplayProjects(string facultyIndex)
        {
            // Clear the ListBox before adding new data

            // Iterate through the selected faculty's research projects
        }

            /// <summary>
            /// Shared event handler for all three RadioButton controls.
            /// Determines which faculty is selected and updates the display.
            /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Open a SaveFileDialog to let the user choose where to save the file
            
            
        }

        private void SelectedFaculty_CheckedChanged(object sender, EventArgs e)
        {
            // Check which RadioButton is currently checked and store its text


            // Use Array.IndexOf to find the index of the selected faculty

            // Call custom methods to display enrolment and research project data

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
