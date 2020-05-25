using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF154Prac08_u20447613_
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        int[] num = new int[4];
        int i = 0;

        private void btnAddNum_Click(object sender, EventArgs e)
        {
            num[i] = Convert.ToInt32(txtInputNum.Text);
            i++;

            txtInputNum.Clear();
            txtInputNum.Focus();

            if (i == 4)
            {
                btnAddNum.Enabled = false;
                btnFindMaxMin.Enabled = true;
            }
        }

        private void btnFindMaxMin_Click(object sender, EventArgs e)
        {
            lblMax.Text += " " + num.Max().ToString();
            lblMin.Text += " " + num.Min().ToString();
        }

        private void btnAnalyse_Click(object sender, EventArgs e)
        {
            int [] array = new int[lb1.Items.Count];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(lb1.Items[i].ToString());
                if (array[i] % 2 == 0)
                {
                    lb2.Items.Add("0\n");
                }
                else
                    lb2.Items.Add("1\n");
            }
        }

        private void btnFeeling_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int num = rnd.Next(0,4);
            pbFeeling.Image = imlFeelings.Images[num];
        }
    }
}
