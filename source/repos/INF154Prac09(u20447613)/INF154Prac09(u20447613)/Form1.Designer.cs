namespace INF154Prac09_u20447613_
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.resetTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveLoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveLoadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbNameCheck = new System.Windows.Forms.GroupBox();
            this.lblLetterCheck = new System.Windows.Forms.Label();
            this.btnTestName = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.gbReverse = new System.Windows.Forms.GroupBox();
            this.btnReverse = new System.Windows.Forms.Button();
            this.gbLetterReplace = new System.Windows.Forms.GroupBox();
            this.lblReplace = new System.Windows.Forms.Label();
            this.btnReplace = new System.Windows.Forms.Button();
            this.txtLetter = new System.Windows.Forms.TextBox();
            this.rtbInput = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.gbNameCheck.SuspendLayout();
            this.gbReverse.SuspendLayout();
            this.gbLetterReplace.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetTextToolStripMenuItem,
            this.saveLoadToolStripMenuItem,
            this.saveLoadToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(661, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "msOne";
            // 
            // resetTextToolStripMenuItem
            // 
            this.resetTextToolStripMenuItem.Name = "resetTextToolStripMenuItem";
            this.resetTextToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.resetTextToolStripMenuItem.Text = "Reset Text";
            this.resetTextToolStripMenuItem.Click += new System.EventHandler(this.resetTextToolStripMenuItem_Click);
            // 
            // saveLoadToolStripMenuItem
            // 
            this.saveLoadToolStripMenuItem.Name = "saveLoadToolStripMenuItem";
            this.saveLoadToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // saveLoadToolStripMenuItem1
            // 
            this.saveLoadToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem1,
            this.loadToolStripMenuItem1});
            this.saveLoadToolStripMenuItem1.Name = "saveLoadToolStripMenuItem1";
            this.saveLoadToolStripMenuItem1.Size = new System.Drawing.Size(74, 20);
            this.saveLoadToolStripMenuItem1.Text = "Save/Load";
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // loadToolStripMenuItem1
            // 
            this.loadToolStripMenuItem1.Enabled = false;
            this.loadToolStripMenuItem1.Name = "loadToolStripMenuItem1";
            this.loadToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem1.Text = "Load";
            this.loadToolStripMenuItem1.Click += new System.EventHandler(this.loadToolStripMenuItem1_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Enabled = false;
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // gbNameCheck
            // 
            this.gbNameCheck.Controls.Add(this.lblLetterCheck);
            this.gbNameCheck.Controls.Add(this.btnTestName);
            this.gbNameCheck.Controls.Add(this.txtName);
            this.gbNameCheck.Location = new System.Drawing.Point(333, 277);
            this.gbNameCheck.Name = "gbNameCheck";
            this.gbNameCheck.Size = new System.Drawing.Size(281, 134);
            this.gbNameCheck.TabIndex = 7;
            this.gbNameCheck.TabStop = false;
            this.gbNameCheck.Text = "Name Letter Checking";
            // 
            // lblLetterCheck
            // 
            this.lblLetterCheck.Location = new System.Drawing.Point(36, 29);
            this.lblLetterCheck.Name = "lblLetterCheck";
            this.lblLetterCheck.Size = new System.Drawing.Size(222, 31);
            this.lblLetterCheck.TabIndex = 3;
            this.lblLetterCheck.Text = "Enter your name and see how many times each letter appears in the rich textbox";
            // 
            // btnTestName
            // 
            this.btnTestName.Location = new System.Drawing.Point(90, 89);
            this.btnTestName.Name = "btnTestName";
            this.btnTestName.Size = new System.Drawing.Size(100, 23);
            this.btnTestName.TabIndex = 2;
            this.btnTestName.Text = "Test your name";
            this.btnTestName.UseVisualStyleBackColor = true;
            this.btnTestName.Click += new System.EventHandler(this.btnTestName_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(80, 63);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(124, 20);
            this.txtName.TabIndex = 1;
            // 
            // gbReverse
            // 
            this.gbReverse.Controls.Add(this.btnReverse);
            this.gbReverse.Location = new System.Drawing.Point(333, 179);
            this.gbReverse.Name = "gbReverse";
            this.gbReverse.Size = new System.Drawing.Size(281, 84);
            this.gbReverse.TabIndex = 6;
            this.gbReverse.TabStop = false;
            this.gbReverse.Text = "String Reversal";
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(90, 37);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(105, 23);
            this.btnReverse.TabIndex = 0;
            this.btnReverse.Text = "Reverse the Text!";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click_1);
            // 
            // gbLetterReplace
            // 
            this.gbLetterReplace.Controls.Add(this.lblReplace);
            this.gbLetterReplace.Controls.Add(this.btnReplace);
            this.gbLetterReplace.Controls.Add(this.txtLetter);
            this.gbLetterReplace.Location = new System.Drawing.Point(333, 39);
            this.gbLetterReplace.Name = "gbLetterReplace";
            this.gbLetterReplace.Size = new System.Drawing.Size(281, 134);
            this.gbLetterReplace.TabIndex = 5;
            this.gbLetterReplace.TabStop = false;
            this.gbLetterReplace.Text = "Letter Replacement";
            // 
            // lblReplace
            // 
            this.lblReplace.AutoSize = true;
            this.lblReplace.Location = new System.Drawing.Point(77, 36);
            this.lblReplace.Name = "lblReplace";
            this.lblReplace.Size = new System.Drawing.Size(156, 13);
            this.lblReplace.TabIndex = 2;
            this.lblReplace.Text = "Enter a letter to replace with \"*\"";
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(103, 88);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(75, 23);
            this.btnReplace.TabIndex = 1;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click_1);
            // 
            // txtLetter
            // 
            this.txtLetter.Location = new System.Drawing.Point(126, 62);
            this.txtLetter.Name = "txtLetter";
            this.txtLetter.Size = new System.Drawing.Size(32, 20);
            this.txtLetter.TabIndex = 0;
            // 
            // rtbInput
            // 
            this.rtbInput.Location = new System.Drawing.Point(46, 39);
            this.rtbInput.Name = "rtbInput";
            this.rtbInput.ReadOnly = true;
            this.rtbInput.Size = new System.Drawing.Size(226, 248);
            this.rtbInput.TabIndex = 4;
            this.rtbInput.Text = "Welcome to the practical 9 of INF 154 2020! Let\'s do string manipulation...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 450);
            this.Controls.Add(this.gbNameCheck);
            this.Controls.Add(this.gbReverse);
            this.Controls.Add(this.gbLetterReplace);
            this.Controls.Add(this.rtbInput);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbNameCheck.ResumeLayout(false);
            this.gbNameCheck.PerformLayout();
            this.gbReverse.ResumeLayout(false);
            this.gbLetterReplace.ResumeLayout(false);
            this.gbLetterReplace.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem resetTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveLoadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbNameCheck;
        private System.Windows.Forms.Label lblLetterCheck;
        private System.Windows.Forms.Button btnTestName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox gbReverse;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.GroupBox gbLetterReplace;
        private System.Windows.Forms.Label lblReplace;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.TextBox txtLetter;
        private System.Windows.Forms.RichTextBox rtbInput;
        private System.Windows.Forms.ToolStripMenuItem saveLoadToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem1;
    }
}

