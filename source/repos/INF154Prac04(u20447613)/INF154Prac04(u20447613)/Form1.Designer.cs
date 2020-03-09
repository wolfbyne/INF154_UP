namespace INF154Prac04_u20447613_
{
    partial class frmUni
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
            this.gbStuDet = new System.Windows.Forms.GroupBox();
            this.gbMarAna = new System.Windows.Forms.GroupBox();
            this.gbModInf = new System.Windows.Forms.GroupBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblStuNum = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblModName = new System.Windows.Forms.Label();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.lblTitle3 = new System.Windows.Forms.Label();
            this.lblOutput1 = new System.Windows.Forms.Label();
            this.lblOutput2 = new System.Windows.Forms.Label();
            this.lblOutput3 = new System.Windows.Forms.Label();
            this.lblOutput4 = new System.Windows.Forms.Label();
            this.lblTitle4 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtStuNum = new System.Windows.Forms.TextBox();
            this.txtMark = new System.Windows.Forms.TextBox();
            this.btnConfirmDetails = new System.Windows.Forms.Button();
            this.btnAnalyse = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.cbModuleName = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.gbStuDet.SuspendLayout();
            this.gbMarAna.SuspendLayout();
            this.gbModInf.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbStuDet
            // 
            this.gbStuDet.Controls.Add(this.rbFemale);
            this.gbStuDet.Controls.Add(this.rbMale);
            this.gbStuDet.Controls.Add(this.btnConfirmDetails);
            this.gbStuDet.Controls.Add(this.txtStuNum);
            this.gbStuDet.Controls.Add(this.txtFullName);
            this.gbStuDet.Controls.Add(this.lblStuNum);
            this.gbStuDet.Controls.Add(this.lblGender);
            this.gbStuDet.Controls.Add(this.lblFullName);
            this.gbStuDet.Location = new System.Drawing.Point(12, 12);
            this.gbStuDet.Name = "gbStuDet";
            this.gbStuDet.Size = new System.Drawing.Size(416, 251);
            this.gbStuDet.TabIndex = 0;
            this.gbStuDet.TabStop = false;
            this.gbStuDet.Text = "Student Details";
            // 
            // gbMarAna
            // 
            this.gbMarAna.Controls.Add(this.lblPercentage);
            this.gbMarAna.Controls.Add(this.btnAnalyse);
            this.gbMarAna.Controls.Add(this.txtMark);
            this.gbMarAna.Controls.Add(this.lblTitle);
            this.gbMarAna.Location = new System.Drawing.Point(12, 269);
            this.gbMarAna.Name = "gbMarAna";
            this.gbMarAna.Size = new System.Drawing.Size(416, 265);
            this.gbMarAna.TabIndex = 1;
            this.gbMarAna.TabStop = false;
            this.gbMarAna.Text = "Mark Analysis";
            // 
            // gbModInf
            // 
            this.gbModInf.Controls.Add(this.cbModuleName);
            this.gbModInf.Controls.Add(this.btnConfirm);
            this.gbModInf.Controls.Add(this.lblTitle4);
            this.gbModInf.Controls.Add(this.lblOutput4);
            this.gbModInf.Controls.Add(this.lblOutput3);
            this.gbModInf.Controls.Add(this.lblOutput2);
            this.gbModInf.Controls.Add(this.lblOutput1);
            this.gbModInf.Controls.Add(this.lblTitle3);
            this.gbModInf.Controls.Add(this.lblTitle2);
            this.gbModInf.Controls.Add(this.lblTitle1);
            this.gbModInf.Controls.Add(this.lblModName);
            this.gbModInf.Location = new System.Drawing.Point(469, 12);
            this.gbModInf.Name = "gbModInf";
            this.gbModInf.Size = new System.Drawing.Size(285, 413);
            this.gbModInf.TabIndex = 1;
            this.gbModInf.TabStop = false;
            this.gbModInf.Text = "Module Information";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(77, 52);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(57, 13);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Full Name:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(80, 94);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 1;
            this.lblGender.Text = "Gender";
            // 
            // lblStuNum
            // 
            this.lblStuNum.AutoSize = true;
            this.lblStuNum.Location = new System.Drawing.Point(77, 168);
            this.lblStuNum.Name = "lblStuNum";
            this.lblStuNum.Size = new System.Drawing.Size(87, 13);
            this.lblStuNum.TabIndex = 2;
            this.lblStuNum.Text = "Student Number:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(61, 73);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(228, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Please Enter Your Semester Mark For INF 154:";
            // 
            // lblModName
            // 
            this.lblModName.AutoSize = true;
            this.lblModName.Location = new System.Drawing.Point(43, 64);
            this.lblModName.Name = "lblModName";
            this.lblModName.Size = new System.Drawing.Size(76, 13);
            this.lblModName.TabIndex = 0;
            this.lblModName.Text = "Module Name:";
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.Location = new System.Drawing.Point(6, 168);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(99, 13);
            this.lblTitle1.TabIndex = 1;
            this.lblTitle1.Text = "Taken in Semester:";
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Location = new System.Drawing.Point(6, 211);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(184, 13);
            this.lblTitle2.TabIndex = 2;
            this.lblTitle2.Text = "Number of Enrolled Students In 2020:";
            // 
            // lblTitle3
            // 
            this.lblTitle3.AutoSize = true;
            this.lblTitle3.Location = new System.Drawing.Point(6, 257);
            this.lblTitle3.Name = "lblTitle3";
            this.lblTitle3.Size = new System.Drawing.Size(86, 13);
            this.lblTitle3.TabIndex = 3;
            this.lblTitle3.Text = "2019 Pass Rate:";
            // 
            // lblOutput1
            // 
            this.lblOutput1.AutoSize = true;
            this.lblOutput1.Location = new System.Drawing.Point(238, 168);
            this.lblOutput1.Name = "lblOutput1";
            this.lblOutput1.Size = new System.Drawing.Size(43, 13);
            this.lblOutput1.TabIndex = 4;
            this.lblOutput1.Text = "output1";
            this.lblOutput1.Visible = false;
            // 
            // lblOutput2
            // 
            this.lblOutput2.AutoSize = true;
            this.lblOutput2.Location = new System.Drawing.Point(238, 211);
            this.lblOutput2.Name = "lblOutput2";
            this.lblOutput2.Size = new System.Drawing.Size(43, 13);
            this.lblOutput2.TabIndex = 5;
            this.lblOutput2.Text = "output2";
            this.lblOutput2.Visible = false;
            // 
            // lblOutput3
            // 
            this.lblOutput3.AutoSize = true;
            this.lblOutput3.Location = new System.Drawing.Point(238, 257);
            this.lblOutput3.Name = "lblOutput3";
            this.lblOutput3.Size = new System.Drawing.Size(46, 13);
            this.lblOutput3.TabIndex = 6;
            this.lblOutput3.Text = "output 3";
            this.lblOutput3.Visible = false;
            // 
            // lblOutput4
            // 
            this.lblOutput4.AutoSize = true;
            this.lblOutput4.Location = new System.Drawing.Point(238, 306);
            this.lblOutput4.Name = "lblOutput4";
            this.lblOutput4.Size = new System.Drawing.Size(46, 13);
            this.lblOutput4.TabIndex = 7;
            this.lblOutput4.Text = "output 4";
            this.lblOutput4.Visible = false;
            // 
            // lblTitle4
            // 
            this.lblTitle4.AutoSize = true;
            this.lblTitle4.Location = new System.Drawing.Point(6, 306);
            this.lblTitle4.Name = "lblTitle4";
            this.lblTitle4.Size = new System.Drawing.Size(77, 13);
            this.lblTitle4.TabIndex = 8;
            this.lblTitle4.Text = "2019 Average:";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(230, 52);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(100, 20);
            this.txtFullName.TabIndex = 3;
            // 
            // txtStuNum
            // 
            this.txtStuNum.Location = new System.Drawing.Point(230, 168);
            this.txtStuNum.Name = "txtStuNum";
            this.txtStuNum.Size = new System.Drawing.Size(100, 20);
            this.txtStuNum.TabIndex = 4;
            // 
            // txtMark
            // 
            this.txtMark.Location = new System.Drawing.Point(127, 136);
            this.txtMark.Name = "txtMark";
            this.txtMark.Size = new System.Drawing.Size(100, 20);
            this.txtMark.TabIndex = 1;
            // 
            // btnConfirmDetails
            // 
            this.btnConfirmDetails.Location = new System.Drawing.Point(161, 211);
            this.btnConfirmDetails.Name = "btnConfirmDetails";
            this.btnConfirmDetails.Size = new System.Drawing.Size(102, 23);
            this.btnConfirmDetails.TabIndex = 5;
            this.btnConfirmDetails.Text = "Confirm Details";
            this.btnConfirmDetails.UseVisualStyleBackColor = true;
            this.btnConfirmDetails.Click += new System.EventHandler(this.btnConfirmDetails_Click);
            // 
            // btnAnalyse
            // 
            this.btnAnalyse.Location = new System.Drawing.Point(138, 189);
            this.btnAnalyse.Name = "btnAnalyse";
            this.btnAnalyse.Size = new System.Drawing.Size(75, 23);
            this.btnAnalyse.TabIndex = 2;
            this.btnAnalyse.Text = "Analyse";
            this.btnAnalyse.UseVisualStyleBackColor = true;
            this.btnAnalyse.Click += new System.EventHandler(this.btnAnalyse_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(128, 363);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 9;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(230, 94);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 6;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(230, 118);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 7;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // cbModuleName
            // 
            this.cbModuleName.FormattingEnabled = true;
            this.cbModuleName.Items.AddRange(new object[] {
            "INF 154",
            "INF 164",
            "INF 171",
            "OBS 110",
            "OBS 120"});
            this.cbModuleName.Location = new System.Drawing.Point(157, 64);
            this.cbModuleName.Name = "cbModuleName";
            this.cbModuleName.Size = new System.Drawing.Size(121, 21);
            this.cbModuleName.TabIndex = 10;
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Location = new System.Drawing.Point(233, 139);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(15, 13);
            this.lblPercentage.TabIndex = 3;
            this.lblPercentage.Text = "%";
            // 
            // frmUni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 546);
            this.Controls.Add(this.gbModInf);
            this.Controls.Add(this.gbMarAna);
            this.Controls.Add(this.gbStuDet);
            this.Name = "frmUni";
            this.Text = "University";
            this.gbStuDet.ResumeLayout(false);
            this.gbStuDet.PerformLayout();
            this.gbMarAna.ResumeLayout(false);
            this.gbMarAna.PerformLayout();
            this.gbModInf.ResumeLayout(false);
            this.gbModInf.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbStuDet;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Button btnConfirmDetails;
        private System.Windows.Forms.TextBox txtStuNum;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblStuNum;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.GroupBox gbMarAna;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Button btnAnalyse;
        private System.Windows.Forms.TextBox txtMark;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbModInf;
        private System.Windows.Forms.ComboBox cbModuleName;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblTitle4;
        private System.Windows.Forms.Label lblOutput4;
        private System.Windows.Forms.Label lblOutput3;
        private System.Windows.Forms.Label lblOutput2;
        private System.Windows.Forms.Label lblOutput1;
        private System.Windows.Forms.Label lblTitle3;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.Label lblModName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

