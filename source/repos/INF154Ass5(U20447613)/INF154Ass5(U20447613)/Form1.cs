using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF154Ass5_U20447613_
{
    public partial class frmEnglishGame : Form
    {
        public frmEnglishGame()
        {
            InitializeComponent();
        }
        int count = 0;
        int score = 0;
        string[] beginner = { "Start", "Tall", "Big" };
        string[] answers1 = { "end", "short", "small" };
        string[] intermediate = { "Dead", "Huge", "Heaven" };
        string[] answers2 = { "alive", "tiny", "hell" };
        string[] advanced = { "Behave", "Forgiving", "Conformist" };
        string[] answers3 = { "misbehave", "unforgiving", "nonconformist" };
        private void btnBegin_Click(object sender, EventArgs e)
        {
            if (cbLevels.Text.Equals(""))
            {
                MessageBox.Show("Please select one of the options.");
            }
            else if (cbLevels.Text.Equals("") == false)
            {
                switch (cbLevels.Text)
                {
                    case "Beginner": lblWord.Text = beginner[count];
                        break;
                    case "Intermediate": lblWord.Text = intermediate[count];
                        break;
                    case "Advanced": lblWord.Text = advanced[count];
                        break;
                    default: lblWord.Text = "Error!";
                        break;
                }
                gbLevelDifficulty.Enabled = false;
                gbEng154.Visible = true;
            }
        }
        private void btnNxtWrd_Click(object sender, EventArgs e)
        {
            if (txtAnswer.Text.ToLower() == answers1[count] || txtAnswer.Text.ToLower() == answers2[count] || txtAnswer.Text.ToLower() == answers3[count])
            {
                score += 5;
                txtScore.Text = score.ToString();
                txtAnswer.Text = "";
                lblTF.Text = "Correct!";
                if (count == 2)
                {
                    lblWord.Text = "Well Done! You Have Completed This level.";
                    txtScore.Text = score.ToString() + "/15";
                    lblTF.Visible = false;
                }
                else if (count < 2)
                {
                    count++;
                    switch (cbLevels.Text)
                    {
                        case "Beginner":
                            lblWord.Text = beginner[count];
                            break;
                        case "Intermediate":
                            lblWord.Text = intermediate[count];
                            break;
                        case "Advanced":
                            lblWord.Text = advanced[count];
                            break;
                        default:
                            lblWord.Text = "Error!";
                            break;
                    }
                }
            }
            else
            {
                lblTF.Text = "Wrong!";
                txtAnswer.Text = "";
            }
        }
    }
}
