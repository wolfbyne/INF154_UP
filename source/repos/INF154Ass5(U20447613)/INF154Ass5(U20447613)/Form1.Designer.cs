namespace INF154Ass5_U20447613_
{
    partial class frmEnglishGame
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
            this.gbLevelDifficulty = new System.Windows.Forms.GroupBox();
            this.btnBegin = new System.Windows.Forms.Button();
            this.cbLevels = new System.Windows.Forms.ComboBox();
            this.lblChooseLvl = new System.Windows.Forms.Label();
            this.gbEng154 = new System.Windows.Forms.GroupBox();
            this.lblTF = new System.Windows.Forms.Label();
            this.lblWord = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnNxtWrd = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblEnterAnt = new System.Windows.Forms.Label();
            this.gbLevelDifficulty.SuspendLayout();
            this.gbEng154.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLevelDifficulty
            // 
            this.gbLevelDifficulty.Controls.Add(this.btnBegin);
            this.gbLevelDifficulty.Controls.Add(this.cbLevels);
            this.gbLevelDifficulty.Controls.Add(this.lblChooseLvl);
            this.gbLevelDifficulty.Location = new System.Drawing.Point(12, 12);
            this.gbLevelDifficulty.Name = "gbLevelDifficulty";
            this.gbLevelDifficulty.Size = new System.Drawing.Size(567, 151);
            this.gbLevelDifficulty.TabIndex = 0;
            this.gbLevelDifficulty.TabStop = false;
            this.gbLevelDifficulty.Text = "Level Difficulty";
            // 
            // btnBegin
            // 
            this.btnBegin.Location = new System.Drawing.Point(229, 99);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(75, 23);
            this.btnBegin.TabIndex = 2;
            this.btnBegin.Text = "BEGIN";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // cbLevels
            // 
            this.cbLevels.FormattingEnabled = true;
            this.cbLevels.Items.AddRange(new object[] {
            "Beginner",
            "Intermediate",
            "Advanced"});
            this.cbLevels.Location = new System.Drawing.Point(340, 45);
            this.cbLevels.Name = "cbLevels";
            this.cbLevels.Size = new System.Drawing.Size(121, 21);
            this.cbLevels.TabIndex = 1;
            // 
            // lblChooseLvl
            // 
            this.lblChooseLvl.AutoSize = true;
            this.lblChooseLvl.Location = new System.Drawing.Point(96, 48);
            this.lblChooseLvl.Name = "lblChooseLvl";
            this.lblChooseLvl.Size = new System.Drawing.Size(120, 13);
            this.lblChooseLvl.TabIndex = 0;
            this.lblChooseLvl.Text = "Please Choose A Level:";
            // 
            // gbEng154
            // 
            this.gbEng154.Controls.Add(this.lblTF);
            this.gbEng154.Controls.Add(this.lblWord);
            this.gbEng154.Controls.Add(this.txtScore);
            this.gbEng154.Controls.Add(this.txtAnswer);
            this.gbEng154.Controls.Add(this.btnNxtWrd);
            this.gbEng154.Controls.Add(this.lblScore);
            this.gbEng154.Controls.Add(this.lblAnswer);
            this.gbEng154.Controls.Add(this.lblEnterAnt);
            this.gbEng154.Location = new System.Drawing.Point(12, 186);
            this.gbEng154.Name = "gbEng154";
            this.gbEng154.Size = new System.Drawing.Size(567, 346);
            this.gbEng154.TabIndex = 1;
            this.gbEng154.TabStop = false;
            this.gbEng154.Text = "English 154";
            this.gbEng154.Visible = false;
            // 
            // lblTF
            // 
            this.lblTF.AutoSize = true;
            this.lblTF.Location = new System.Drawing.Point(324, 139);
            this.lblTF.Name = "lblTF";
            this.lblTF.Size = new System.Drawing.Size(77, 13);
            this.lblTF.TabIndex = 7;
            this.lblTF.Text = "Correct or not?";
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.Location = new System.Drawing.Point(261, 83);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(43, 20);
            this.lblWord.TabIndex = 6;
            this.lblWord.Text = "word";
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(128, 208);
            this.txtScore.Name = "txtScore";
            this.txtScore.ReadOnly = true;
            this.txtScore.Size = new System.Drawing.Size(100, 20);
            this.txtScore.TabIndex = 5;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(128, 136);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(100, 20);
            this.txtAnswer.TabIndex = 4;
            // 
            // btnNxtWrd
            // 
            this.btnNxtWrd.Location = new System.Drawing.Point(327, 203);
            this.btnNxtWrd.Name = "btnNxtWrd";
            this.btnNxtWrd.Size = new System.Drawing.Size(105, 23);
            this.btnNxtWrd.TabIndex = 3;
            this.btnNxtWrd.Text = "NEXT WORD";
            this.btnNxtWrd.UseVisualStyleBackColor = true;
            this.btnNxtWrd.Click += new System.EventHandler(this.btnNxtWrd_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(46, 208);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(38, 13);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Score:";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(46, 136);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(45, 13);
            this.lblAnswer.TabIndex = 1;
            this.lblAnswer.Text = "Answer:";
            // 
            // lblEnterAnt
            // 
            this.lblEnterAnt.AutoSize = true;
            this.lblEnterAnt.Location = new System.Drawing.Point(20, 83);
            this.lblEnterAnt.Name = "lblEnterAnt";
            this.lblEnterAnt.Size = new System.Drawing.Size(208, 13);
            this.lblEnterAnt.TabIndex = 0;
            this.lblEnterAnt.Text = "Please Enter The ANTONYM for the word:";
            // 
            // frmEnglishGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 544);
            this.Controls.Add(this.gbEng154);
            this.Controls.Add(this.gbLevelDifficulty);
            this.Name = "frmEnglishGame";
            this.Text = "English Game";
            this.gbLevelDifficulty.ResumeLayout(false);
            this.gbLevelDifficulty.PerformLayout();
            this.gbEng154.ResumeLayout(false);
            this.gbEng154.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLevelDifficulty;
        private System.Windows.Forms.GroupBox gbEng154;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.ComboBox cbLevels;
        private System.Windows.Forms.Label lblChooseLvl;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblEnterAnt;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnNxtWrd;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label lblTF;
    }
}

