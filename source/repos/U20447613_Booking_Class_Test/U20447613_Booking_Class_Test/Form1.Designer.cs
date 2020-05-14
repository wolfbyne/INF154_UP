namespace U20447613_Booking_Class_Test
{
    partial class Form1
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
            this.lblNameSurname = new System.Windows.Forms.Label();
            this.lblActivity = new System.Windows.Forms.Label();
            this.lblNumOfPeople = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnBooking_Click = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.nudPeople = new System.Windows.Forms.NumericUpDown();
            this.rbPhoto = new System.Windows.Forms.RadioButton();
            this.cboActivity = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNameSurname
            // 
            this.lblNameSurname.AutoSize = true;
            this.lblNameSurname.Location = new System.Drawing.Point(109, 74);
            this.lblNameSurname.Name = "lblNameSurname";
            this.lblNameSurname.Size = new System.Drawing.Size(102, 13);
            this.lblNameSurname.TabIndex = 0;
            this.lblNameSurname.Text = "Name and surname:";
            // 
            // lblActivity
            // 
            this.lblActivity.AutoSize = true;
            this.lblActivity.Location = new System.Drawing.Point(109, 146);
            this.lblActivity.Name = "lblActivity";
            this.lblActivity.Size = new System.Drawing.Size(44, 13);
            this.lblActivity.TabIndex = 1;
            this.lblActivity.Text = "Activity:";
            // 
            // lblNumOfPeople
            // 
            this.lblNumOfPeople.AutoSize = true;
            this.lblNumOfPeople.Location = new System.Drawing.Point(109, 208);
            this.lblNumOfPeople.Name = "lblNumOfPeople";
            this.lblNumOfPeople.Size = new System.Drawing.Size(94, 13);
            this.lblNumOfPeople.TabIndex = 2;
            this.lblNumOfPeople.Text = "Number of people:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(109, 283);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 13);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date:";
            // 
            // btnBooking_Click
            // 
            this.btnBooking_Click.Location = new System.Drawing.Point(237, 372);
            this.btnBooking_Click.Name = "btnBooking_Click";
            this.btnBooking_Click.Size = new System.Drawing.Size(463, 23);
            this.btnBooking_Click.TabIndex = 4;
            this.btnBooking_Click.Text = "Make the booking";
            this.btnBooking_Click.UseVisualStyleBackColor = true;
            this.btnBooking_Click.Click += new System.EventHandler(this.btnBooking_Click_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(432, 74);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(241, 20);
            this.txtName.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(432, 276);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // nudPeople
            // 
            this.nudPeople.Location = new System.Drawing.Point(432, 208);
            this.nudPeople.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPeople.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPeople.Name = "nudPeople";
            this.nudPeople.Size = new System.Drawing.Size(88, 20);
            this.nudPeople.TabIndex = 8;
            this.nudPeople.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rbPhoto
            // 
            this.rbPhoto.AutoSize = true;
            this.rbPhoto.Location = new System.Drawing.Point(432, 321);
            this.rbPhoto.Name = "rbPhoto";
            this.rbPhoto.Size = new System.Drawing.Size(186, 17);
            this.rbPhoto.TabIndex = 9;
            this.rbPhoto.TabStop = true;
            this.rbPhoto.Text = "Please include photo\'s in the price";
            this.rbPhoto.UseVisualStyleBackColor = true;
            // 
            // cboActivity
            // 
            this.cboActivity.FormattingEnabled = true;
            this.cboActivity.Items.AddRange(new object[] {
            "Abseiling",
            "Quad bikes",
            "Target Archery",
            "Zip-lining"});
            this.cboActivity.Location = new System.Drawing.Point(432, 138);
            this.cboActivity.Name = "cboActivity";
            this.cboActivity.Size = new System.Drawing.Size(200, 21);
            this.cboActivity.TabIndex = 10;
            this.cboActivity.Text = "Select your activity here";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 500);
            this.Controls.Add(this.cboActivity);
            this.Controls.Add(this.rbPhoto);
            this.Controls.Add(this.nudPeople);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnBooking_Click);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblNumOfPeople);
            this.Controls.Add(this.lblActivity);
            this.Controls.Add(this.lblNameSurname);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameSurname;
        private System.Windows.Forms.Label lblActivity;
        private System.Windows.Forms.Label lblNumOfPeople;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnBooking_Click;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown nudPeople;
        private System.Windows.Forms.RadioButton rbPhoto;
        private System.Windows.Forms.ComboBox cboActivity;
    }
}

