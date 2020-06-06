using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF154Ass9U20447613
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void FillAll()
        {
            string c = txtC.Text;
            txtEven.Text = c;
            txtOdd.Text = c;
            txtSum.Text = c;
            txtSquare.Text = c;
        }

        public void ClearAll()
        {
            txtSquare.Clear();
            txtSum.Clear();
            txtOdd.Clear();
            txtName.Clear();
            txtEven.Clear();
            txtAnswerOdd.Clear();
            txtAnswerSquare.Clear();
            txtAnswerSum.Clear();
            txtAnswerEven.Clear();
            txtC.Clear();
        }

        public int SumC(int c)
        {
            int sum = 0;
            for (int i = 0; i <= c; i++)
            {
                sum += i;
            }
            return sum;
        }

        public bool IsEven(int c)
        {
            if (c % 2 == 0)
            {
                return true;
            }else
                return false;
        }

        public bool IsOdd(int c)
        {
            if (c % 2 != 0)
            {
                return true;
            }
            else
                return false;
        }

        public int SquareIt(int c)
        {
            double square = Math.Pow(c, 2);
            c = Convert.ToInt32(square);
            return c;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Equals(""))
            {
                MessageBox.Show("Please enter your name into the field.");
            }else
                MessageBox.Show("Welcome To Homework 9, " + txtName.Text.ToUpper());
        }

        private void btnFillAll_Click(object sender, EventArgs e)
        {    
            if (txtC.Text != "")
            {
                FillAll();
            }
            else
                MessageBox.Show("Please enter the variable value for C.");
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int c = Convert.ToInt32(txtSum.Text);
            txtAnswerSum.Text = SumC(c).ToString();
        }

        private void btnEven_Click(object sender, EventArgs e)
        {
            int c = Convert.ToInt32(txtEven.Text);
            txtAnswerEven.Text = IsEven(c).ToString();
        }

        private void btnOdd_Click(object sender, EventArgs e)
        {
            int c = Convert.ToInt32(txtOdd.Text);
            txtAnswerOdd.Text = IsOdd(c).ToString();
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            int c = Convert.ToInt32(txtSquare.Text);
            txtAnswerSquare.Text = SquareIt(c).ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
    }
}
