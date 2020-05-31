using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace u20447613_INF154_A8
{
    public partial class frmManage : Form
    {
        string [] members = new string[5];
        int i = 0;
        bool space = false;

        public frmManage()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            lbEmployees.Visible = true;
            lbEmployees.Items.Clear();

            for (int i = 0; i < 5; i++)
            {
                if (members[i]==null)
                {
                    lbEmployees.Items.Add("Not all or any of the employees have been added yet.");
                    break;
                }else
                    lbEmployees.Items.Add(i+1 + ". " + members[i] + "\n");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string fullnameAdd = txtFirstNameAdd.Text + " " + txtSurnameAdd.Text;
            if (txtFirstNameAdd.Text != "" && txtSurnameAdd.Text != "")
            {                
                if (i == 5)
                {
                    MessageBox.Show("Array is full, max amount of employees entered.");
                    btnAdd.Enabled = false;
                    gbRemove.Visible = true;
                    txtFirstNameAdd.Clear();
                    txtSurnameAdd.Clear();
                }
                else if (space == true)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        if (members[i] == "")
                        {
                            members[i] = fullnameAdd;
                            break;
                        }
                    }
                    txtFirstNameAdd.Clear();
                    txtSurnameAdd.Clear();
                    txtFirstNameAdd.Focus();
                    i++;
                }
                else
                {
                    members[i] = fullnameAdd;
                    i++;
                    txtFirstNameAdd.Clear();
                    txtSurnameAdd.Clear();
                    txtFirstNameAdd.Focus();
                }
            }
            else
                MessageBox.Show("Error one, or both of the input fields is not filled in.");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string fullnameRemove = txtFirstNameRemove.Text + " " + txtSurnameRemove.Text;
            if (txtFirstNameRemove.Text != "" && txtSurnameRemove.Text != "")
            {
                int j = Array.IndexOf(members,fullnameRemove);
                if (j != -1)
                {
                    members[j] = "";
                    btnAdd.Enabled = true;
                    i--;
                    space = true;
                }
                else
                {
                    MessageBox.Show("There was no-one with that name.");
                }
                txtFirstNameRemove.Clear();
                txtSurnameRemove.Clear();
                txtFirstNameRemove.Focus();
            }
            else if (nudIndex.Value != 0)
            {
                int index = Convert.ToInt32(nudIndex.Value);
                members[index - 1] = "";
                btnAdd.Enabled = true;
                nudIndex.Value = 0;
                i--;
                space = true;
            }
            else
                MessageBox.Show("Error! One, or both of the input fields is not filled in.\n"+"OR\n" +
                                "0 is invalid, pick numbers 1 to 5.");
        }
    }
}
