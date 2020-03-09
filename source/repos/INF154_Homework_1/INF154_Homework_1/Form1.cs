using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF154_Homework_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnDarkness_Click(object sender, EventArgs e)
        {
            BackColor = Color.Black;
            lblBlue.Visible = false;
            lblGreen.Visible = false;
            lblRed.Visible = false;
            lblYellow.Visible = false;
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            lblRed.Visible = true;
            lblRed.Text = "WELL DONE";
            lblRed.ForeColor = Color.Red;
            btnRed.Text = "Winner";
            btnRed.BackColor = Color.Red;
        }
        private void btnYellow_Click(object sender, EventArgs e)
        {
            lblYellow.Visible = true;
            lblYellow.Text = "WELL DONE";
            lblYellow.ForeColor = Color.Yellow;
            btnYellow.Text = "Winner";
            btnYellow.BackColor = Color.Yellow;
        }
        private void btnGreen_Click(object sender, EventArgs e)
        {
            lblGreen.Visible = true;
            lblGreen.Text = "WELL DONE";
            lblGreen.ForeColor = Color.Green;
            btnGreen.Text = "Winner";
            btnGreen.BackColor = Color.Green;
        }
        private void btnBlue_Click(object sender, EventArgs e)
        {
            lblBlue.Visible = true;
            lblBlue.Text = "WELL DONE";
            lblBlue.ForeColor = Color.Blue;
            btnBlue.Text = "Winner";
            btnBlue.BackColor = Color.Blue;
        }
    }
}
