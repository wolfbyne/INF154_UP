namespace u20447613_INF154_A6
{
    partial class frmClassSignUp
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
            this.lbStudents = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblNameAdd = new System.Windows.Forms.Label();
            this.lblSurnameAdd = new System.Windows.Forms.Label();
            this.lblNameRemove = new System.Windows.Forms.Label();
            this.lblSurnameRemove = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClearList = new System.Windows.Forms.Button();
            this.txtNameAdd = new System.Windows.Forms.TextBox();
            this.txtSurnameAdd = new System.Windows.Forms.TextBox();
            this.txtNameRemove = new System.Windows.Forms.TextBox();
            this.txtSurnameRemove = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbStudents
            // 
            this.lbStudents.FormattingEnabled = true;
            this.lbStudents.Location = new System.Drawing.Point(344, 12);
            this.lbStudents.Name = "lbStudents";
            this.lbStudents.Size = new System.Drawing.Size(286, 407);
            this.lbStudents.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSurnameAdd);
            this.groupBox1.Controls.Add(this.txtNameAdd);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.lblSurnameAdd);
            this.groupBox1.Controls.Add(this.lblNameAdd);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 203);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Student";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSurnameRemove);
            this.groupBox2.Controls.Add(this.txtNameRemove);
            this.groupBox2.Controls.Add(this.btnRemove);
            this.groupBox2.Controls.Add(this.lblSurnameRemove);
            this.groupBox2.Controls.Add(this.lblNameRemove);
            this.groupBox2.Location = new System.Drawing.Point(12, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 198);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remove Student";
            // 
            // lblNameAdd
            // 
            this.lblNameAdd.AutoSize = true;
            this.lblNameAdd.Location = new System.Drawing.Point(48, 61);
            this.lblNameAdd.Name = "lblNameAdd";
            this.lblNameAdd.Size = new System.Drawing.Size(38, 13);
            this.lblNameAdd.TabIndex = 0;
            this.lblNameAdd.Text = "Name:";
            // 
            // lblSurnameAdd
            // 
            this.lblSurnameAdd.AutoSize = true;
            this.lblSurnameAdd.Location = new System.Drawing.Point(49, 110);
            this.lblSurnameAdd.Name = "lblSurnameAdd";
            this.lblSurnameAdd.Size = new System.Drawing.Size(52, 13);
            this.lblSurnameAdd.TabIndex = 1;
            this.lblSurnameAdd.Text = "Surname:";
            // 
            // lblNameRemove
            // 
            this.lblNameRemove.AutoSize = true;
            this.lblNameRemove.Location = new System.Drawing.Point(48, 58);
            this.lblNameRemove.Name = "lblNameRemove";
            this.lblNameRemove.Size = new System.Drawing.Size(38, 13);
            this.lblNameRemove.TabIndex = 0;
            this.lblNameRemove.Text = "Name:";
            // 
            // lblSurnameRemove
            // 
            this.lblSurnameRemove.AutoSize = true;
            this.lblSurnameRemove.Location = new System.Drawing.Point(49, 105);
            this.lblSurnameRemove.Name = "lblSurnameRemove";
            this.lblSurnameRemove.Size = new System.Drawing.Size(52, 13);
            this.lblSurnameRemove.TabIndex = 1;
            this.lblSurnameRemove.Text = "Surname:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(149, 165);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(149, 158);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClearList
            // 
            this.btnClearList.Location = new System.Drawing.Point(467, 469);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(75, 23);
            this.btnClearList.TabIndex = 3;
            this.btnClearList.Text = "Clear List";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // txtNameAdd
            // 
            this.txtNameAdd.Location = new System.Drawing.Point(149, 61);
            this.txtNameAdd.Name = "txtNameAdd";
            this.txtNameAdd.Size = new System.Drawing.Size(100, 20);
            this.txtNameAdd.TabIndex = 3;
            // 
            // txtSurnameAdd
            // 
            this.txtSurnameAdd.Location = new System.Drawing.Point(149, 110);
            this.txtSurnameAdd.Name = "txtSurnameAdd";
            this.txtSurnameAdd.Size = new System.Drawing.Size(100, 20);
            this.txtSurnameAdd.TabIndex = 4;
            // 
            // txtNameRemove
            // 
            this.txtNameRemove.Location = new System.Drawing.Point(149, 58);
            this.txtNameRemove.Name = "txtNameRemove";
            this.txtNameRemove.Size = new System.Drawing.Size(100, 20);
            this.txtNameRemove.TabIndex = 3;
            // 
            // txtSurnameRemove
            // 
            this.txtSurnameRemove.Location = new System.Drawing.Point(149, 105);
            this.txtSurnameRemove.Name = "txtSurnameRemove";
            this.txtSurnameRemove.Size = new System.Drawing.Size(100, 20);
            this.txtSurnameRemove.TabIndex = 4;
            // 
            // frmClassSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 518);
            this.Controls.Add(this.btnClearList);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbStudents);
            this.Name = "frmClassSignUp";
            this.Text = "Class Sign Up";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbStudents;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSurnameAdd;
        private System.Windows.Forms.TextBox txtNameAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblSurnameAdd;
        private System.Windows.Forms.Label lblNameAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSurnameRemove;
        private System.Windows.Forms.TextBox txtNameRemove;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblSurnameRemove;
        private System.Windows.Forms.Label lblNameRemove;
        private System.Windows.Forms.Button btnClearList;
    }
}

