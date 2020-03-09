using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF154Ass3_U20447613_
{
    public partial class frmFitness : Form
    {
        public frmFitness()
        {
            InitializeComponent();
        }
        private void btnCD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome " + txtName.Text + " " + txtSurname.Text + " (ID NUMBER: " + txtID.Text + ")");
        }
        private void btnCW_Click(object sender, EventArgs e)
        {
            double weight = Convert.ToDouble(txtKG.Text);
            double pound = 2.2;
            double converted = weight * pound;
            lblWeightOut.Text = "Your Weight In Pounds is: " + converted.ToString() + "lbs";
        }
        private void btnCH_Click(object sender, EventArgs e)
        {
            double height = Convert.ToDouble(txtCM.Text);
            double inch = 0.39;
            double converted = height * inch;
            lblHeightOut.Text = "Your Height In Inches is " + converted.ToString() + "in";
        }
        private void btnBMI_Click(object sender, EventArgs e)
        {
            double weight = Convert.ToDouble(txtPounds.Text);
            double height = Convert.ToDouble(txtInches.Text);
            double bmi = weight/(height*height)*703;
            lblResult.Visible = true;
            lblResult.Text = "Your BMI is: " + bmi.ToString();
        }
    }
}
