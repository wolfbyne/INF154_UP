namespace u20447613_INF154_A8
{
    partial class frmManage
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
            this.gbAdd = new System.Windows.Forms.GroupBox();
            this.gbRemove = new System.Windows.Forms.GroupBox();
            this.txtFirstNameAdd = new System.Windows.Forms.TextBox();
            this.txtSurnameAdd = new System.Windows.Forms.TextBox();
            this.lblFirstNameAdd = new System.Windows.Forms.Label();
            this.lblSurnameAdd = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtFirstNameRemove = new System.Windows.Forms.TextBox();
            this.txtSurnameRemove = new System.Windows.Forms.TextBox();
            this.lblFirstNameRemove = new System.Windows.Forms.Label();
            this.lblSurnameRemove = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lbEmployees = new System.Windows.Forms.ListBox();
            this.btnView = new System.Windows.Forms.Button();
            this.lblIndex = new System.Windows.Forms.Label();
            this.nudIndex = new System.Windows.Forms.NumericUpDown();
            this.gbAdd.SuspendLayout();
            this.gbRemove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAdd
            // 
            this.gbAdd.Controls.Add(this.btnAdd);
            this.gbAdd.Controls.Add(this.lblSurnameAdd);
            this.gbAdd.Controls.Add(this.lblFirstNameAdd);
            this.gbAdd.Controls.Add(this.txtSurnameAdd);
            this.gbAdd.Controls.Add(this.txtFirstNameAdd);
            this.gbAdd.Location = new System.Drawing.Point(12, 12);
            this.gbAdd.Name = "gbAdd";
            this.gbAdd.Size = new System.Drawing.Size(393, 246);
            this.gbAdd.TabIndex = 0;
            this.gbAdd.TabStop = false;
            this.gbAdd.Text = "Add Employee";
            // 
            // gbRemove
            // 
            this.gbRemove.Controls.Add(this.nudIndex);
            this.gbRemove.Controls.Add(this.lblIndex);
            this.gbRemove.Controls.Add(this.btnRemove);
            this.gbRemove.Controls.Add(this.lblSurnameRemove);
            this.gbRemove.Controls.Add(this.lblFirstNameRemove);
            this.gbRemove.Controls.Add(this.txtSurnameRemove);
            this.gbRemove.Controls.Add(this.txtFirstNameRemove);
            this.gbRemove.Location = new System.Drawing.Point(411, 12);
            this.gbRemove.Name = "gbRemove";
            this.gbRemove.Size = new System.Drawing.Size(416, 246);
            this.gbRemove.TabIndex = 1;
            this.gbRemove.TabStop = false;
            this.gbRemove.Text = "Remove Employee";
            this.gbRemove.Visible = false;
            // 
            // txtFirstNameAdd
            // 
            this.txtFirstNameAdd.Location = new System.Drawing.Point(170, 90);
            this.txtFirstNameAdd.Name = "txtFirstNameAdd";
            this.txtFirstNameAdd.Size = new System.Drawing.Size(139, 20);
            this.txtFirstNameAdd.TabIndex = 0;
            // 
            // txtSurnameAdd
            // 
            this.txtSurnameAdd.Location = new System.Drawing.Point(170, 131);
            this.txtSurnameAdd.Name = "txtSurnameAdd";
            this.txtSurnameAdd.Size = new System.Drawing.Size(139, 20);
            this.txtSurnameAdd.TabIndex = 1;
            // 
            // lblFirstNameAdd
            // 
            this.lblFirstNameAdd.AutoSize = true;
            this.lblFirstNameAdd.Location = new System.Drawing.Point(46, 90);
            this.lblFirstNameAdd.Name = "lblFirstNameAdd";
            this.lblFirstNameAdd.Size = new System.Drawing.Size(60, 13);
            this.lblFirstNameAdd.TabIndex = 2;
            this.lblFirstNameAdd.Text = "First Name:";
            // 
            // lblSurnameAdd
            // 
            this.lblSurnameAdd.AutoSize = true;
            this.lblSurnameAdd.Location = new System.Drawing.Point(46, 131);
            this.lblSurnameAdd.Name = "lblSurnameAdd";
            this.lblSurnameAdd.Size = new System.Drawing.Size(52, 13);
            this.lblSurnameAdd.TabIndex = 3;
            this.lblSurnameAdd.Text = "Surname:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(135, 204);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add Employee";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtFirstNameRemove
            // 
            this.txtFirstNameRemove.Location = new System.Drawing.Point(205, 90);
            this.txtFirstNameRemove.Name = "txtFirstNameRemove";
            this.txtFirstNameRemove.Size = new System.Drawing.Size(139, 20);
            this.txtFirstNameRemove.TabIndex = 5;
            // 
            // txtSurnameRemove
            // 
            this.txtSurnameRemove.Location = new System.Drawing.Point(205, 131);
            this.txtSurnameRemove.Name = "txtSurnameRemove";
            this.txtSurnameRemove.Size = new System.Drawing.Size(139, 20);
            this.txtSurnameRemove.TabIndex = 5;
            // 
            // lblFirstNameRemove
            // 
            this.lblFirstNameRemove.AutoSize = true;
            this.lblFirstNameRemove.Location = new System.Drawing.Point(46, 90);
            this.lblFirstNameRemove.Name = "lblFirstNameRemove";
            this.lblFirstNameRemove.Size = new System.Drawing.Size(60, 13);
            this.lblFirstNameRemove.TabIndex = 6;
            this.lblFirstNameRemove.Text = "First Name:";
            // 
            // lblSurnameRemove
            // 
            this.lblSurnameRemove.AutoSize = true;
            this.lblSurnameRemove.Location = new System.Drawing.Point(46, 134);
            this.lblSurnameRemove.Name = "lblSurnameRemove";
            this.lblSurnameRemove.Size = new System.Drawing.Size(52, 13);
            this.lblSurnameRemove.TabIndex = 7;
            this.lblSurnameRemove.Text = "Surname:";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(176, 204);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(116, 23);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "Remove Employee";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lbEmployees
            // 
            this.lbEmployees.FormattingEnabled = true;
            this.lbEmployees.Location = new System.Drawing.Point(207, 290);
            this.lbEmployees.Name = "lbEmployees";
            this.lbEmployees.Size = new System.Drawing.Size(438, 147);
            this.lbEmployees.TabIndex = 2;
            this.lbEmployees.Visible = false;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(354, 261);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(108, 23);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Location = new System.Drawing.Point(46, 172);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(74, 13);
            this.lblIndex.TabIndex = 9;
            this.lblIndex.Text = "Index in Array:";
            // 
            // nudIndex
            // 
            this.nudIndex.Location = new System.Drawing.Point(205, 172);
            this.nudIndex.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudIndex.Name = "nudIndex";
            this.nudIndex.Size = new System.Drawing.Size(45, 20);
            this.nudIndex.TabIndex = 10;
            // 
            // frmManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 448);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.lbEmployees);
            this.Controls.Add(this.gbRemove);
            this.Controls.Add(this.gbAdd);
            this.Name = "frmManage";
            this.Text = "Manage your Staff here";
            this.gbAdd.ResumeLayout(false);
            this.gbAdd.PerformLayout();
            this.gbRemove.ResumeLayout(false);
            this.gbRemove.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIndex)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAdd;
        private System.Windows.Forms.GroupBox gbRemove;
        private System.Windows.Forms.Label lblSurnameAdd;
        private System.Windows.Forms.Label lblFirstNameAdd;
        private System.Windows.Forms.TextBox txtSurnameAdd;
        private System.Windows.Forms.TextBox txtFirstNameAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblSurnameRemove;
        private System.Windows.Forms.Label lblFirstNameRemove;
        private System.Windows.Forms.TextBox txtSurnameRemove;
        private System.Windows.Forms.TextBox txtFirstNameRemove;
        private System.Windows.Forms.ListBox lbEmployees;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.NumericUpDown nudIndex;
        private System.Windows.Forms.Label lblIndex;
    }
}

