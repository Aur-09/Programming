namespace VenueBookings
{
    partial class frmVenueBookings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddABooking = new System.Windows.Forms.Button();
            this.btnSaveList = new System.Windows.Forms.Button();
            this.btnViewBookingList = new System.Windows.Forms.Button();
            this.listViewBookings = new System.Windows.Forms.ListView();
            this.colBookingType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colClientName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEventDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGuests = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDuration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colThemeOrganisation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQuote = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btnAddABooking
            // 
            this.btnAddABooking.Location = new System.Drawing.Point(171, 324);
            this.btnAddABooking.Name = "btnAddABooking";
            this.btnAddABooking.Size = new System.Drawing.Size(140, 37);
            this.btnAddABooking.TabIndex = 0;
            this.btnAddABooking.Text = "Add a Booking";
            this.btnAddABooking.UseVisualStyleBackColor = true;
            this.btnAddABooking.Click += new System.EventHandler(this.btnAddABooking_Click);
            // 
            // btnSaveList
            // 
            this.btnSaveList.Location = new System.Drawing.Point(325, 324);
            this.btnSaveList.Name = "btnSaveList";
            this.btnSaveList.Size = new System.Drawing.Size(140, 37);
            this.btnSaveList.TabIndex = 1;
            this.btnSaveList.Text = "Save to File";
            this.btnSaveList.UseVisualStyleBackColor = true;
            this.btnSaveList.Click += new System.EventHandler(this.btnSaveList_Click);
            // 
            // btnViewBookingList
            // 
            this.btnViewBookingList.Location = new System.Drawing.Point(479, 324);
            this.btnViewBookingList.Name = "btnViewBookingList";
            this.btnViewBookingList.Size = new System.Drawing.Size(140, 37);
            this.btnViewBookingList.TabIndex = 2;
            this.btnViewBookingList.Text = "View List";
            this.btnViewBookingList.UseVisualStyleBackColor = true;
            this.btnViewBookingList.Click += new System.EventHandler(this.btnViewBookingList_Click);
            // 
            // listViewBookings
            // 
            this.listViewBookings.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colBookingType,
            this.colClientName,
            this.colEventDate,
            this.colGuests,
            this.colDuration,
            this.colThemeOrganisation,
            this.colQuote});
            this.listViewBookings.FullRowSelect = true;
            this.listViewBookings.GridLines = true;
            this.listViewBookings.HideSelection = false;
            this.listViewBookings.Location = new System.Drawing.Point(12, 12);
            this.listViewBookings.Name = "listViewBookings";
            this.listViewBookings.Size = new System.Drawing.Size(761, 306);
            this.listViewBookings.TabIndex = 3;
            this.listViewBookings.UseCompatibleStateImageBehavior = false;
            this.listViewBookings.View = System.Windows.Forms.View.Details;
            // 
            // colBookingType
            // 
            this.colBookingType.Text = "Booking Type";
            this.colBookingType.Width = 100;
            // 
            // colClientName
            // 
            this.colClientName.Text = "Client Name";
            this.colClientName.Width = 120;
            // 
            // colEventDate
            // 
            this.colEventDate.Text = "Event Date";
            this.colEventDate.Width = 95;
            // 
            // colGuests
            // 
            this.colGuests.Text = "Guests";
            this.colGuests.Width = 65;
            // 
            // colDuration
            // 
            this.colDuration.Text = "Duration (hrs)";
            this.colDuration.Width = 100;
            // 
            // colThemeOrganisation
            // 
            this.colThemeOrganisation.Text = "Theme/Organisation";
            this.colThemeOrganisation.Width = 140;
            // 
            // colQuote
            // 
            this.colQuote.Text = "Quote (R)";
            this.colQuote.Width = 100;
            // 
            // dlgOpen
            // 
            this.dlgOpen.FileName = "openFileDialog1";
            // 
            // frmVenueBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 370);
            this.Controls.Add(this.listViewBookings);
            this.Controls.Add(this.btnViewBookingList);
            this.Controls.Add(this.btnSaveList);
            this.Controls.Add(this.btnAddABooking);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVenueBookings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VENUE BOOKINGS";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddABooking;
        private System.Windows.Forms.Button btnSaveList;
        private System.Windows.Forms.Button btnViewBookingList;
        private System.Windows.Forms.ListView listViewBookings;
        private System.Windows.Forms.ColumnHeader colClientName;
        private System.Windows.Forms.ColumnHeader colEventDate;
        private System.Windows.Forms.ColumnHeader colGuests;
        private System.Windows.Forms.ColumnHeader colDuration;
        private System.Windows.Forms.ColumnHeader colThemeOrganisation;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.ColumnHeader colBookingType;
        private System.Windows.Forms.ColumnHeader colQuote;
    }
}

