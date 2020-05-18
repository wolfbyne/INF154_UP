using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF154Prac07_u20447613_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double balance = 1000;
        double interest = 0.04;

        private void btnPies_Click(object sender, EventArgs e)
        {
            lblPieOutput.Text = "";
            for (int i = 0; i < nudPies.Value; i++)
            {
                lblPieOutput.Text += "Pie\n";
            }
        }

        private void btnViewBalance_Click(object sender, EventArgs e)
        {
            balance += (balance * interest);
            lblBalanceOutput.Text += "\nYour bank balance is: " + balance.ToString("C") + "\n";         
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
            }else
                timer1.Start();
            lblTimerOutput.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            balance += (balance * interest);
            lblTimerOutput.Text += "Your bank balance is: " + balance.ToString("C") + "\n";
        }

        private void btnRows_Click(object sender, EventArgs e)
        {
            int rows = Convert.ToInt32(nudRows.Value);
            string line = "";
            lblRowsOutput.Text = "";
            for (int i = 1; i <= rows; i++)
            {
                line += Convert.ToString(i);
                lblRowsOutput.Text += line + "\n";
            }
        }
    }
}
