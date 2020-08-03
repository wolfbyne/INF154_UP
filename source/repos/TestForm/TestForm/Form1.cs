using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TestForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Declare and open, create the instance
            StreamWriter outputfile;
            outputfile = new StreamWriter("Lecture1.txt");
            //Access the file and write to it
            outputfile.WriteLine(textBox1.Text);
            //Close the file
            outputfile.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Declare and open the file
            StreamReader inputfile;
            inputfile = new StreamReader("Lecture1.txt");
            //Access the file
            string inputAllLines;
            //take contents


        }
    }
}
