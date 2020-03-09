using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF154Prac02Ex01
{
    public partial class frmArt : Form
    {
        public frmArt()
        {
            InitializeComponent();
        }
        private void btnSmaller_Click(object sender, EventArgs e)
        {
            int width = gboxMyPalette.Width;
            int height = gboxMyPalette.Height;
            gboxMyPalette.Size = new Size(width - 10, height - 10);
            int area;
            area = gboxMyPalette.Width * gboxMyPalette.Height;
            lblArea.Text = "Area in Pixels: \n" + area.ToString();
        }
        private void btnBigger_Click(object sender, EventArgs e)
        {
            int width = gboxMyPalette.Width;
            int height = gboxMyPalette.Height;
            gboxMyPalette.Size = new Size(width + 10, height + 10);
            int area;
            area = gboxMyPalette.Width * gboxMyPalette.Height;
            lblArea.Text = "Area in Pixels: \n" + area.ToString();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            int red, blue, green;
            red = Convert.ToInt16(nudRed.Value);
            blue = Convert.ToInt16(nudBlue.Value);
            green = Convert.ToInt16(nudGreen.Value);
            gboxMyPalette.BackColor = Color.FromArgb(red, green, blue);
        }
    }
}
