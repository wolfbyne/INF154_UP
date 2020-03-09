using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF154Prac03_u20447613_
{
    public partial class frmConvert : Form
    {
        public frmConvert()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double converted1 = 0, converted2 = 0;
            if (cbType.Text.Equals("Millimetres"))
            {
                converted1 = (Convert.ToDouble(txtInput1.Text) * 1000);
                txtOutput.Text = converted1.ToString();
                converted2 = (Convert.ToDouble(txtInput2.Text) * 1000);
            }
            else if (cbType.Text.Equals("Kilometres"))
            {
                converted1 = (Convert.ToDouble(txtInput1.Text) / 1000);
                txtOutput.Text = converted1.ToString();
                converted2 = (Convert.ToDouble(txtInput2.Text) / 1000);
            }
            else
                txtOutput.Text = "Error! Enter a value.";

            Output.Items.Add("The first converted value " + converted1.ToString() + " minus the second " + converted2.ToString() + " = " + (converted1-converted2).ToString());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput1.Text = "";
            txtOutput.Text = "";
            cbType.Text = "Choose type";
            txtInput2.Text = "";
            Output.Items.Clear();
        }
    }
}
