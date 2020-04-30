using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyRide
{
    public partial class AddNewDriver : Form
    {
        Controller controllerObj;
        public AddNewDriver()
        {
            InitializeComponent();controllerObj = new Controller();
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            if (Driver_ID.Text == "" || Driver_Name.Text == "" || Password.Text == "" || DriverPhone.Text == "")//validation part
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                int r = controllerObj.AddDriver(Convert.ToInt32(Driver_ID.Text), Driver_Name.Text.ToString(), DriverPhone.Text, Password.Text, Convert.ToInt32(Driver_salary.Value));
                if (r != 0)
                    MessageBox.Show("Driver inserted successfully");
                else
                    MessageBox.Show("Insertion Failed");
            }
        }
    }
}
