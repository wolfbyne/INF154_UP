using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF154Ass2_U20447613_
{
    public partial class frmBHS : Form
    {
        public frmBHS()
        {
            InitializeComponent();
        }
        String name;
        String surname;
        private void btnCVD_Click(object sender, EventArgs e)
        {
            name = txtName.Text;
            surname = txtSurname.Text;
            lblVisDetails.Text = "Visit details for " + name + " " + surname;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            lblStatus.Text = cbRoomType.Text;
            int cpn = Convert.ToInt16(txtCPN.Text);
            int non = Convert.ToInt16(txtNON.Text);
            int Total = non * cpn;
            txtCOV.Text = Total.ToString();
            double VAT = 0.15*Total;
            txtVAT.Text = VAT.ToString();
            double TotalwithVAT = VAT + Total;
            txtTC.Text = TotalwithVAT.ToString();
        }
        private void btnFV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Visit booked for " + name + " " + surname + " for " + txtNON.Text + " night(s) at R" + txtTC.Text);
        }
    }
}
