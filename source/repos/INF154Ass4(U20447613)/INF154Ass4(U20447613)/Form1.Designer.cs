namespace INF154Ass4_U20447613_
{
    partial class frmStoreCardRegistration
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
            this.gbClientDetails = new System.Windows.Forms.GroupBox();
            this.gbAccDet = new System.Windows.Forms.GroupBox();
            this.gbNewAccInfo = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAccType2 = new System.Windows.Forms.Label();
            this.lblCredLim = new System.Windows.Forms.Label();
            this.lblNameAccHol = new System.Windows.Forms.Label();
            this.lblAccType1 = new System.Windows.Forms.Label();
            this.lblAccCreLim = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtNameAccHolder = new System.Windows.Forms.TextBox();
            this.txtAccountType1 = new System.Windows.Forms.TextBox();
            this.txtAccCredLim = new System.Windows.Forms.TextBox();
            this.rbForSameClient = new System.Windows.Forms.RadioButton();
            this.rbForDifferentClient = new System.Windows.Forms.RadioButton();
            this.btnSubmitClient = new System.Windows.Forms.Button();
            this.btnAddAnotherAcc = new System.Windows.Forms.Button();
            this.btnSubmitAccount = new System.Windows.Forms.Button();
            this.nupYOB = new System.Windows.Forms.NumericUpDown();
            this.nupCL = new System.Windows.Forms.NumericUpDown();
            this.cbAccType = new System.Windows.Forms.ComboBox();
            this.gbClientDetails.SuspendLayout();
            this.gbAccDet.SuspendLayout();
            this.gbNewAccInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupYOB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupCL)).BeginInit();
            this.SuspendLayout();
            // 
            // gbClientDetails
            // 
            this.gbClientDetails.Controls.Add(this.nupYOB);
            this.gbClientDetails.Controls.Add(this.btnSubmitClient);
            this.gbClientDetails.Controls.Add(this.txtSurname);
            this.gbClientDetails.Controls.Add(this.txtName);
            this.gbClientDetails.Controls.Add(this.label3);
            this.gbClientDetails.Controls.Add(this.lblSurname);
            this.gbClientDetails.Controls.Add(this.lblName);
            this.gbClientDetails.Location = new System.Drawing.Point(12, 12);
            this.gbClientDetails.Name = "gbClientDetails";
            this.gbClientDetails.Size = new System.Drawing.Size(426, 252);
            this.gbClientDetails.TabIndex = 0;
            this.gbClientDetails.TabStop = false;
            this.gbClientDetails.Text = "Client Details";
            // 
            // gbAccDet
            // 
            this.gbAccDet.Controls.Add(this.cbAccType);
            this.gbAccDet.Controls.Add(this.nupCL);
            this.gbAccDet.Controls.Add(this.btnSubmitAccount);
            this.gbAccDet.Controls.Add(this.lblCredLim);
            this.gbAccDet.Controls.Add(this.lblAccType2);
            this.gbAccDet.Location = new System.Drawing.Point(469, 57);
            this.gbAccDet.Name = "gbAccDet";
            this.gbAccDet.Size = new System.Drawing.Size(374, 174);
            this.gbAccDet.TabIndex = 1;
            this.gbAccDet.TabStop = false;
            this.gbAccDet.Text = "Account Details";
            this.gbAccDet.Visible = false;
            // 
            // gbNewAccInfo
            // 
            this.gbNewAccInfo.Controls.Add(this.btnAddAnotherAcc);
            this.gbNewAccInfo.Controls.Add(this.rbForDifferentClient);
            this.gbNewAccInfo.Controls.Add(this.rbForSameClient);
            this.gbNewAccInfo.Controls.Add(this.txtAccCredLim);
            this.gbNewAccInfo.Controls.Add(this.txtAccountType1);
            this.gbNewAccInfo.Controls.Add(this.txtNameAccHolder);
            this.gbNewAccInfo.Controls.Add(this.lblAccCreLim);
            this.gbNewAccInfo.Controls.Add(this.lblAccType1);
            this.gbNewAccInfo.Controls.Add(this.lblNameAccHol);
            this.gbNewAccInfo.Location = new System.Drawing.Point(12, 288);
            this.gbNewAccInfo.Name = "gbNewAccInfo";
            this.gbNewAccInfo.Size = new System.Drawing.Size(851, 227);
            this.gbNewAccInfo.TabIndex = 2;
            this.gbNewAccInfo.TabStop = false;
            this.gbNewAccInfo.Text = "New Account Confirmed";
            this.gbNewAccInfo.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(58, 67);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(58, 106);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Surname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Year of Birth:";
            // 
            // lblAccType2
            // 
            this.lblAccType2.AutoSize = true;
            this.lblAccType2.Location = new System.Drawing.Point(44, 46);
            this.lblAccType2.Name = "lblAccType2";
            this.lblAccType2.Size = new System.Drawing.Size(77, 13);
            this.lblAccType2.TabIndex = 0;
            this.lblAccType2.Text = "Account Type:";
            // 
            // lblCredLim
            // 
            this.lblCredLim.AutoSize = true;
            this.lblCredLim.Location = new System.Drawing.Point(47, 89);
            this.lblCredLim.Name = "lblCredLim";
            this.lblCredLim.Size = new System.Drawing.Size(61, 13);
            this.lblCredLim.TabIndex = 1;
            this.lblCredLim.Text = "Credit Limit:";
            // 
            // lblNameAccHol
            // 
            this.lblNameAccHol.AutoSize = true;
            this.lblNameAccHol.Location = new System.Drawing.Point(58, 63);
            this.lblNameAccHol.Name = "lblNameAccHol";
            this.lblNameAccHol.Size = new System.Drawing.Size(127, 13);
            this.lblNameAccHol.TabIndex = 0;
            this.lblNameAccHol.Text = "Name of Account Holder:";
            // 
            // lblAccType1
            // 
            this.lblAccType1.AutoSize = true;
            this.lblAccType1.Location = new System.Drawing.Point(58, 112);
            this.lblAccType1.Name = "lblAccType1";
            this.lblAccType1.Size = new System.Drawing.Size(77, 13);
            this.lblAccType1.TabIndex = 1;
            this.lblAccType1.Text = "Account Type:";
            // 
            // lblAccCreLim
            // 
            this.lblAccCreLim.AutoSize = true;
            this.lblAccCreLim.Location = new System.Drawing.Point(58, 158);
            this.lblAccCreLim.Name = "lblAccCreLim";
            this.lblAccCreLim.Size = new System.Drawing.Size(104, 13);
            this.lblAccCreLim.TabIndex = 2;
            this.lblAccCreLim.Text = "Account Credit Limit:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(256, 64);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(256, 103);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 4;
            // 
            // txtNameAccHolder
            // 
            this.txtNameAccHolder.Location = new System.Drawing.Point(319, 63);
            this.txtNameAccHolder.Name = "txtNameAccHolder";
            this.txtNameAccHolder.ReadOnly = true;
            this.txtNameAccHolder.Size = new System.Drawing.Size(100, 20);
            this.txtNameAccHolder.TabIndex = 3;
            // 
            // txtAccountType1
            // 
            this.txtAccountType1.Location = new System.Drawing.Point(319, 109);
            this.txtAccountType1.Name = "txtAccountType1";
            this.txtAccountType1.ReadOnly = true;
            this.txtAccountType1.Size = new System.Drawing.Size(100, 20);
            this.txtAccountType1.TabIndex = 4;
            // 
            // txtAccCredLim
            // 
            this.txtAccCredLim.Location = new System.Drawing.Point(319, 155);
            this.txtAccCredLim.Name = "txtAccCredLim";
            this.txtAccCredLim.ReadOnly = true;
            this.txtAccCredLim.Size = new System.Drawing.Size(100, 20);
            this.txtAccCredLim.TabIndex = 5;
            // 
            // rbForSameClient
            // 
            this.rbForSameClient.AutoSize = true;
            this.rbForSameClient.Location = new System.Drawing.Point(633, 82);
            this.rbForSameClient.Name = "rbForSameClient";
            this.rbForSameClient.Size = new System.Drawing.Size(114, 17);
            this.rbForSameClient.TabIndex = 6;
            this.rbForSameClient.TabStop = true;
            this.rbForSameClient.Text = "For the same client";
            this.rbForSameClient.UseVisualStyleBackColor = true;
            // 
            // rbForDifferentClient
            // 
            this.rbForDifferentClient.AutoSize = true;
            this.rbForDifferentClient.Location = new System.Drawing.Point(633, 106);
            this.rbForDifferentClient.Name = "rbForDifferentClient";
            this.rbForDifferentClient.Size = new System.Drawing.Size(118, 17);
            this.rbForDifferentClient.TabIndex = 7;
            this.rbForDifferentClient.TabStop = true;
            this.rbForDifferentClient.Text = "For a different client";
            this.rbForDifferentClient.UseVisualStyleBackColor = true;
            // 
            // btnSubmitClient
            // 
            this.btnSubmitClient.Location = new System.Drawing.Point(163, 207);
            this.btnSubmitClient.Name = "btnSubmitClient";
            this.btnSubmitClient.Size = new System.Drawing.Size(123, 23);
            this.btnSubmitClient.TabIndex = 5;
            this.btnSubmitClient.Text = "Submit Client";
            this.btnSubmitClient.UseVisualStyleBackColor = true;
            this.btnSubmitClient.Click += new System.EventHandler(this.btnSubmitClient_Click);
            // 
            // btnAddAnotherAcc
            // 
            this.btnAddAnotherAcc.Location = new System.Drawing.Point(633, 148);
            this.btnAddAnotherAcc.Name = "btnAddAnotherAcc";
            this.btnAddAnotherAcc.Size = new System.Drawing.Size(120, 23);
            this.btnAddAnotherAcc.TabIndex = 8;
            this.btnAddAnotherAcc.Text = "Add Another Account";
            this.btnAddAnotherAcc.UseVisualStyleBackColor = true;
            this.btnAddAnotherAcc.Click += new System.EventHandler(this.btnAddAnotherAcc_Click);
            // 
            // btnSubmitAccount
            // 
            this.btnSubmitAccount.Location = new System.Drawing.Point(166, 145);
            this.btnSubmitAccount.Name = "btnSubmitAccount";
            this.btnSubmitAccount.Size = new System.Drawing.Size(104, 23);
            this.btnSubmitAccount.TabIndex = 2;
            this.btnSubmitAccount.Text = "Submit Account";
            this.btnSubmitAccount.UseVisualStyleBackColor = true;
            this.btnSubmitAccount.Click += new System.EventHandler(this.btnSubmitAccount_Click);
            // 
            // nupYOB
            // 
            this.nupYOB.Location = new System.Drawing.Point(256, 152);
            this.nupYOB.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nupYOB.Name = "nupYOB";
            this.nupYOB.Size = new System.Drawing.Size(72, 20);
            this.nupYOB.TabIndex = 6;
            this.nupYOB.Value = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            // 
            // nupCL
            // 
            this.nupCL.Location = new System.Drawing.Point(176, 87);
            this.nupCL.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nupCL.Name = "nupCL";
            this.nupCL.Size = new System.Drawing.Size(72, 20);
            this.nupCL.TabIndex = 7;
            // 
            // cbAccType
            // 
            this.cbAccType.FormattingEnabled = true;
            this.cbAccType.Items.AddRange(new object[] {
            "Clever Shopper",
            "Club Card",
            "Big-Spender Card"});
            this.cbAccType.Location = new System.Drawing.Point(176, 46);
            this.cbAccType.Name = "cbAccType";
            this.cbAccType.Size = new System.Drawing.Size(121, 21);
            this.cbAccType.TabIndex = 8;
            // 
            // frmStoreCardRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 527);
            this.Controls.Add(this.gbNewAccInfo);
            this.Controls.Add(this.gbAccDet);
            this.Controls.Add(this.gbClientDetails);
            this.Name = "frmStoreCardRegistration";
            this.Text = "Store Card Registration";
            this.gbClientDetails.ResumeLayout(false);
            this.gbClientDetails.PerformLayout();
            this.gbAccDet.ResumeLayout(false);
            this.gbAccDet.PerformLayout();
            this.gbNewAccInfo.ResumeLayout(false);
            this.gbNewAccInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupYOB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupCL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbClientDetails;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox gbAccDet;
        private System.Windows.Forms.Label lblCredLim;
        private System.Windows.Forms.Label lblAccType2;
        private System.Windows.Forms.GroupBox gbNewAccInfo;
        private System.Windows.Forms.TextBox txtAccCredLim;
        private System.Windows.Forms.TextBox txtAccountType1;
        private System.Windows.Forms.TextBox txtNameAccHolder;
        private System.Windows.Forms.Label lblAccCreLim;
        private System.Windows.Forms.Label lblAccType1;
        private System.Windows.Forms.Label lblNameAccHol;
        private System.Windows.Forms.Button btnSubmitClient;
        private System.Windows.Forms.Button btnSubmitAccount;
        private System.Windows.Forms.Button btnAddAnotherAcc;
        private System.Windows.Forms.RadioButton rbForDifferentClient;
        private System.Windows.Forms.RadioButton rbForSameClient;
        private System.Windows.Forms.NumericUpDown nupYOB;
        private System.Windows.Forms.ComboBox cbAccType;
        private System.Windows.Forms.NumericUpDown nupCL;
    }
}

