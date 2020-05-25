namespace INF154Ass7u20447613
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCurrentValue = new System.Windows.Forms.Label();
            this.lblSavedMoney = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            this.txtPriceCar = new System.Windows.Forms.TextBox();
            this.txtCurrentValueCoin = new System.Windows.Forms.TextBox();
            this.lblSavedOutput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(240, 90);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(116, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Rendani\'s Current Age:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(240, 155);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(76, 13);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Price of Car: R";
            // 
            // lblCurrentValue
            // 
            this.lblCurrentValue.AutoSize = true;
            this.lblCurrentValue.Location = new System.Drawing.Point(243, 209);
            this.lblCurrentValue.Name = "lblCurrentValue";
            this.lblCurrentValue.Size = new System.Drawing.Size(146, 13);
            this.lblCurrentValue.TabIndex = 2;
            this.lblCurrentValue.Text = "Current Value of Gold Coin: R";
            // 
            // lblSavedMoney
            // 
            this.lblSavedMoney.AutoSize = true;
            this.lblSavedMoney.Location = new System.Drawing.Point(243, 275);
            this.lblSavedMoney.Name = "lblSavedMoney";
            this.lblSavedMoney.Size = new System.Drawing.Size(150, 13);
            this.lblSavedMoney.TabIndex = 3;
            this.lblSavedMoney.Text = "Money Saved Over the Years:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(387, 340);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(287, 401);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(69, 13);
            this.lblOutput.TabIndex = 5;
            this.lblOutput.Text = "Is it Enough?";
            // 
            // nudAge
            // 
            this.nudAge.Location = new System.Drawing.Point(445, 90);
            this.nudAge.Name = "nudAge";
            this.nudAge.Size = new System.Drawing.Size(41, 20);
            this.nudAge.TabIndex = 6;
            // 
            // txtPriceCar
            // 
            this.txtPriceCar.Location = new System.Drawing.Point(445, 155);
            this.txtPriceCar.Name = "txtPriceCar";
            this.txtPriceCar.Size = new System.Drawing.Size(100, 20);
            this.txtPriceCar.TabIndex = 7;
            // 
            // txtCurrentValueCoin
            // 
            this.txtCurrentValueCoin.Location = new System.Drawing.Point(445, 209);
            this.txtCurrentValueCoin.Name = "txtCurrentValueCoin";
            this.txtCurrentValueCoin.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentValueCoin.TabIndex = 8;
            // 
            // lblSavedOutput
            // 
            this.lblSavedOutput.AutoSize = true;
            this.lblSavedOutput.Location = new System.Drawing.Point(442, 275);
            this.lblSavedOutput.Name = "lblSavedOutput";
            this.lblSavedOutput.Size = new System.Drawing.Size(15, 13);
            this.lblSavedOutput.TabIndex = 9;
            this.lblSavedOutput.Text = "R";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 486);
            this.Controls.Add(this.lblSavedOutput);
            this.Controls.Add(this.txtCurrentValueCoin);
            this.Controls.Add(this.txtPriceCar);
            this.Controls.Add(this.nudAge);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblSavedMoney);
            this.Controls.Add(this.lblCurrentValue);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Rendani\'s Dream Car";
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCurrentValue;
        private System.Windows.Forms.Label lblSavedMoney;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.NumericUpDown nudAge;
        private System.Windows.Forms.TextBox txtPriceCar;
        private System.Windows.Forms.TextBox txtCurrentValueCoin;
        private System.Windows.Forms.Label lblSavedOutput;
    }
}

