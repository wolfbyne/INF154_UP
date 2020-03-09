using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF154Ass4_U20447613_
{
    public partial class frmStoreCardRegistration : Form
    {
        public frmStoreCardRegistration()
        {
            InitializeComponent();
        }
        private void btnSubmitClient_Click(object sender, EventArgs e)
        {
            Boolean valid = true;
            if (txtName.Text.Equals("") || txtSurname.Text.Equals(""))
            {
                MessageBox.Show("Error, please fill in the form fully.");
                valid = false;
            }
            else if ((2020 - nupYOB.Value) < 18)
            {
                MessageBox.Show("Sorry, but you are younger than 18 years.");
                valid = false;
            }
            else if ((2020 - nupYOB.Value) > 100)
            {
                MessageBox.Show("Please would you enter a valid age... Honestly, older than 100 years?");
                valid = false;
            }
            else if (valid = true)
            {
                MessageBox.Show(txtName.Text + " " + txtSurname.Text + ", born in " + nupYOB.Value);
                gbAccDet.Visible = true;
            }
                               
        }
        private void btnSubmitAccount_Click(object sender, EventArgs e)
        {
            Boolean valid = true;
            if (cbAccType.Text.Equals(""))
            {
                MessageBox.Show("Please select and option from the drop down.");
                valid = false;
            }
            else if (cbAccType.Text.Equals("Clever Shopper") && nupCL.Value > 0)
            {
                MessageBox.Show("A Clever Shopper account cannot obtain any credit.");
                valid = false;
            }
            else if (cbAccType.Text.Equals("Club Card") && nupCL.Value > 1000)
            {
                MessageBox.Show("A Club Card account cannot have any credit more than R1000.");
                valid = false;
            }
            else if (cbAccType.Text.Equals("Big-Spender Card") && nupCL.Value < 2000)
            {
                MessageBox.Show("A Big-Spender account must have credit higher than R2000");
                valid = false;
            }
            else if (valid)
            {
                gbNewAccInfo.Visible = true;
                txtNameAccHolder.Text = txtName.Text + " " + txtSurname.Text;
                txtAccountType1.Text = cbAccType.Text;
                txtAccCredLim.Text = nupCL.Value.ToString();
            }
        }
        private void btnAddAnotherAcc_Click(object sender, EventArgs e)
        {
            if (rbForSameClient.Checked)
            {
                gbNewAccInfo.Visible = false;
                nupCL.Value = 0;
                cbAccType.Text = "";
            }
            else if (rbForDifferentClient.Checked)
            {
                gbAccDet.Visible = false;
                gbNewAccInfo.Visible = false;
                txtName.Text = "";
                txtSurname.Text = "";
                nupYOB.Value = 1920;
                nupCL.Value = 0;
                cbAccType.Text = "";
            }
        }
    }
}