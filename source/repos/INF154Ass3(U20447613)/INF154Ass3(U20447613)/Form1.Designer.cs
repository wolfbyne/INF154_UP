namespace INF154Ass3_U20447613_
{
    partial class frmFitness
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
            this.gbVD = new System.Windows.Forms.GroupBox();
            this.gbBMI = new System.Windows.Forms.GroupBox();
            this.gbFC = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCD = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPounds = new System.Windows.Forms.TextBox();
            this.txtInches = new System.Windows.Forms.TextBox();
            this.txtKG = new System.Windows.Forms.TextBox();
            this.txtCM = new System.Windows.Forms.TextBox();
            this.lblWeightIn = new System.Windows.Forms.Label();
            this.lblHeightIn = new System.Windows.Forms.Label();
            this.lblKGin = new System.Windows.Forms.Label();
            this.lblWeightOut = new System.Windows.Forms.Label();
            this.lblHeightOut = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblCMin = new System.Windows.Forms.Label();
            this.btnBMI = new System.Windows.Forms.Button();
            this.btnCW = new System.Windows.Forms.Button();
            this.btnCH = new System.Windows.Forms.Button();
            this.gbVD.SuspendLayout();
            this.gbBMI.SuspendLayout();
            this.gbFC.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbVD
            // 
            this.gbVD.Controls.Add(this.txtID);
            this.gbVD.Controls.Add(this.txtSurname);
            this.gbVD.Controls.Add(this.txtName);
            this.gbVD.Controls.Add(this.btnCD);
            this.gbVD.Controls.Add(this.label3);
            this.gbVD.Controls.Add(this.label2);
            this.gbVD.Controls.Add(this.lblName);
            this.gbVD.Location = new System.Drawing.Point(12, 12);
            this.gbVD.Name = "gbVD";
            this.gbVD.Size = new System.Drawing.Size(365, 221);
            this.gbVD.TabIndex = 0;
            this.gbVD.TabStop = false;
            this.gbVD.Text = "Visitor Details";
            // 
            // gbBMI
            // 
            this.gbBMI.Controls.Add(this.btnBMI);
            this.gbBMI.Controls.Add(this.lblResult);
            this.gbBMI.Controls.Add(this.lblHeightIn);
            this.gbBMI.Controls.Add(this.lblWeightIn);
            this.gbBMI.Controls.Add(this.txtInches);
            this.gbBMI.Controls.Add(this.txtPounds);
            this.gbBMI.Location = new System.Drawing.Point(12, 239);
            this.gbBMI.Name = "gbBMI";
            this.gbBMI.Size = new System.Drawing.Size(456, 260);
            this.gbBMI.TabIndex = 1;
            this.gbBMI.TabStop = false;
            this.gbBMI.Text = "BMI Calculator";
            // 
            // gbFC
            // 
            this.gbFC.Controls.Add(this.btnCH);
            this.gbFC.Controls.Add(this.btnCW);
            this.gbFC.Controls.Add(this.lblCMin);
            this.gbFC.Controls.Add(this.lblHeightOut);
            this.gbFC.Controls.Add(this.lblWeightOut);
            this.gbFC.Controls.Add(this.lblKGin);
            this.gbFC.Controls.Add(this.txtCM);
            this.gbFC.Controls.Add(this.txtKG);
            this.gbFC.Location = new System.Drawing.Point(497, 12);
            this.gbFC.Name = "gbFC";
            this.gbFC.Size = new System.Drawing.Size(277, 487);
            this.gbFC.TabIndex = 2;
            this.gbFC.TabStop = false;
            this.gbFC.Text = "Fitness Converter";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(41, 57);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID Number:";
            // 
            // btnCD
            // 
            this.btnCD.Location = new System.Drawing.Point(98, 176);
            this.btnCD.Name = "btnCD";
            this.btnCD.Size = new System.Drawing.Size(126, 29);
            this.btnCD.TabIndex = 3;
            this.btnCD.Text = "Confirm Details";
            this.btnCD.UseVisualStyleBackColor = true;
            this.btnCD.Click += new System.EventHandler(this.btnCD_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(146, 54);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(146, 97);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 5;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(146, 141);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 6;
            // 
            // txtPounds
            // 
            this.txtPounds.Location = new System.Drawing.Point(235, 69);
            this.txtPounds.Name = "txtPounds";
            this.txtPounds.Size = new System.Drawing.Size(130, 20);
            this.txtPounds.TabIndex = 0;
            // 
            // txtInches
            // 
            this.txtInches.Location = new System.Drawing.Point(235, 144);
            this.txtInches.Name = "txtInches";
            this.txtInches.Size = new System.Drawing.Size(130, 20);
            this.txtInches.TabIndex = 1;
            // 
            // txtKG
            // 
            this.txtKG.Location = new System.Drawing.Point(94, 100);
            this.txtKG.Name = "txtKG";
            this.txtKG.Size = new System.Drawing.Size(100, 20);
            this.txtKG.TabIndex = 0;
            // 
            // txtCM
            // 
            this.txtCM.Location = new System.Drawing.Point(94, 309);
            this.txtCM.Name = "txtCM";
            this.txtCM.Size = new System.Drawing.Size(100, 20);
            this.txtCM.TabIndex = 1;
            // 
            // lblWeightIn
            // 
            this.lblWeightIn.AutoSize = true;
            this.lblWeightIn.Location = new System.Drawing.Point(31, 72);
            this.lblWeightIn.Name = "lblWeightIn";
            this.lblWeightIn.Size = new System.Drawing.Size(183, 13);
            this.lblWeightIn.TabIndex = 2;
            this.lblWeightIn.Text = "Please Enter Your Weight In Pounds:";
            // 
            // lblHeightIn
            // 
            this.lblHeightIn.AutoSize = true;
            this.lblHeightIn.Location = new System.Drawing.Point(31, 147);
            this.lblHeightIn.Name = "lblHeightIn";
            this.lblHeightIn.Size = new System.Drawing.Size(173, 13);
            this.lblHeightIn.TabIndex = 3;
            this.lblHeightIn.Text = "Please Enter Your Height In Inches";
            // 
            // lblKGin
            // 
            this.lblKGin.AutoSize = true;
            this.lblKGin.Location = new System.Drawing.Point(60, 67);
            this.lblKGin.Name = "lblKGin";
            this.lblKGin.Size = new System.Drawing.Size(121, 13);
            this.lblKGin.TabIndex = 2;
            this.lblKGin.Text = "Enter your weight in KG:";
            // 
            // lblWeightOut
            // 
            this.lblWeightOut.AutoSize = true;
            this.lblWeightOut.Location = new System.Drawing.Point(91, 208);
            this.lblWeightOut.Name = "lblWeightOut";
            this.lblWeightOut.Size = new System.Drawing.Size(94, 13);
            this.lblWeightOut.TabIndex = 3;
            this.lblWeightOut.Text = "Weight in Pounds:";
            // 
            // lblHeightOut
            // 
            this.lblHeightOut.AutoSize = true;
            this.lblHeightOut.Location = new System.Drawing.Point(60, 409);
            this.lblHeightOut.Name = "lblHeightOut";
            this.lblHeightOut.Size = new System.Drawing.Size(84, 13);
            this.lblHeightOut.TabIndex = 4;
            this.lblHeightOut.Text = "Height in Inches";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(235, 193);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(32, 13);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "result";
            this.lblResult.Visible = false;
            // 
            // lblCMin
            // 
            this.lblCMin.AutoSize = true;
            this.lblCMin.Location = new System.Drawing.Point(91, 275);
            this.lblCMin.Name = "lblCMin";
            this.lblCMin.Size = new System.Drawing.Size(120, 13);
            this.lblCMin.TabIndex = 5;
            this.lblCMin.Text = "Enter your height in CM:";
            // 
            // btnBMI
            // 
            this.btnBMI.Location = new System.Drawing.Point(44, 193);
            this.btnBMI.Name = "btnBMI";
            this.btnBMI.Size = new System.Drawing.Size(104, 29);
            this.btnBMI.TabIndex = 5;
            this.btnBMI.Text = "Calculate BMI";
            this.btnBMI.UseVisualStyleBackColor = true;
            this.btnBMI.Click += new System.EventHandler(this.btnBMI_Click);
            // 
            // btnCW
            // 
            this.btnCW.Location = new System.Drawing.Point(94, 144);
            this.btnCW.Name = "btnCW";
            this.btnCW.Size = new System.Drawing.Size(100, 23);
            this.btnCW.TabIndex = 6;
            this.btnCW.Text = "Convert Weight";
            this.btnCW.UseVisualStyleBackColor = true;
            this.btnCW.Click += new System.EventHandler(this.btnCW_Click);
            // 
            // btnCH
            // 
            this.btnCH.Location = new System.Drawing.Point(97, 353);
            this.btnCH.Name = "btnCH";
            this.btnCH.Size = new System.Drawing.Size(97, 23);
            this.btnCH.TabIndex = 7;
            this.btnCH.Text = "Convert Height";
            this.btnCH.UseVisualStyleBackColor = true;
            this.btnCH.Click += new System.EventHandler(this.btnCH_Click);
            // 
            // frmFitness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 514);
            this.Controls.Add(this.gbFC);
            this.Controls.Add(this.gbBMI);
            this.Controls.Add(this.gbVD);
            this.Name = "frmFitness";
            this.Text = "INF Fitness";
            this.gbVD.ResumeLayout(false);
            this.gbVD.PerformLayout();
            this.gbBMI.ResumeLayout(false);
            this.gbBMI.PerformLayout();
            this.gbFC.ResumeLayout(false);
            this.gbFC.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbVD;
        private System.Windows.Forms.GroupBox gbBMI;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnCD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnBMI;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblHeightIn;
        private System.Windows.Forms.Label lblWeightIn;
        private System.Windows.Forms.TextBox txtInches;
        private System.Windows.Forms.TextBox txtPounds;
        private System.Windows.Forms.GroupBox gbFC;
        private System.Windows.Forms.Button btnCH;
        private System.Windows.Forms.Button btnCW;
        private System.Windows.Forms.Label lblCMin;
        private System.Windows.Forms.Label lblHeightOut;
        private System.Windows.Forms.Label lblWeightOut;
        private System.Windows.Forms.Label lblKGin;
        private System.Windows.Forms.TextBox txtCM;
        private System.Windows.Forms.TextBox txtKG;
    }
}

