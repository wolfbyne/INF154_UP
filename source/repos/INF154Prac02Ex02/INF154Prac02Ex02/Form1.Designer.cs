namespace INF154Prac02Ex02
{
    partial class frmMyMarks
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
            this.lboxReport = new System.Windows.Forms.ListBox();
            this.gboxModule = new System.Windows.Forms.GroupBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblModule = new System.Windows.Forms.Label();
            this.txtModule = new System.Windows.Forms.TextBox();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.txtDistinction = new System.Windows.Forms.TextBox();
            this.cboxType = new System.Windows.Forms.ComboBox();
            this.lblSemMark = new System.Windows.Forms.Label();
            this.lblExamMark = new System.Windows.Forms.Label();
            this.lblSemWeight = new System.Windows.Forms.Label();
            this.lblExamWeight = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblDistinction = new System.Windows.Forms.Label();
            this.btnResetAll = new System.Windows.Forms.Button();
            this.btnAnalyse = new System.Windows.Forms.Button();
            this.txtSemWeight = new System.Windows.Forms.TextBox();
            this.txtExamWeight = new System.Windows.Forms.TextBox();
            this.nudSemMark = new System.Windows.Forms.NumericUpDown();
            this.nudExamMark = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gboxModule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSemMark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExamMark)).BeginInit();
            this.SuspendLayout();
            // 
            // lboxReport
            // 
            this.lboxReport.FormattingEnabled = true;
            this.lboxReport.Location = new System.Drawing.Point(12, 300);
            this.lboxReport.Name = "lboxReport";
            this.lboxReport.Size = new System.Drawing.Size(431, 212);
            this.lboxReport.TabIndex = 0;
            // 
            // gboxModule
            // 
            this.gboxModule.Controls.Add(this.btnAdd);
            this.gboxModule.Controls.Add(this.nudExamMark);
            this.gboxModule.Controls.Add(this.nudSemMark);
            this.gboxModule.Controls.Add(this.txtExamWeight);
            this.gboxModule.Controls.Add(this.txtSemWeight);
            this.gboxModule.Controls.Add(this.lblExamWeight);
            this.gboxModule.Controls.Add(this.lblSemWeight);
            this.gboxModule.Controls.Add(this.lblExamMark);
            this.gboxModule.Controls.Add(this.lblSemMark);
            this.gboxModule.Controls.Add(this.cboxType);
            this.gboxModule.Controls.Add(this.txtModule);
            this.gboxModule.Controls.Add(this.lblType);
            this.gboxModule.Controls.Add(this.lblModule);
            this.gboxModule.Location = new System.Drawing.Point(12, 12);
            this.gboxModule.Name = "gboxModule";
            this.gboxModule.Size = new System.Drawing.Size(532, 266);
            this.gboxModule.TabIndex = 1;
            this.gboxModule.TabStop = false;
            this.gboxModule.Text = "Module";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(321, 33);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(34, 13);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "Type:";
            // 
            // lblModule
            // 
            this.lblModule.AutoSize = true;
            this.lblModule.Location = new System.Drawing.Point(25, 33);
            this.lblModule.Name = "lblModule";
            this.lblModule.Size = new System.Drawing.Size(45, 13);
            this.lblModule.TabIndex = 0;
            this.lblModule.Text = "Module:";
            // 
            // txtModule
            // 
            this.txtModule.Location = new System.Drawing.Point(76, 30);
            this.txtModule.Name = "txtModule";
            this.txtModule.Size = new System.Drawing.Size(100, 20);
            this.txtModule.TabIndex = 2;
            // 
            // txtAverage
            // 
            this.txtAverage.Enabled = false;
            this.txtAverage.Location = new System.Drawing.Point(449, 365);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.Size = new System.Drawing.Size(100, 20);
            this.txtAverage.TabIndex = 2;
            // 
            // txtDistinction
            // 
            this.txtDistinction.Location = new System.Drawing.Point(449, 492);
            this.txtDistinction.Name = "txtDistinction";
            this.txtDistinction.Size = new System.Drawing.Size(100, 20);
            this.txtDistinction.TabIndex = 3;
            // 
            // cboxType
            // 
            this.cboxType.FormattingEnabled = true;
            this.cboxType.Items.AddRange(new object[] {
            "Core",
            "Fundamental",
            "Elective",
            "Non-Degree Purposes"});
            this.cboxType.Location = new System.Drawing.Point(361, 30);
            this.cboxType.Name = "cboxType";
            this.cboxType.Size = new System.Drawing.Size(151, 21);
            this.cboxType.TabIndex = 3;
            // 
            // lblSemMark
            // 
            this.lblSemMark.AutoSize = true;
            this.lblSemMark.Location = new System.Drawing.Point(115, 102);
            this.lblSemMark.Name = "lblSemMark";
            this.lblSemMark.Size = new System.Drawing.Size(81, 13);
            this.lblSemMark.TabIndex = 4;
            this.lblSemMark.Text = "Semester Mark:";
            // 
            // lblExamMark
            // 
            this.lblExamMark.AutoSize = true;
            this.lblExamMark.Location = new System.Drawing.Point(115, 162);
            this.lblExamMark.Name = "lblExamMark";
            this.lblExamMark.Size = new System.Drawing.Size(63, 13);
            this.lblExamMark.TabIndex = 5;
            this.lblExamMark.Text = "Exam Mark:";
            // 
            // lblSemWeight
            // 
            this.lblSemWeight.AutoSize = true;
            this.lblSemWeight.Location = new System.Drawing.Point(361, 102);
            this.lblSemWeight.Name = "lblSemWeight";
            this.lblSemWeight.Size = new System.Drawing.Size(91, 13);
            this.lblSemWeight.TabIndex = 6;
            this.lblSemWeight.Text = "Semester Weight:";
            // 
            // lblExamWeight
            // 
            this.lblExamWeight.AutoSize = true;
            this.lblExamWeight.Location = new System.Drawing.Point(361, 162);
            this.lblExamWeight.Name = "lblExamWeight";
            this.lblExamWeight.Size = new System.Drawing.Size(70, 13);
            this.lblExamWeight.TabIndex = 7;
            this.lblExamWeight.Text = "Exam Weight";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(449, 337);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(50, 13);
            this.lblAverage.TabIndex = 4;
            this.lblAverage.Text = "Average:";
            // 
            // lblDistinction
            // 
            this.lblDistinction.Location = new System.Drawing.Point(449, 430);
            this.lblDistinction.Name = "lblDistinction";
            this.lblDistinction.Size = new System.Drawing.Size(100, 59);
            this.lblDistinction.TabIndex = 5;
            this.lblDistinction.Text = "For distinction average the next mark should be above:";
            // 
            // btnResetAll
            // 
            this.btnResetAll.Location = new System.Drawing.Point(461, 535);
            this.btnResetAll.Name = "btnResetAll";
            this.btnResetAll.Size = new System.Drawing.Size(75, 23);
            this.btnResetAll.TabIndex = 6;
            this.btnResetAll.Text = "Reset All";
            this.btnResetAll.UseVisualStyleBackColor = true;
            this.btnResetAll.Click += new System.EventHandler(this.btnResetAll_Click);
            // 
            // btnAnalyse
            // 
            this.btnAnalyse.Location = new System.Drawing.Point(461, 300);
            this.btnAnalyse.Name = "btnAnalyse";
            this.btnAnalyse.Size = new System.Drawing.Size(75, 23);
            this.btnAnalyse.TabIndex = 7;
            this.btnAnalyse.Text = "Analyse";
            this.btnAnalyse.UseVisualStyleBackColor = true;
            this.btnAnalyse.Click += new System.EventHandler(this.btnAnalyse_Click);
            // 
            // txtSemWeight
            // 
            this.txtSemWeight.Location = new System.Drawing.Point(364, 128);
            this.txtSemWeight.Name = "txtSemWeight";
            this.txtSemWeight.Size = new System.Drawing.Size(100, 20);
            this.txtSemWeight.TabIndex = 8;
            // 
            // txtExamWeight
            // 
            this.txtExamWeight.Location = new System.Drawing.Point(364, 188);
            this.txtExamWeight.Name = "txtExamWeight";
            this.txtExamWeight.Size = new System.Drawing.Size(100, 20);
            this.txtExamWeight.TabIndex = 9;
            // 
            // nudSemMark
            // 
            this.nudSemMark.Location = new System.Drawing.Point(118, 128);
            this.nudSemMark.Name = "nudSemMark";
            this.nudSemMark.Size = new System.Drawing.Size(120, 20);
            this.nudSemMark.TabIndex = 10;
            // 
            // nudExamMark
            // 
            this.nudExamMark.Location = new System.Drawing.Point(118, 189);
            this.nudExamMark.Name = "nudExamMark";
            this.nudExamMark.Size = new System.Drawing.Size(120, 20);
            this.nudExamMark.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(437, 237);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add Mark";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmMyMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 570);
            this.Controls.Add(this.btnAnalyse);
            this.Controls.Add(this.btnResetAll);
            this.Controls.Add(this.lblDistinction);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.txtDistinction);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.gboxModule);
            this.Controls.Add(this.lboxReport);
            this.Name = "frmMyMarks";
            this.Text = "My Marks";
            this.gboxModule.ResumeLayout(false);
            this.gboxModule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSemMark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExamMark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboxReport;
        private System.Windows.Forms.GroupBox gboxModule;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblModule;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown nudExamMark;
        private System.Windows.Forms.NumericUpDown nudSemMark;
        private System.Windows.Forms.TextBox txtExamWeight;
        private System.Windows.Forms.TextBox txtSemWeight;
        private System.Windows.Forms.Label lblExamWeight;
        private System.Windows.Forms.Label lblSemWeight;
        private System.Windows.Forms.Label lblExamMark;
        private System.Windows.Forms.Label lblSemMark;
        private System.Windows.Forms.ComboBox cboxType;
        private System.Windows.Forms.TextBox txtModule;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.TextBox txtDistinction;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblDistinction;
        private System.Windows.Forms.Button btnResetAll;
        private System.Windows.Forms.Button btnAnalyse;
    }
}

