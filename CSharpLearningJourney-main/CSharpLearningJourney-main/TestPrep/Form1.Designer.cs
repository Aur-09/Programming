namespace UniversityFacultyPerformance
{
    partial class frmUniFacultyPerformance
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
            this.lblEnrolment = new System.Windows.Forms.Label();
            this.lblProjects = new System.Windows.Forms.Label();
            this.grpFaculty = new System.Windows.Forms.GroupBox();
            this.radHumanities = new System.Windows.Forms.RadioButton();
            this.radCommerce = new System.Windows.Forms.RadioButton();
            this.radScience = new System.Windows.Forms.RadioButton();
            this.lstEnrolment = new System.Windows.Forms.ListBox();
            this.lstProjects = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.grpFaculty.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEnrolment
            // 
            this.lblEnrolment.AutoSize = true;
            this.lblEnrolment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblEnrolment.Location = new System.Drawing.Point(30, 25);
            this.lblEnrolment.Name = "lblEnrolment";
            this.lblEnrolment.Size = new System.Drawing.Size(156, 15);
            this.lblEnrolment.TabIndex = 0;
            this.lblEnrolment.Text = "Programme Enrolment:";
            // 
            // lblProjects
            // 
            this.lblProjects.AutoSize = true;
            this.lblProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblProjects.Location = new System.Drawing.Point(300, 25);
            this.lblProjects.Name = "lblProjects";
            this.lblProjects.Size = new System.Drawing.Size(128, 15);
            this.lblProjects.TabIndex = 1;
            this.lblProjects.Text = "Research Projects:";
            // 
            // grpFaculty
            // 
            this.grpFaculty.Controls.Add(this.radHumanities);
            this.grpFaculty.Controls.Add(this.radCommerce);
            this.grpFaculty.Controls.Add(this.radScience);
            this.grpFaculty.Location = new System.Drawing.Point(30, 310);
            this.grpFaculty.Name = "grpFaculty";
            this.grpFaculty.Size = new System.Drawing.Size(490, 70);
            this.grpFaculty.TabIndex = 2;
            this.grpFaculty.TabStop = false;
            this.grpFaculty.Text = "Faculty";
            // 
            // radHumanities
            // 
            this.radHumanities.AutoSize = true;
            this.radHumanities.Location = new System.Drawing.Point(340, 30);
            this.radHumanities.Name = "radHumanities";
            this.radHumanities.Size = new System.Drawing.Size(88, 19);
            this.radHumanities.TabIndex = 2;
            this.radHumanities.TabStop = true;
            this.radHumanities.Text = "Humanities";
            this.radHumanities.UseVisualStyleBackColor = true;
            this.radHumanities.CheckedChanged += new System.EventHandler(this.SelectedFaculty_CheckedChanged);
            // 
            // radCommerce
            // 
            this.radCommerce.AutoSize = true;
            this.radCommerce.Location = new System.Drawing.Point(200, 30);
            this.radCommerce.Name = "radCommerce";
            this.radCommerce.Size = new System.Drawing.Size(86, 19);
            this.radCommerce.TabIndex = 1;
            this.radCommerce.TabStop = true;
            this.radCommerce.Text = "Commerce";
            this.radCommerce.UseVisualStyleBackColor = true;
            this.radCommerce.CheckedChanged += new System.EventHandler(this.SelectedFaculty_CheckedChanged);
            // 
            // radScience
            // 
            this.radScience.AutoSize = true;
            this.radScience.Location = new System.Drawing.Point(60, 30);
            this.radScience.Name = "radScience";
            this.radScience.Size = new System.Drawing.Size(69, 19);
            this.radScience.TabIndex = 0;
            this.radScience.TabStop = true;
            this.radScience.Text = "Science";
            this.radScience.UseVisualStyleBackColor = true;
            this.radScience.CheckedChanged += new System.EventHandler(this.SelectedFaculty_CheckedChanged);
            // 
            // lstEnrolment
            // 
            this.lstEnrolment.FormattingEnabled = true;
            this.lstEnrolment.ItemHeight = 15;
            this.lstEnrolment.Location = new System.Drawing.Point(30, 50);
            this.lstEnrolment.Name = "lstEnrolment";
            this.lstEnrolment.Size = new System.Drawing.Size(240, 229);
            this.lstEnrolment.TabIndex = 3;
            // 
            // lstProjects
            // 
            this.lstProjects.FormattingEnabled = true;
            this.lstProjects.ItemHeight = 15;
            this.lstProjects.Location = new System.Drawing.Point(300, 50);
            this.lstProjects.Name = "lstProjects";
            this.lstProjects.Size = new System.Drawing.Size(220, 229);
            this.lstProjects.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(30, 400);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(142, 38);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save to File";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(288, 400);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 36);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmUniFacultyPerformance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lstProjects);
            this.Controls.Add(this.lstEnrolment);
            this.Controls.Add(this.grpFaculty);
            this.Controls.Add(this.lblProjects);
            this.Controls.Add(this.lblEnrolment);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmUniFacultyPerformance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "University Faculty Performance (3)";
            this.grpFaculty.ResumeLayout(false);
            this.grpFaculty.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnrolment;
        private System.Windows.Forms.Label lblProjects;
        private System.Windows.Forms.GroupBox grpFaculty;
        private System.Windows.Forms.RadioButton radHumanities;
        private System.Windows.Forms.RadioButton radCommerce;
        private System.Windows.Forms.RadioButton radScience;
        private System.Windows.Forms.ListBox lstEnrolment;
        private System.Windows.Forms.ListBox lstProjects;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
