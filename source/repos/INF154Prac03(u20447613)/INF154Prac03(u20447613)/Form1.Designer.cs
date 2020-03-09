namespace INF154Prac03_u20447613_
{
    partial class frmConvert
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtInput1 = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblMetres1 = new System.Windows.Forms.Label();
            this.lblArrow = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblMetres2 = new System.Windows.Forms.Label();
            this.lblEquals = new System.Windows.Forms.Label();
            this.txtInput2 = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(85, 69);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(313, 24);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Enter in the unit you want to convert:";
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(205, 376);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(78, 31);
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtInput1
            // 
            this.txtInput1.Location = new System.Drawing.Point(89, 190);
            this.txtInput1.Name = "txtInput1";
            this.txtInput1.Size = new System.Drawing.Size(100, 20);
            this.txtInput1.TabIndex = 2;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(298, 190);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(100, 20);
            this.txtOutput.TabIndex = 3;
            // 
            // lblMetres1
            // 
            this.lblMetres1.AutoSize = true;
            this.lblMetres1.Location = new System.Drawing.Point(116, 149);
            this.lblMetres1.Name = "lblMetres1";
            this.lblMetres1.Size = new System.Drawing.Size(48, 13);
            this.lblMetres1.TabIndex = 4;
            this.lblMetres1.Text = "Metres 1";
            // 
            // lblArrow
            // 
            this.lblArrow.AutoSize = true;
            this.lblArrow.Location = new System.Drawing.Point(229, 193);
            this.lblArrow.Name = "lblArrow";
            this.lblArrow.Size = new System.Drawing.Size(25, 13);
            this.lblArrow.TabIndex = 6;
            this.lblArrow.Text = ">>>";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Millimetres",
            "Kilometres"});
            this.cbType.Location = new System.Drawing.Point(286, 146);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 21);
            this.cbType.TabIndex = 7;
            this.cbType.Text = "Choose type";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(208, 425);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 28);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblMetres2
            // 
            this.lblMetres2.AutoSize = true;
            this.lblMetres2.Location = new System.Drawing.Point(104, 234);
            this.lblMetres2.Name = "lblMetres2";
            this.lblMetres2.Size = new System.Drawing.Size(72, 13);
            this.lblMetres2.TabIndex = 9;
            this.lblMetres2.Text = "Metres to add";
            // 
            // lblEquals
            // 
            this.lblEquals.AutoSize = true;
            this.lblEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquals.Location = new System.Drawing.Point(229, 234);
            this.lblEquals.Name = "lblEquals";
            this.lblEquals.Size = new System.Drawing.Size(18, 20);
            this.lblEquals.TabIndex = 10;
            this.lblEquals.Text = "=";
            // 
            // txtInput2
            // 
            this.txtInput2.Location = new System.Drawing.Point(298, 234);
            this.txtInput2.Name = "txtInput2";
            this.txtInput2.Size = new System.Drawing.Size(100, 20);
            this.txtInput2.TabIndex = 11;
            // 
            // Output
            // 
            this.Output.FormattingEnabled = true;
            this.Output.Location = new System.Drawing.Point(89, 276);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(309, 82);
            this.Output.TabIndex = 12;
            // 
            // frmConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 465);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.txtInput2);
            this.Controls.Add(this.lblEquals);
            this.Controls.Add(this.lblMetres2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.lblArrow);
            this.Controls.Add(this.lblMetres1);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput1);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblHeading);
            this.Name = "frmConvert";
            this.Text = "Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtInput1;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblMetres1;
        private System.Windows.Forms.Label lblArrow;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblMetres2;
        private System.Windows.Forms.Label lblEquals;
        private System.Windows.Forms.TextBox txtInput2;
        private System.Windows.Forms.ListBox Output;
    }
}

