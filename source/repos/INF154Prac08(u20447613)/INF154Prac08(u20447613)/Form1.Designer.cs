namespace INF154Prac08_u20447613_
{
    partial class frm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm1));
            this.tb1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblInput1 = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.txtInputNum = new System.Windows.Forms.TextBox();
            this.btnAddNum = new System.Windows.Forms.Button();
            this.btnFindMaxMin = new System.Windows.Forms.Button();
            this.lblEvenOdd = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.ListBox();
            this.lb2 = new System.Windows.Forms.ListBox();
            this.btnAnalyse = new System.Windows.Forms.Button();
            this.btnFeeling = new System.Windows.Forms.Button();
            this.imlFeelings = new System.Windows.Forms.ImageList(this.components);
            this.pbFeeling = new System.Windows.Forms.PictureBox();
            this.tb1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFeeling)).BeginInit();
            this.SuspendLayout();
            // 
            // tb1
            // 
            this.tb1.Controls.Add(this.tabPage1);
            this.tb1.Controls.Add(this.tabPage2);
            this.tb1.Controls.Add(this.tabPage3);
            this.tb1.Location = new System.Drawing.Point(0, 0);
            this.tb1.Name = "tb1";
            this.tb1.SelectedIndex = 0;
            this.tb1.Size = new System.Drawing.Size(700, 497);
            this.tb1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnFindMaxMin);
            this.tabPage1.Controls.Add(this.btnAddNum);
            this.tabPage1.Controls.Add(this.txtInputNum);
            this.tabPage1.Controls.Add(this.lblMin);
            this.tabPage1.Controls.Add(this.lblMax);
            this.tabPage1.Controls.Add(this.lblInput1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(692, 471);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Part 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAnalyse);
            this.tabPage2.Controls.Add(this.lb2);
            this.tabPage2.Controls.Add(this.lb1);
            this.tabPage2.Controls.Add(this.lblEvenOdd);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(692, 471);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Part 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pbFeeling);
            this.tabPage3.Controls.Add(this.btnFeeling);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(692, 471);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Part 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblInput1
            // 
            this.lblInput1.AutoSize = true;
            this.lblInput1.Location = new System.Drawing.Point(137, 112);
            this.lblInput1.Name = "lblInput1";
            this.lblInput1.Size = new System.Drawing.Size(159, 13);
            this.lblInput1.TabIndex = 0;
            this.lblInput1.Text = "Input 4 numbers of Your Choice:";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(224, 269);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(94, 13);
            this.lblMax.TabIndex = 1;
            this.lblMax.Text = "Maximum Number:";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(224, 311);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(91, 13);
            this.lblMin.TabIndex = 2;
            this.lblMin.Text = "Minimum Number:";
            // 
            // txtInputNum
            // 
            this.txtInputNum.Location = new System.Drawing.Point(362, 112);
            this.txtInputNum.Name = "txtInputNum";
            this.txtInputNum.Size = new System.Drawing.Size(122, 20);
            this.txtInputNum.TabIndex = 3;
            // 
            // btnAddNum
            // 
            this.btnAddNum.Location = new System.Drawing.Point(279, 172);
            this.btnAddNum.Name = "btnAddNum";
            this.btnAddNum.Size = new System.Drawing.Size(93, 40);
            this.btnAddNum.TabIndex = 4;
            this.btnAddNum.Text = "Add Number";
            this.btnAddNum.UseVisualStyleBackColor = true;
            this.btnAddNum.Click += new System.EventHandler(this.btnAddNum_Click);
            // 
            // btnFindMaxMin
            // 
            this.btnFindMaxMin.Enabled = false;
            this.btnFindMaxMin.Location = new System.Drawing.Point(210, 228);
            this.btnFindMaxMin.Name = "btnFindMaxMin";
            this.btnFindMaxMin.Size = new System.Drawing.Size(236, 23);
            this.btnFindMaxMin.TabIndex = 5;
            this.btnFindMaxMin.Text = "Find Maximum and Minimum Numbers";
            this.btnFindMaxMin.UseVisualStyleBackColor = true;
            this.btnFindMaxMin.Click += new System.EventHandler(this.btnFindMaxMin_Click);
            // 
            // lblEvenOdd
            // 
            this.lblEvenOdd.AutoSize = true;
            this.lblEvenOdd.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvenOdd.Location = new System.Drawing.Point(62, 36);
            this.lblEvenOdd.Name = "lblEvenOdd";
            this.lblEvenOdd.Size = new System.Drawing.Size(194, 21);
            this.lblEvenOdd.TabIndex = 0;
            this.lblEvenOdd.Text = "Even And Odd Numbers";
            // 
            // lb1
            // 
            this.lb1.FormattingEnabled = true;
            this.lb1.Items.AddRange(new object[] {
            "6",
            "10",
            "103",
            "105",
            "2",
            "1"});
            this.lb1.Location = new System.Drawing.Point(136, 107);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(120, 186);
            this.lb1.TabIndex = 1;
            // 
            // lb2
            // 
            this.lb2.FormattingEnabled = true;
            this.lb2.Location = new System.Drawing.Point(415, 107);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(120, 186);
            this.lb2.TabIndex = 2;
            // 
            // btnAnalyse
            // 
            this.btnAnalyse.Location = new System.Drawing.Point(293, 331);
            this.btnAnalyse.Name = "btnAnalyse";
            this.btnAnalyse.Size = new System.Drawing.Size(75, 23);
            this.btnAnalyse.TabIndex = 3;
            this.btnAnalyse.Text = "Analyse";
            this.btnAnalyse.UseVisualStyleBackColor = true;
            this.btnAnalyse.Click += new System.EventHandler(this.btnAnalyse_Click);
            // 
            // btnFeeling
            // 
            this.btnFeeling.Location = new System.Drawing.Point(207, 48);
            this.btnFeeling.Name = "btnFeeling";
            this.btnFeeling.Size = new System.Drawing.Size(264, 61);
            this.btnFeeling.TabIndex = 0;
            this.btnFeeling.Text = "How Are You Feeling Today?";
            this.btnFeeling.UseVisualStyleBackColor = true;
            this.btnFeeling.Click += new System.EventHandler(this.btnFeeling_Click);
            // 
            // imlFeelings
            // 
            this.imlFeelings.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlFeelings.ImageStream")));
            this.imlFeelings.TransparentColor = System.Drawing.Color.Transparent;
            this.imlFeelings.Images.SetKeyName(0, "annoyed.jpg");
            this.imlFeelings.Images.SetKeyName(1, "confused.jpg");
            this.imlFeelings.Images.SetKeyName(2, "Sleepy.png");
            this.imlFeelings.Images.SetKeyName(3, "Tongue out.jpg");
            // 
            // pbFeeling
            // 
            this.pbFeeling.Location = new System.Drawing.Point(207, 153);
            this.pbFeeling.Name = "pbFeeling";
            this.pbFeeling.Size = new System.Drawing.Size(264, 246);
            this.pbFeeling.TabIndex = 1;
            this.pbFeeling.TabStop = false;
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 495);
            this.Controls.Add(this.tb1);
            this.Name = "frm1";
            this.Text = "Arrays";
            this.tb1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFeeling)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tb1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnAddNum;
        private System.Windows.Forms.TextBox txtInputNum;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblInput1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnFindMaxMin;
        private System.Windows.Forms.Button btnAnalyse;
        private System.Windows.Forms.ListBox lb2;
        private System.Windows.Forms.ListBox lb1;
        private System.Windows.Forms.Label lblEvenOdd;
        private System.Windows.Forms.PictureBox pbFeeling;
        private System.Windows.Forms.Button btnFeeling;
        private System.Windows.Forms.ImageList imlFeelings;
    }
}

