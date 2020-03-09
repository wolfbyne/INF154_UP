using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF154Prac04_u20447613_
{
    public partial class frmUni : Form
    {
        public frmUni()
        {
            InitializeComponent();
        }
        private void btnConfirmDetails_Click(object sender, EventArgs e)
        {
            if (rbMale.Checked == true)
            {
                MessageBox.Show("Welcome Mr " + txtFullName.Text + ", Student Number: " + txtStuNum.Text);
            }
            else
                MessageBox.Show("Welcome Mrs " + txtFullName.Text + ", Student Number: " + txtStuNum.Text);
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
                lblOutput1.Visible = true;
                lblOutput2.Visible = true;
                lblOutput3.Visible = true;
                lblOutput4.Visible = true;
            if (cbModuleName.Text.Equals("INF 154"))
            {               
                lblOutput1.Text = "1";
                lblOutput2.Text = "75";
                lblOutput3.Text = "90%";
                lblOutput4.Text = "67%";
            }else if (cbModuleName.Text.Equals("INF 164"))
            {
                lblOutput1.Text = "2";
                lblOutput2.Text = "70";
                lblOutput3.Text = "60%";
                lblOutput4.Text = "60%";
            }else if (cbModuleName.Text.Equals("INF 171"))
            {
                lblOutput1.Text = "1 and 2";
                lblOutput2.Text = "120";
                lblOutput3.Text = "85%";
                lblOutput4.Text = "71%";
            }else if (cbModuleName.Text.Equals("OBS 110"))
            {
                lblOutput1.Text = "1";
                lblOutput2.Text = "185";
                lblOutput3.Text = "65%";
                lblOutput4.Text = "58%";
            }else if (cbModuleName.Text.Equals("OBS 120"))
            {
                lblOutput1.Text = "2";
                lblOutput2.Text = "160";
                lblOutput3.Text = "76%";
                lblOutput4.Text = "65%";
            }
        }

        private void btnAnalyse_Click(object sender, EventArgs e)
        {
            int mark = Convert.ToInt16(txtMark.Text);
            if (mark >= 90)
            {
                MessageBox.Show("”EXCELLENT! YOU HAVE RECEIVED AN A+ FOR THIS MODULE");
            }else if (mark >= 80)
            {
                MessageBox.Show("WELL DONE! YOU HAVE RECEIVED AN A FOR THIS MODULE!");
            }else if (mark >= 70)
            {
                MessageBox.Show("NICE WORK, YOU HAVE RECEIVED A ‘B’ FOR THIS MODULE!");
            }else if (mark >= 60)
            {
                MessageBox.Show("GOOD EFFORT! YOU HAVE RECEIVED A ’C’ FOR THIS MODULE");
            }else if (mark >= 50)
            {
                MessageBox.Show("CUTTING IT SHORT! YOU HAVE JUST PASSED THIS MODULE");
            }
            else if (mark < 49)
            {
                MessageBox.Show("THIS IS NOT GOOD. YOU HAVE FAILED THIS MODULE!");
            }
        }
    }
}
