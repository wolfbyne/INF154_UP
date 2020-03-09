using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF154Prac02Ex02
{
    public partial class frmMyMarks : Form
    {
        double totalMarks;
        int myModules;
        public frmMyMarks()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double finalMark;

            finalMark = (Convert.ToDouble(txtSemWeight.Text) / 100 * Convert.ToDouble(nudSemMark.Value))
                + (Convert.ToDouble(txtExamWeight.Text) / 100 * Convert.ToDouble(nudExamMark.Value));

            lboxReport.Items.Add(txtModule.Text + "\t\tFinal Mark: " + finalMark + "\t\t" + cboxType.Text);

            myModules++;

            totalMarks += finalMark;

            int distinction = 75;
            double markNeeded = 0;
            while ((totalMarks / myModules) + ((100 - (Convert.ToDouble(txtSemWeight.Text) + Convert.ToDouble(txtExamWeight.Text))) / 100 * markNeeded) <= distinction)
            {
                markNeeded++;
            }
            txtDistinction.Text = markNeeded.ToString();
        }

        private void btnAnalyse_Click(object sender, EventArgs e)
        {
            txtAverage.Text = (totalMarks / myModules).ToString();

            MessageBox.Show("The average is: " + (totalMarks / myModules).ToString() + "%");
        }

        private void btnResetAll_Click(object sender, EventArgs e)
        {
            totalMarks = 0;
            myModules = 0;
            lboxReport.Items.Clear();
            txtAverage.Text = "";
        }
    }
}
