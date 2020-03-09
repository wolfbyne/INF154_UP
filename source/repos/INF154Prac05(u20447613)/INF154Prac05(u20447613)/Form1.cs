using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF154Prac05_u20447613_
{
    public partial class frmCasinoRoyale : Form
    {
        public frmCasinoRoyale()
        {
            InitializeComponent();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Equals("") == false)
            {
                lblPlayerName.Text += " " + txtName.Text;
                Random random = new Random();
                lblPlayerNumber.Text += " " + random.Next(100, 999).ToString();
                gbPlayerDetails.Visible = true;
            }else
                MessageBox.Show("Error, enter in a valid input.");
        }
        private void btnSetPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();
            pbPlayerPic.Image = new Bitmap(open.FileName);
            gbGame.Visible = true;
        }
        int total = 0;
        private void btnRoll_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int ran = random.Next(1,13);   
            switch (ran)
            {
                case 1: total = 0; MessageBox.Show("Score gone to zero...");
                    break;
                case 2: case 3: case 4: case 5: case 6: total+=5; MessageBox.Show("Score gone up by 5.");
                    break;
                case 7: total += 7; MessageBox.Show("Score gone up by 7.");
                    break;
                case 8: total += 8; MessageBox.Show("Score gone up by 8.");
                    break;
                case 9: total += 9; MessageBox.Show("Score gone up by 9.");
                    break;
                case 10: total += 10; MessageBox.Show("Score gone up by 10.");
                    break;
                case 11: total += 11; MessageBox.Show("Score gone up by 11.");
                    break;
                case 13: total -= 5; MessageBox.Show("Score gone down by 5.");
                    break;
            }
            lblTotal.Text = "Your Total Score: " + total;
        }
    }
}
