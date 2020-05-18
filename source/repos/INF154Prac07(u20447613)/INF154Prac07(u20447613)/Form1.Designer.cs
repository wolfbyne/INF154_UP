namespace INF154Prac07_u20447613_
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tb1 = new System.Windows.Forms.TabPage();
            this.lblPieOutput = new System.Windows.Forms.Label();
            this.btnPies = new System.Windows.Forms.Button();
            this.nudPies = new System.Windows.Forms.NumericUpDown();
            this.lblPies = new System.Windows.Forms.Label();
            this.tb2 = new System.Windows.Forms.TabPage();
            this.lblBalanceOutput = new System.Windows.Forms.Label();
            this.btnViewBalance = new System.Windows.Forms.Button();
            this.lblBankBalance = new System.Windows.Forms.Label();
            this.tb3 = new System.Windows.Forms.TabPage();
            this.lblTimerOutput = new System.Windows.Forms.Label();
            this.btnActivate = new System.Windows.Forms.Button();
            this.lblBalanceTimer = new System.Windows.Forms.Label();
            this.tb4 = new System.Windows.Forms.TabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblRows = new System.Windows.Forms.Label();
            this.nudRows = new System.Windows.Forms.NumericUpDown();
            this.btnRows = new System.Windows.Forms.Button();
            this.lblRowsOutput = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPies)).BeginInit();
            this.tb2.SuspendLayout();
            this.tb3.SuspendLayout();
            this.tb4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRows)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tb1);
            this.tabControl1.Controls.Add(this.tb2);
            this.tabControl1.Controls.Add(this.tb3);
            this.tabControl1.Controls.Add(this.tb4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(811, 518);
            this.tabControl1.TabIndex = 0;
            // 
            // tb1
            // 
            this.tb1.Controls.Add(this.lblPieOutput);
            this.tb1.Controls.Add(this.btnPies);
            this.tb1.Controls.Add(this.nudPies);
            this.tb1.Controls.Add(this.lblPies);
            this.tb1.Location = new System.Drawing.Point(4, 22);
            this.tb1.Name = "tb1";
            this.tb1.Padding = new System.Windows.Forms.Padding(3);
            this.tb1.Size = new System.Drawing.Size(803, 492);
            this.tb1.TabIndex = 0;
            this.tb1.Text = "Part 1";
            this.tb1.UseVisualStyleBackColor = true;
            // 
            // lblPieOutput
            // 
            this.lblPieOutput.AutoSize = true;
            this.lblPieOutput.Location = new System.Drawing.Point(333, 224);
            this.lblPieOutput.Name = "lblPieOutput";
            this.lblPieOutput.Size = new System.Drawing.Size(66, 13);
            this.lblPieOutput.TabIndex = 11;
            this.lblPieOutput.Text = "Pies go here";
            // 
            // btnPies
            // 
            this.btnPies.Location = new System.Drawing.Point(238, 159);
            this.btnPies.Name = "btnPies";
            this.btnPies.Size = new System.Drawing.Size(231, 23);
            this.btnPies.TabIndex = 10;
            this.btnPies.Text = "Let there be Pies!";
            this.btnPies.UseVisualStyleBackColor = true;
            this.btnPies.Click += new System.EventHandler(this.btnPies_Click);
            // 
            // nudPies
            // 
            this.nudPies.Location = new System.Drawing.Point(421, 78);
            this.nudPies.Name = "nudPies";
            this.nudPies.Size = new System.Drawing.Size(48, 20);
            this.nudPies.TabIndex = 9;
            // 
            // lblPies
            // 
            this.lblPies.AutoSize = true;
            this.lblPies.Location = new System.Drawing.Point(235, 78);
            this.lblPies.Name = "lblPies";
            this.lblPies.Size = new System.Drawing.Size(146, 13);
            this.lblPies.TabIndex = 8;
            this.lblPies.Text = "How many pies do you want?";
            // 
            // tb2
            // 
            this.tb2.Controls.Add(this.lblBalanceOutput);
            this.tb2.Controls.Add(this.btnViewBalance);
            this.tb2.Controls.Add(this.lblBankBalance);
            this.tb2.Location = new System.Drawing.Point(4, 22);
            this.tb2.Name = "tb2";
            this.tb2.Padding = new System.Windows.Forms.Padding(3);
            this.tb2.Size = new System.Drawing.Size(803, 492);
            this.tb2.TabIndex = 1;
            this.tb2.Text = "Part 2";
            this.tb2.UseVisualStyleBackColor = true;
            // 
            // lblBalanceOutput
            // 
            this.lblBalanceOutput.AutoSize = true;
            this.lblBalanceOutput.Location = new System.Drawing.Point(329, 208);
            this.lblBalanceOutput.Name = "lblBalanceOutput";
            this.lblBalanceOutput.Size = new System.Drawing.Size(146, 13);
            this.lblBalanceOutput.TabIndex = 2;
            this.lblBalanceOutput.Text = "Your balance will display here";
            // 
            // btnViewBalance
            // 
            this.btnViewBalance.Location = new System.Drawing.Point(344, 147);
            this.btnViewBalance.Name = "btnViewBalance";
            this.btnViewBalance.Size = new System.Drawing.Size(113, 23);
            this.btnViewBalance.TabIndex = 1;
            this.btnViewBalance.Text = "View Balance";
            this.btnViewBalance.UseVisualStyleBackColor = true;
            this.btnViewBalance.Click += new System.EventHandler(this.btnViewBalance_Click);
            // 
            // lblBankBalance
            // 
            this.lblBankBalance.AutoSize = true;
            this.lblBankBalance.Location = new System.Drawing.Point(304, 96);
            this.lblBankBalance.Name = "lblBankBalance";
            this.lblBankBalance.Size = new System.Drawing.Size(195, 13);
            this.lblBankBalance.TabIndex = 0;
            this.lblBankBalance.Text = "Click to see your bank account balance";
            // 
            // tb3
            // 
            this.tb3.Controls.Add(this.lblTimerOutput);
            this.tb3.Controls.Add(this.btnActivate);
            this.tb3.Controls.Add(this.lblBalanceTimer);
            this.tb3.Location = new System.Drawing.Point(4, 22);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(803, 492);
            this.tb3.TabIndex = 2;
            this.tb3.Text = "Part 3";
            this.tb3.UseVisualStyleBackColor = true;
            // 
            // lblTimerOutput
            // 
            this.lblTimerOutput.AutoSize = true;
            this.lblTimerOutput.Location = new System.Drawing.Point(350, 211);
            this.lblTimerOutput.Name = "lblTimerOutput";
            this.lblTimerOutput.Size = new System.Drawing.Size(139, 13);
            this.lblTimerOutput.TabIndex = 2;
            this.lblTimerOutput.Text = "Your balance will show here";
            // 
            // btnActivate
            // 
            this.btnActivate.Location = new System.Drawing.Point(332, 147);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(177, 23);
            this.btnActivate.TabIndex = 1;
            this.btnActivate.Text = "Activate Balance Timer";
            this.btnActivate.UseVisualStyleBackColor = true;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // lblBalanceTimer
            // 
            this.lblBalanceTimer.AutoSize = true;
            this.lblBalanceTimer.Location = new System.Drawing.Point(291, 92);
            this.lblBalanceTimer.Name = "lblBalanceTimer";
            this.lblBalanceTimer.Size = new System.Drawing.Size(256, 13);
            this.lblBalanceTimer.TabIndex = 0;
            this.lblBalanceTimer.Text = "Click to see your bank balance update every second";
            // 
            // tb4
            // 
            this.tb4.Controls.Add(this.lblRowsOutput);
            this.tb4.Controls.Add(this.btnRows);
            this.tb4.Controls.Add(this.nudRows);
            this.tb4.Controls.Add(this.lblRows);
            this.tb4.Location = new System.Drawing.Point(4, 22);
            this.tb4.Name = "tb4";
            this.tb4.Size = new System.Drawing.Size(803, 492);
            this.tb4.TabIndex = 3;
            this.tb4.Text = "Part 4";
            this.tb4.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Location = new System.Drawing.Point(302, 85);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(149, 13);
            this.lblRows.TabIndex = 0;
            this.lblRows.Text = "How many rows do you want?";
            // 
            // nudRows
            // 
            this.nudRows.Location = new System.Drawing.Point(511, 85);
            this.nudRows.Name = "nudRows";
            this.nudRows.Size = new System.Drawing.Size(53, 20);
            this.nudRows.TabIndex = 1;
            // 
            // btnRows
            // 
            this.btnRows.Location = new System.Drawing.Point(353, 158);
            this.btnRows.Name = "btnRows";
            this.btnRows.Size = new System.Drawing.Size(131, 23);
            this.btnRows.TabIndex = 2;
            this.btnRows.Text = "Generate Rows";
            this.btnRows.UseVisualStyleBackColor = true;
            this.btnRows.Click += new System.EventHandler(this.btnRows_Click);
            // 
            // lblRowsOutput
            // 
            this.lblRowsOutput.AutoSize = true;
            this.lblRowsOutput.Location = new System.Drawing.Point(378, 209);
            this.lblRowsOutput.Name = "lblRowsOutput";
            this.lblRowsOutput.Size = new System.Drawing.Size(73, 13);
            this.lblRowsOutput.TabIndex = 3;
            this.lblRowsOutput.Text = "Rows go here";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 542);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tb1.ResumeLayout(false);
            this.tb1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPies)).EndInit();
            this.tb2.ResumeLayout(false);
            this.tb2.PerformLayout();
            this.tb3.ResumeLayout(false);
            this.tb3.PerformLayout();
            this.tb4.ResumeLayout(false);
            this.tb4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRows)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tb1;
        private System.Windows.Forms.TabPage tb2;
        private System.Windows.Forms.Label lblPieOutput;
        private System.Windows.Forms.Button btnPies;
        private System.Windows.Forms.NumericUpDown nudPies;
        private System.Windows.Forms.Label lblPies;
        private System.Windows.Forms.Label lblBalanceOutput;
        private System.Windows.Forms.Button btnViewBalance;
        private System.Windows.Forms.Label lblBankBalance;
        private System.Windows.Forms.TabPage tb3;
        private System.Windows.Forms.Label lblTimerOutput;
        private System.Windows.Forms.Button btnActivate;
        private System.Windows.Forms.Label lblBalanceTimer;
        private System.Windows.Forms.TabPage tb4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblRowsOutput;
        private System.Windows.Forms.Button btnRows;
        private System.Windows.Forms.NumericUpDown nudRows;
        private System.Windows.Forms.Label lblRows;
    }
}

