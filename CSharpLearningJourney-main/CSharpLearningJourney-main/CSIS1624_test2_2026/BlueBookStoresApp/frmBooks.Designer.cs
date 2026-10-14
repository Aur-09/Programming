namespace BlueBookStoresApp
{
    partial class frmBooks
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
            this.components = new System.ComponentModel.Container();
            this.grpBooktype = new System.Windows.Forms.GroupBox();
            this.radFantasy = new System.Windows.Forms.RadioButton();
            this.radHorror = new System.Windows.Forms.RadioButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.cmbPublicationYear = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.lblScareFactorLevel = new System.Windows.Forms.Label();
            this.numScareFactorLevel = new System.Windows.Forms.NumericUpDown();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.chkHasMagicSystem = new System.Windows.Forms.CheckBox();
            this.grpBooktype.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numScareFactorLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBooktype
            // 
            this.grpBooktype.Controls.Add(this.radFantasy);
            this.grpBooktype.Controls.Add(this.radHorror);
            this.grpBooktype.Location = new System.Drawing.Point(12, 18);
            this.grpBooktype.Name = "grpBooktype";
            this.grpBooktype.Size = new System.Drawing.Size(383, 50);
            this.grpBooktype.TabIndex = 0;
            this.grpBooktype.TabStop = false;
            this.grpBooktype.Text = "Book type";
            // 
            // radFantasy
            // 
            this.radFantasy.AutoSize = true;
            this.radFantasy.Location = new System.Drawing.Point(280, 21);
            this.radFantasy.Name = "radFantasy";
            this.radFantasy.Size = new System.Drawing.Size(76, 20);
            this.radFantasy.TabIndex = 18;
            this.radFantasy.TabStop = true;
            this.radFantasy.Text = "Fantasy";
            this.radFantasy.UseVisualStyleBackColor = true;
            this.radFantasy.CheckedChanged += new System.EventHandler(this.radHorror_CheckedChanged);
            // 
            // radHorror
            // 
            this.radHorror.AutoSize = true;
            this.radHorror.Location = new System.Drawing.Point(10, 21);
            this.radHorror.Name = "radHorror";
            this.radHorror.Size = new System.Drawing.Size(66, 20);
            this.radHorror.TabIndex = 1;
            this.radHorror.TabStop = true;
            this.radHorror.Text = "Horror";
            this.radHorror.UseVisualStyleBackColor = true;
            this.radHorror.CheckedChanged += new System.EventHandler(this.radHorror_CheckedChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(9, 90);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(33, 16);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(9, 127);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(45, 16);
            this.lblAuthor.TabIndex = 3;
            this.lblAuthor.Text = "Author";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(178, 84);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(217, 22);
            this.txtTitle.TabIndex = 5;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(178, 121);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(217, 22);
            this.txtAuthor.TabIndex = 6;
            // 
            // cmbPublicationYear
            // 
            this.cmbPublicationYear.FormattingEnabled = true;
            this.cmbPublicationYear.Items.AddRange(new object[] {
            "2023",
            "2024",
            "2025",
            "2026"});
            this.cmbPublicationYear.Location = new System.Drawing.Point(178, 158);
            this.cmbPublicationYear.Name = "cmbPublicationYear";
            this.cmbPublicationYear.Size = new System.Drawing.Size(70, 24);
            this.cmbPublicationYear.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Publication Year";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(292, 249);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 29);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(11, 249);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(94, 29);
            this.btnDisplay.TabIndex = 15;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // lblScareFactorLevel
            // 
            this.lblScareFactorLevel.AutoSize = true;
            this.lblScareFactorLevel.Location = new System.Drawing.Point(9, 205);
            this.lblScareFactorLevel.Name = "lblScareFactorLevel";
            this.lblScareFactorLevel.Size = new System.Drawing.Size(150, 20);
            this.lblScareFactorLevel.TabIndex = 16;
            this.lblScareFactorLevel.Text = "Scare Factor Level";
            // 
            // numScareFactorLevel
            // 
            this.numScareFactorLevel.Location = new System.Drawing.Point(178, 202);
            this.numScareFactorLevel.Name = "numScareFactorLevel";
            this.numScareFactorLevel.Size = new System.Drawing.Size(53, 22);
            this.numScareFactorLevel.TabIndex = 17;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // chkHasMagicSystem
            // 
            this.chkHasMagicSystem.AutoSize = true;
            this.chkHasMagicSystem.Location = new System.Drawing.Point(11, 203);
            this.chkHasMagicSystem.Name = "chkHasMagicSystem";
            this.chkHasMagicSystem.Size = new System.Drawing.Size(142, 20);
            this.chkHasMagicSystem.TabIndex = 18;
            this.chkHasMagicSystem.Text = "Has Magic System";
            this.chkHasMagicSystem.UseVisualStyleBackColor = true;
            // 
            // frmBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 304);
            this.Controls.Add(this.chkHasMagicSystem);
            this.Controls.Add(this.numScareFactorLevel);
            this.Controls.Add(this.lblScareFactorLevel);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPublicationYear);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpBooktype);
            this.Name = "frmBooks";
            this.Text = "Books";
            this.grpBooktype.ResumeLayout(false);
            this.grpBooktype.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numScareFactorLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBooktype;
        private System.Windows.Forms.RadioButton radHorror;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.ComboBox cmbPublicationYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Label lblScareFactorLevel;
        private System.Windows.Forms.NumericUpDown numScareFactorLevel;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.RadioButton radFantasy;
        private System.Windows.Forms.CheckBox chkHasMagicSystem;
    }
}

