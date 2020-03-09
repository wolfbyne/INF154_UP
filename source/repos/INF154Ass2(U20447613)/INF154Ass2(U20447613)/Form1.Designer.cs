namespace INF154Ass2_U20447613_
{
    partial class frmBHS
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblVisDetails = new System.Windows.Forms.Label();
            this.lblRoomType1 = new System.Windows.Forms.Label();
            this.gbVisDetails = new System.Windows.Forms.GroupBox();
            this.gbVisType = new System.Windows.Forms.GroupBox();
            this.gpVisFinalisation = new System.Windows.Forms.GroupBox();
            this.lblRoomType2 = new System.Windows.Forms.Label();
            this.lblCPN = new System.Windows.Forms.Label();
            this.lblNON = new System.Windows.Forms.Label();
            this.lblCOV = new System.Windows.Forms.Label();
            this.lblVAT = new System.Windows.Forms.Label();
            this.lblTotCost = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCVD = new System.Windows.Forms.Button();
            this.btnFV = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtCPN = new System.Windows.Forms.TextBox();
            this.txtNON = new System.Windows.Forms.TextBox();
            this.txtCOV = new System.Windows.Forms.TextBox();
            this.txtVAT = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.cbRoomType = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.gbVisDetails.SuspendLayout();
            this.gbVisType.SuspendLayout();
            this.gpVisFinalisation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(91, 51);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(68, 104);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(78, 20);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Surname:";
            // 
            // lblVisDetails
            // 
            this.lblVisDetails.AutoSize = true;
            this.lblVisDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisDetails.Location = new System.Drawing.Point(63, 51);
            this.lblVisDetails.Name = "lblVisDetails";
            this.lblVisDetails.Size = new System.Drawing.Size(207, 20);
            this.lblVisDetails.TabIndex = 2;
            this.lblVisDetails.Text = "Please confirm visitor details";
            // 
            // lblRoomType1
            // 
            this.lblRoomType1.AutoSize = true;
            this.lblRoomType1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType1.Location = new System.Drawing.Point(42, 104);
            this.lblRoomType1.Name = "lblRoomType1";
            this.lblRoomType1.Size = new System.Drawing.Size(94, 20);
            this.lblRoomType1.TabIndex = 3;
            this.lblRoomType1.Text = "Room Type:";
            // 
            // gbVisDetails
            // 
            this.gbVisDetails.Controls.Add(this.txtSurname);
            this.gbVisDetails.Controls.Add(this.txtName);
            this.gbVisDetails.Controls.Add(this.btnCVD);
            this.gbVisDetails.Controls.Add(this.lblName);
            this.gbVisDetails.Controls.Add(this.lblSurname);
            this.gbVisDetails.Location = new System.Drawing.Point(12, 12);
            this.gbVisDetails.Name = "gbVisDetails";
            this.gbVisDetails.Size = new System.Drawing.Size(404, 224);
            this.gbVisDetails.TabIndex = 4;
            this.gbVisDetails.TabStop = false;
            this.gbVisDetails.Text = "Visitor Details";
            // 
            // gbVisType
            // 
            this.gbVisType.Controls.Add(this.cbRoomType);
            this.gbVisType.Controls.Add(this.txtNON);
            this.gbVisType.Controls.Add(this.txtCPN);
            this.gbVisType.Controls.Add(this.button1);
            this.gbVisType.Controls.Add(this.lblNON);
            this.gbVisType.Controls.Add(this.lblCPN);
            this.gbVisType.Controls.Add(this.lblRoomType2);
            this.gbVisType.Location = new System.Drawing.Point(12, 259);
            this.gbVisType.Name = "gbVisType";
            this.gbVisType.Size = new System.Drawing.Size(404, 216);
            this.gbVisType.TabIndex = 5;
            this.gbVisType.TabStop = false;
            this.gbVisType.Text = "Visit Type";
            // 
            // gpVisFinalisation
            // 
            this.gpVisFinalisation.Controls.Add(this.lblStatus);
            this.gpVisFinalisation.Controls.Add(this.txtTC);
            this.gpVisFinalisation.Controls.Add(this.txtVAT);
            this.gpVisFinalisation.Controls.Add(this.txtCOV);
            this.gpVisFinalisation.Controls.Add(this.btnFV);
            this.gpVisFinalisation.Controls.Add(this.lblTotCost);
            this.gpVisFinalisation.Controls.Add(this.lblVAT);
            this.gpVisFinalisation.Controls.Add(this.lblCOV);
            this.gpVisFinalisation.Controls.Add(this.lblVisDetails);
            this.gpVisFinalisation.Controls.Add(this.lblRoomType1);
            this.gpVisFinalisation.Location = new System.Drawing.Point(531, 51);
            this.gpVisFinalisation.Name = "gpVisFinalisation";
            this.gpVisFinalisation.Size = new System.Drawing.Size(341, 390);
            this.gpVisFinalisation.TabIndex = 6;
            this.gpVisFinalisation.TabStop = false;
            this.gpVisFinalisation.Text = "Visit Finalisation";
            // 
            // lblRoomType2
            // 
            this.lblRoomType2.AutoSize = true;
            this.lblRoomType2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType2.Location = new System.Drawing.Point(52, 43);
            this.lblRoomType2.Name = "lblRoomType2";
            this.lblRoomType2.Size = new System.Drawing.Size(94, 20);
            this.lblRoomType2.TabIndex = 0;
            this.lblRoomType2.Text = "Room Type:";
            // 
            // lblCPN
            // 
            this.lblCPN.AutoSize = true;
            this.lblCPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPN.Location = new System.Drawing.Point(6, 91);
            this.lblCPN.Name = "lblCPN";
            this.lblCPN.Size = new System.Drawing.Size(140, 20);
            this.lblCPN.TabIndex = 1;
            this.lblCPN.Text = "Cost per Night (R):";
            // 
            // lblNON
            // 
            this.lblNON.AutoSize = true;
            this.lblNON.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNON.Location = new System.Drawing.Point(10, 136);
            this.lblNON.Name = "lblNON";
            this.lblNON.Size = new System.Drawing.Size(136, 20);
            this.lblNON.TabIndex = 2;
            this.lblNON.Text = "Number of Nights:";
            // 
            // lblCOV
            // 
            this.lblCOV.AutoSize = true;
            this.lblCOV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCOV.Location = new System.Drawing.Point(38, 162);
            this.lblCOV.Name = "lblCOV";
            this.lblCOV.Size = new System.Drawing.Size(98, 20);
            this.lblCOV.TabIndex = 4;
            this.lblCOV.Text = "Cost of Visit:";
            // 
            // lblVAT
            // 
            this.lblVAT.AutoSize = true;
            this.lblVAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVAT.Location = new System.Drawing.Point(92, 216);
            this.lblVAT.Name = "lblVAT";
            this.lblVAT.Size = new System.Drawing.Size(44, 20);
            this.lblVAT.TabIndex = 5;
            this.lblVAT.Text = "VAT:";
            // 
            // lblTotCost
            // 
            this.lblTotCost.AutoSize = true;
            this.lblTotCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotCost.Location = new System.Drawing.Point(51, 267);
            this.lblTotCost.Name = "lblTotCost";
            this.lblTotCost.Size = new System.Drawing.Size(85, 20);
            this.lblTotCost.TabIndex = 6;
            this.lblTotCost.Text = "Total Cost:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(95, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Confirm Visit Type";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCVD
            // 
            this.btnCVD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCVD.Location = new System.Drawing.Point(95, 165);
            this.btnCVD.Name = "btnCVD";
            this.btnCVD.Size = new System.Drawing.Size(204, 36);
            this.btnCVD.TabIndex = 2;
            this.btnCVD.Text = "Confirm Visitor Details";
            this.btnCVD.UseVisualStyleBackColor = true;
            this.btnCVD.Click += new System.EventHandler(this.btnCVD_Click);
            // 
            // btnFV
            // 
            this.btnFV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFV.Location = new System.Drawing.Point(106, 344);
            this.btnFV.Name = "btnFV";
            this.btnFV.Size = new System.Drawing.Size(119, 40);
            this.btnFV.TabIndex = 7;
            this.btnFV.Text = "Finalise Visit";
            this.btnFV.UseVisualStyleBackColor = true;
            this.btnFV.Click += new System.EventHandler(this.btnFV_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(222, 50);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(222, 104);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 4;
            // 
            // txtCPN
            // 
            this.txtCPN.Location = new System.Drawing.Point(222, 91);
            this.txtCPN.Name = "txtCPN";
            this.txtCPN.Size = new System.Drawing.Size(57, 20);
            this.txtCPN.TabIndex = 5;
            this.txtCPN.Text = "0";
            // 
            // txtNON
            // 
            this.txtNON.Location = new System.Drawing.Point(222, 136);
            this.txtNON.Name = "txtNON";
            this.txtNON.Size = new System.Drawing.Size(57, 20);
            this.txtNON.TabIndex = 6;
            this.txtNON.Text = "1";
            // 
            // txtCOV
            // 
            this.txtCOV.Location = new System.Drawing.Point(170, 162);
            this.txtCOV.Name = "txtCOV";
            this.txtCOV.ReadOnly = true;
            this.txtCOV.Size = new System.Drawing.Size(100, 20);
            this.txtCOV.TabIndex = 8;
            this.txtCOV.Text = "0";
            // 
            // txtVAT
            // 
            this.txtVAT.Location = new System.Drawing.Point(170, 216);
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.ReadOnly = true;
            this.txtVAT.Size = new System.Drawing.Size(100, 20);
            this.txtVAT.TabIndex = 9;
            this.txtVAT.Text = "0";
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(170, 267);
            this.txtTC.Name = "txtTC";
            this.txtTC.ReadOnly = true;
            this.txtTC.Size = new System.Drawing.Size(100, 20);
            this.txtTC.TabIndex = 10;
            this.txtTC.Text = "0";
            // 
            // cbRoomType
            // 
            this.cbRoomType.FormattingEnabled = true;
            this.cbRoomType.Items.AddRange(new object[] {
            "Basic",
            "Basic Plus",
            "Penthouse"});
            this.cbRoomType.Location = new System.Drawing.Point(222, 41);
            this.cbRoomType.Name = "cbRoomType";
            this.cbRoomType.Size = new System.Drawing.Size(121, 21);
            this.cbRoomType.TabIndex = 7;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(166, 100);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(115, 24);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "Not selected";
            // 
            // frmBHS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 526);
            this.Controls.Add(this.gpVisFinalisation);
            this.Controls.Add(this.gbVisType);
            this.Controls.Add(this.gbVisDetails);
            this.Name = "frmBHS";
            this.Text = "Best Hotel System";
            this.gbVisDetails.ResumeLayout(false);
            this.gbVisDetails.PerformLayout();
            this.gbVisType.ResumeLayout(false);
            this.gbVisType.PerformLayout();
            this.gpVisFinalisation.ResumeLayout(false);
            this.gpVisFinalisation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblVisDetails;
        private System.Windows.Forms.Label lblRoomType1;
        private System.Windows.Forms.GroupBox gbVisDetails;
        private System.Windows.Forms.GroupBox gbVisType;
        private System.Windows.Forms.Label lblRoomType2;
        private System.Windows.Forms.GroupBox gpVisFinalisation;
        private System.Windows.Forms.Label lblNON;
        private System.Windows.Forms.Label lblCPN;
        private System.Windows.Forms.Label lblTotCost;
        private System.Windows.Forms.Label lblVAT;
        private System.Windows.Forms.Label lblCOV;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnCVD;
        private System.Windows.Forms.ComboBox cbRoomType;
        private System.Windows.Forms.TextBox txtNON;
        private System.Windows.Forms.TextBox txtCPN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.TextBox txtVAT;
        private System.Windows.Forms.TextBox txtCOV;
        private System.Windows.Forms.Button btnFV;
    }
}

