namespace VenueBookings
{
    partial class dlgAddBooking
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
            this.lblBookingType = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblEventDate = new System.Windows.Forms.Label();
            this.lblNumOfGuests = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.cmbBookingType = new System.Windows.Forms.ComboBox();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.nudGuests = new System.Windows.Forms.NumericUpDown();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtThemeOrOrganisation = new System.Windows.Forms.TextBox();
            this.lblThemeOrOrganisation = new System.Windows.Forms.Label();
            this.dtpEventDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.nudGuests)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBookingType
            // 
            this.lblBookingType.AutoSize = true;
            this.lblBookingType.Location = new System.Drawing.Point(12, 9);
            this.lblBookingType.Name = "lblBookingType";
            this.lblBookingType.Size = new System.Drawing.Size(103, 17);
            this.lblBookingType.TabIndex = 0;
            this.lblBookingType.Text = "Booking Type: ";
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(12, 61);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(88, 17);
            this.lblClientName.TabIndex = 1;
            this.lblClientName.Text = "Client Name:";
            // 
            // lblEventDate
            // 
            this.lblEventDate.AutoSize = true;
            this.lblEventDate.Location = new System.Drawing.Point(12, 115);
            this.lblEventDate.Name = "lblEventDate";
            this.lblEventDate.Size = new System.Drawing.Size(82, 17);
            this.lblEventDate.TabIndex = 2;
            this.lblEventDate.Text = "Event Date:";
            // 
            // lblNumOfGuests
            // 
            this.lblNumOfGuests.AutoSize = true;
            this.lblNumOfGuests.Location = new System.Drawing.Point(12, 168);
            this.lblNumOfGuests.Name = "lblNumOfGuests";
            this.lblNumOfGuests.Size = new System.Drawing.Size(99, 17);
            this.lblNumOfGuests.TabIndex = 3;
            this.lblNumOfGuests.Text = "No. of Guests:";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(135, 168);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(100, 17);
            this.lblDuration.TabIndex = 4;
            this.lblDuration.Text = "Duration (hrs):";
            // 
            // cmbBookingType
            // 
            this.cmbBookingType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBookingType.FormattingEnabled = true;
            this.cmbBookingType.Location = new System.Drawing.Point(12, 28);
            this.cmbBookingType.Name = "cmbBookingType";
            this.cmbBookingType.Size = new System.Drawing.Size(232, 24);
            this.cmbBookingType.TabIndex = 5;
            this.cmbBookingType.SelectedIndexChanged += new System.EventHandler(this.cmbBookingType_SelectedIndexChanged);
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(12, 81);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(232, 22);
            this.txtClientName.TabIndex = 6;
            // 
            // nudGuests
            // 
            this.nudGuests.Location = new System.Drawing.Point(12, 188);
            this.nudGuests.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudGuests.Name = "nudGuests";
            this.nudGuests.Size = new System.Drawing.Size(109, 22);
            this.nudGuests.TabIndex = 8;
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(135, 188);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(109, 22);
            this.txtDuration.TabIndex = 9;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(87, 274);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(82, 32);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtThemeOrOrganisation
            // 
            this.txtThemeOrOrganisation.Location = new System.Drawing.Point(12, 240);
            this.txtThemeOrOrganisation.Name = "txtThemeOrOrganisation";
            this.txtThemeOrOrganisation.Size = new System.Drawing.Size(232, 22);
            this.txtThemeOrOrganisation.TabIndex = 12;
            // 
            // lblThemeOrOrganisation
            // 
            this.lblThemeOrOrganisation.AutoSize = true;
            this.lblThemeOrOrganisation.Location = new System.Drawing.Point(12, 220);
            this.lblThemeOrOrganisation.Name = "lblThemeOrOrganisation";
            this.lblThemeOrOrganisation.Size = new System.Drawing.Size(137, 17);
            this.lblThemeOrOrganisation.TabIndex = 11;
            this.lblThemeOrOrganisation.Text = "Theme/Organisation";
            // 
            // dtpEventDate
            // 
            this.dtpEventDate.Location = new System.Drawing.Point(12, 135);
            this.dtpEventDate.Name = "dtpEventDate";
            this.dtpEventDate.Size = new System.Drawing.Size(232, 22);
            this.dtpEventDate.TabIndex = 13;
            // 
            // dlgAddBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 318);
            this.Controls.Add(this.dtpEventDate);
            this.Controls.Add(this.txtThemeOrOrganisation);
            this.Controls.Add(this.lblThemeOrOrganisation);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.nudGuests);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.cmbBookingType);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblNumOfGuests);
            this.Controls.Add(this.lblEventDate);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.lblBookingType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dlgAddBookings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Booking";
            ((System.ComponentModel.ISupportInitialize)(this.nudGuests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBookingType;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblEventDate;
        private System.Windows.Forms.Label lblNumOfGuests;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.ComboBox cmbBookingType;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.NumericUpDown nudGuests;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtThemeOrOrganisation;
        private System.Windows.Forms.Label lblThemeOrOrganisation;
        private System.Windows.Forms.DateTimePicker dtpEventDate;
    }
}