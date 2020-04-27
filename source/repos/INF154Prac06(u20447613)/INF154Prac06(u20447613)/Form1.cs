using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF154Prac06_u20447613_
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            lbPlayer1.Items.Clear();
            lbPlayer2.Items.Clear();
            int min = 2, max = 50, sum1 = 0, sum2 = 0, trn1 = 0, trn2 = 0;
            int multiple1 = 0, multiple2 = 0;
            Random random = new Random();
            int player1 = 0;
            int player2 = 0;
            while (player1 != 30)
            {
                player1 = random.Next(min, max);
                lbPlayer1.Items.Add(player1);
                sum1 += player1;
                trn1++;
                if (player1 % 4 == 0)
                {
                    multiple1++;
                }
            }
            while (player2 != 30)
            {

                player2 = random.Next(min, max);
                lbPlayer2.Items.Add(player2);
                sum2 += random.Next(min, max);
                trn2++;
                if (player2 % 4 == 0)
                {
                    multiple2++;
                }
            }
            if (sum1 > sum2)
            {
                lblWinnerOutput.Text = "PLAYER 1!";
            }else
                lblWinnerOutput.Text = "PLAYER 2!";
            if (multiple1 > multiple2)
            {
                lblMultipleOutput.Text = "PLAYER 1!";
            }else
                lblMultipleOutput.Text = "PLAYER 2!";
            // Player 1 //
            lblM1.Text = multiple1.ToString();
            lblOutputTRN1.Text = trn1.ToString();
            lblST1.Text = sum1.ToString();
            // Player 2 //
            lblM2.Text = multiple2.ToString();
            lblOutputTRN2.Text = trn2.ToString();
            lblST2.Text = sum2.ToString();
        }
    }
}
