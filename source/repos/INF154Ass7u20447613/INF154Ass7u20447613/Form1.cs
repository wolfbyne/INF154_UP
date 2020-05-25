using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF154Ass7u20447613
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int age = Convert.ToInt32(nudAge.Value), count = 1;
            double price = Convert.ToInt32(txtPriceCar.Text);
            double coin = Convert.ToInt32(txtCurrentValueCoin.Text);
            double total = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    total += (1000*count) - 100;
                    count++;
                }
                else if (i % 2 != 0)
                {
                    total += coin;
                }
            }

            lblSavedOutput.Text = "R" + total.ToString();

            if (price <= total)
            {
                lblOutput.Text = "Yes Rendani Can Afford The Car And Still Has: R" + (total-price);
            }
            else
                lblOutput.Text = "No Rendani Cannot Afford The Car And Still Needs: R" + (price-total);
        }
    }
}
