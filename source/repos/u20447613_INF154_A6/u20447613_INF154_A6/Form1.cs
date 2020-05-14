using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace u20447613_INF154_A6
{
    public partial class frmClassSignUp : Form
    {
        public frmClassSignUp()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtNameAdd.Text.Equals("") || txtSurnameAdd.Text.Equals(""))
            {
                MessageBox.Show("One of the fields are blank!");
            }
            else if (lbStudents.Items.Contains(txtNameAdd.Text+" "+txtSurnameAdd.Text) == false)
            {
                lbStudents.Items.Add(txtNameAdd.Text+" "+txtSurnameAdd.Text);
                MessageBox.Show(txtNameAdd.Text + " " + txtSurnameAdd.Text + " has been added to the list");
            }
            else
                MessageBox.Show("That person is already in the list");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (txtNameRemove.Text.Equals("")||txtSurnameRemove.Text.Equals(""))
            {
                MessageBox.Show("One of the fields are blank!");
            }else if (lbStudents.Items.Contains(txtNameRemove.Text + " " + txtSurnameRemove.Text) == true)
            {
                lbStudents.Items.Remove(txtNameRemove.Text + " " + txtSurnameRemove.Text);
                MessageBox.Show(txtNameRemove.Text + " " + txtSurnameRemove.Text + " has been removed.");
            }
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            lbStudents.Items.Clear();
        }
    }
}
