using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U20447613_Booking_Class_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBooking_Click_Click(object sender, EventArgs e)
        {
            //variables and constants
            string activity;
            double finalPrice = 0;
            int numPeople;
            string name = "";
            string date;
            bool valid =true;

            //get activity, number of people, date, photograph info
            activity = cboActivity.Text;
            numPeople = Convert.ToInt32(nudPeople.Value);
            name = txtName.Text;
            date = Convert.ToString(dateTimePicker1.Value);

            //Update final price, according to the activity...
            switch (cboActivity.Text)
            {
                case "Abseiling":
                        finalPrice += ((500) * numPeople);
                    break;
                case "Quad bikes":
                        finalPrice += (550 * numPeople);
                    break;
                case "Target Archery":
                        finalPrice += (250 * numPeople);
                    break;
                case "Zip-lining":
                        finalPrice += (650 * numPeople);
                    break;
                //Tells the user to select an activity if left out
                default: MessageBox.Show("Select an activity please!");
                    break;
            }
            //Checks for valid booking then if valid prints out booking message
            if (txtName.Text.Equals(""))
            {
                valid = false;
                MessageBox.Show("You forgot to enter your name!");
            }
            //Shows message box where photos are included
            //Update final price to capture whether photo price will be charged
            if (rbPhoto.Checked == true && valid == true)
            {
                finalPrice += (50 * numPeople);
                //Looks to see if 10% discount must be applied to the final price
                if (nudPeople.Value >= 5)
                {
                    finalPrice = finalPrice * 0.9;
                }
                else { 
                    finalPrice += 0;
                }
                MessageBox.Show(name + ", you requested\n"+
                    "a booking for " + activity + ", for\n"+ 
                    numPeople + " people, on\n"+
                    date + ", including photographs.\n" +
                    "Your request will be processed asap.\n" +
                    "The total price will be R" + finalPrice);
                //Unchecks radio button for if the user requires another booking where they possibly won't need a photo
                rbPhoto.Checked = false;
            }
            //Shows message box where photos are not included
            else if(valid == true)
            {
                if (nudPeople.Value >= 5)
                {
                    finalPrice = finalPrice * 0.9;
                }
                else
                {
                    finalPrice += 0;
                }
                MessageBox.Show(name + ", you requested\n"+ 
                                "a booking for " + activity + ", for \n" + 
                                numPeople + " people, on " + date + "\n"+
                                "Your request will be processed asap.\n" +
                                "The total price will be R" + finalPrice);
                //Unchecks radio button for if the user requires another booking where they possibly won't need a photo
                rbPhoto.Checked = false;
            }          
        }
    }
}
