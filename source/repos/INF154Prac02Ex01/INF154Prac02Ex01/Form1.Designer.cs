namespace INF154Prac02Ex01
{
    partial class frmArt
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
            this.btnSmaller = new System.Windows.Forms.Button();
            this.btnBigger = new System.Windows.Forms.Button();
            this.lblArea = new System.Windows.Forms.Label();
            this.gboxMyPalette = new System.Windows.Forms.GroupBox();
            this.nudRed = new System.Windows.Forms.NumericUpDown();
            this.nudBlue = new System.Windows.Forms.NumericUpDown();
            this.nudGreen = new System.Windows.Forms.NumericUpDown();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGreen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSmaller
            // 
            this.btnSmaller.Location = new System.Drawing.Point(12, 12);
            this.btnSmaller.Name = "btnSmaller";
            this.btnSmaller.Size = new System.Drawing.Size(100, 50);
            this.btnSmaller.TabIndex = 0;
            this.btnSmaller.Text = "Smaller";
            this.btnSmaller.UseVisualStyleBackColor = true;
            this.btnSmaller.Click += new System.EventHandler(this.btnSmaller_Click);
            // 
            // btnBigger
            // 
            this.btnBigger.Location = new System.Drawing.Point(290, 12);
            this.btnBigger.Name = "btnBigger";
            this.btnBigger.Size = new System.Drawing.Size(101, 50);
            this.btnBigger.TabIndex = 1;
            this.btnBigger.Text = "Bigger";
            this.btnBigger.UseVisualStyleBackColor = true;
            this.btnBigger.Click += new System.EventHandler(this.btnBigger_Click);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(136, 12);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(130, 24);
            this.lblArea.TabIndex = 2;
            this.lblArea.Text = "Area in Pixels:";
            // 
            // gboxMyPalette
            // 
            this.gboxMyPalette.Location = new System.Drawing.Point(12, 85);
            this.gboxMyPalette.Name = "gboxMyPalette";
            this.gboxMyPalette.Size = new System.Drawing.Size(379, 364);
            this.gboxMyPalette.TabIndex = 3;
            this.gboxMyPalette.TabStop = false;
            this.gboxMyPalette.Text = "My Palette";
            // 
            // nudRed
            // 
            this.nudRed.Location = new System.Drawing.Point(271, 484);
            this.nudRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRed.Name = "nudRed";
            this.nudRed.Size = new System.Drawing.Size(120, 20);
            this.nudRed.TabIndex = 4;
            // 
            // nudBlue
            // 
            this.nudBlue.Location = new System.Drawing.Point(271, 525);
            this.nudBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudBlue.Name = "nudBlue";
            this.nudBlue.Size = new System.Drawing.Size(120, 20);
            this.nudBlue.TabIndex = 5;
            // 
            // nudGreen
            // 
            this.nudGreen.Location = new System.Drawing.Point(271, 566);
            this.nudGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudGreen.Name = "nudGreen";
            this.nudGreen.Size = new System.Drawing.Size(120, 20);
            this.nudGreen.TabIndex = 6;
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Location = new System.Drawing.Point(39, 491);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(27, 13);
            this.lblRed.TabIndex = 7;
            this.lblRed.Text = "Red";
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Location = new System.Drawing.Point(39, 532);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(28, 13);
            this.lblBlue.TabIndex = 8;
            this.lblBlue.Text = "Blue";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Location = new System.Drawing.Point(39, 573);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(36, 13);
            this.lblGreen.TabIndex = 9;
            this.lblGreen.Text = "Green";
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.Location = new System.Drawing.Point(85, 597);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(224, 40);
            this.btnChange.TabIndex = 10;
            this.btnChange.Text = "Change Colour";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // frmArt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 649);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.nudGreen);
            this.Controls.Add(this.nudBlue);
            this.Controls.Add(this.nudRed);
            this.Controls.Add(this.gboxMyPalette);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.btnBigger);
            this.Controls.Add(this.btnSmaller);
            this.Name = "frmArt";
            this.Text = "Art";
            ((System.ComponentModel.ISupportInitialize)(this.nudRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSmaller;
        private System.Windows.Forms.Button btnBigger;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.GroupBox gboxMyPalette;
        private System.Windows.Forms.NumericUpDown nudRed;
        private System.Windows.Forms.NumericUpDown nudBlue;
        private System.Windows.Forms.NumericUpDown nudGreen;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Button btnChange;
    }
}

