namespace INF154Prac05_u20447613_
{
    partial class frmCasinoRoyale
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
            this.gbPlayerRegist = new System.Windows.Forms.GroupBox();
            this.gbPlayerDetails = new System.Windows.Forms.GroupBox();
            this.gbGame = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblPlayerNumber = new System.Windows.Forms.Label();
            this.lblRollDice = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.pbPlayerPic = new System.Windows.Forms.PictureBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnSetPic = new System.Windows.Forms.Button();
            this.btnRoll = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.gbPlayerRegist.SuspendLayout();
            this.gbPlayerDetails.SuspendLayout();
            this.gbGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerPic)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPlayerRegist
            // 
            this.gbPlayerRegist.Controls.Add(this.btnRegister);
            this.gbPlayerRegist.Controls.Add(this.txtName);
            this.gbPlayerRegist.Controls.Add(this.lblName);
            this.gbPlayerRegist.Location = new System.Drawing.Point(12, 12);
            this.gbPlayerRegist.Name = "gbPlayerRegist";
            this.gbPlayerRegist.Size = new System.Drawing.Size(318, 240);
            this.gbPlayerRegist.TabIndex = 0;
            this.gbPlayerRegist.TabStop = false;
            this.gbPlayerRegist.Text = "Player Registration";
            // 
            // gbPlayerDetails
            // 
            this.gbPlayerDetails.Controls.Add(this.btnSetPic);
            this.gbPlayerDetails.Controls.Add(this.pbPlayerPic);
            this.gbPlayerDetails.Controls.Add(this.lblPlayerNumber);
            this.gbPlayerDetails.Controls.Add(this.lblPlayerName);
            this.gbPlayerDetails.Location = new System.Drawing.Point(340, 12);
            this.gbPlayerDetails.Name = "gbPlayerDetails";
            this.gbPlayerDetails.Size = new System.Drawing.Size(495, 240);
            this.gbPlayerDetails.TabIndex = 1;
            this.gbPlayerDetails.TabStop = false;
            this.gbPlayerDetails.Text = "Player Details";
            this.gbPlayerDetails.Visible = false;
            // 
            // gbGame
            // 
            this.gbGame.Controls.Add(this.lblTotal);
            this.gbGame.Controls.Add(this.btnRoll);
            this.gbGame.Controls.Add(this.lblRollDice);
            this.gbGame.Location = new System.Drawing.Point(291, 258);
            this.gbGame.Name = "gbGame";
            this.gbGame.Size = new System.Drawing.Size(217, 227);
            this.gbGame.TabIndex = 2;
            this.gbGame.TabStop = false;
            this.gbGame.Text = "Game";
            this.gbGame.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(39, 63);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(68, 49);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(70, 13);
            this.lblPlayerName.TabIndex = 0;
            this.lblPlayerName.Text = "Player Name:";
            // 
            // lblPlayerNumber
            // 
            this.lblPlayerNumber.AutoSize = true;
            this.lblPlayerNumber.Location = new System.Drawing.Point(71, 105);
            this.lblPlayerNumber.Name = "lblPlayerNumber";
            this.lblPlayerNumber.Size = new System.Drawing.Size(79, 13);
            this.lblPlayerNumber.TabIndex = 1;
            this.lblPlayerNumber.Text = "Player Number:";
            // 
            // lblRollDice
            // 
            this.lblRollDice.AutoSize = true;
            this.lblRollDice.Location = new System.Drawing.Point(46, 104);
            this.lblRollDice.Name = "lblRollDice";
            this.lblRollDice.Size = new System.Drawing.Size(114, 13);
            this.lblRollDice.TabIndex = 0;
            this.lblRollDice.Text = "Click To Roll The Dice";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(111, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(165, 20);
            this.txtName.TabIndex = 1;
            // 
            // pbPlayerPic
            // 
            this.pbPlayerPic.Location = new System.Drawing.Point(279, 30);
            this.pbPlayerPic.Name = "pbPlayerPic";
            this.pbPlayerPic.Size = new System.Drawing.Size(164, 119);
            this.pbPlayerPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayerPic.TabIndex = 2;
            this.pbPlayerPic.TabStop = false;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(121, 155);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnSetPic
            // 
            this.btnSetPic.Location = new System.Drawing.Point(298, 179);
            this.btnSetPic.Name = "btnSetPic";
            this.btnSetPic.Size = new System.Drawing.Size(74, 55);
            this.btnSetPic.TabIndex = 3;
            this.btnSetPic.Text = "Set Player Picture";
            this.btnSetPic.UseVisualStyleBackColor = true;
            this.btnSetPic.Click += new System.EventHandler(this.btnSetPic_Click);
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(66, 47);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(75, 23);
            this.btnRoll.TabIndex = 1;
            this.btnRoll.Text = "Roll Dice";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(51, 159);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(90, 13);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Your Total Score:";
            // 
            // frmCasinoRoyale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 506);
            this.Controls.Add(this.gbGame);
            this.Controls.Add(this.gbPlayerDetails);
            this.Controls.Add(this.gbPlayerRegist);
            this.Name = "frmCasinoRoyale";
            this.Text = "CasinoRoyale";
            this.gbPlayerRegist.ResumeLayout(false);
            this.gbPlayerRegist.PerformLayout();
            this.gbPlayerDetails.ResumeLayout(false);
            this.gbPlayerDetails.PerformLayout();
            this.gbGame.ResumeLayout(false);
            this.gbGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPlayerRegist;
        private System.Windows.Forms.GroupBox gbPlayerDetails;
        private System.Windows.Forms.GroupBox gbGame;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSetPic;
        private System.Windows.Forms.PictureBox pbPlayerPic;
        private System.Windows.Forms.Label lblPlayerNumber;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Label lblRollDice;
        private System.Windows.Forms.Label lblTotal;
    }
}

