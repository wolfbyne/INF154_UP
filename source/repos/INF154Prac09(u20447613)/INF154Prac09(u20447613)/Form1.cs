using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF154Prac09_u20447613_
{
    public partial class Form1 : Form
    {
        string backup = "Welcome to the practical 9 of INF 154 2020! Let's do string manipulation...";
        string path = "C:\\Users\\flemi\\Documents\\rtb.rtf";
        public Form1()
        {
            InitializeComponent();
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {           
            rtbInput.SaveFile(path);
            loadToolStripMenuItem1.Enabled = true;
        }

        private void loadToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            rtbInput.LoadFile(path);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void resetTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbInput.Clear();
            rtbInput.AppendText(backup);
        }

        private void btnReplace_Click_1(object sender, EventArgs e)
        {
            if (txtLetter.Text.Equals(""))
            {
                MessageBox.Show("Please enter a charcater!");
            }
            else if (txtLetter.Text.Length <= 1)
            {
                char letter = Convert.ToChar(txtLetter.Text.ToLower());
                rtbInput.Text = rtbInput.Text.Replace(letter, '*');
            }
            else
            {
                MessageBox.Show("Error you entered more than 1 letter!");
                txtLetter.Clear();
            }
        }

        private void btnReverse_Click_1(object sender, EventArgs e)
        {
            string word, reversedword;

            for (int i = 0; i < rtbInput.Lines.Count(); i++)
            {
                word = rtbInput.Lines[i];
                reversedword = "";
                for (int j = 0; j < word.Length; j++)
                {
                    reversedword = word[j] + reversedword;
                    rtbInput.Text = reversedword;
                }
            }
        }

        public int CountLetters(char c)
        {
            int lettercount;
            string text = rtbInput.Text;
            lettercount = text.Split(c).Length -1;      
            return lettercount;
        }

        private void btnTestName_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int count;
            
            string letter;
            char [] c = name.ToCharArray();           
            for (int i = 0; i < name.Length; i++)
            {
                letter = c[i].ToString();
                count = CountLetters(c[i]);
                MessageBox.Show("The letter " + letter.ToUpper() + " appears " + count + " time(s)");
            }
        }
    }
}
