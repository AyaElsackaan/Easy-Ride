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
    public partial class UpdateDriverSalary : Form
    {
        Controller controllerObj;
        public UpdateDriverSalary()
        {
            InitializeComponent();
            controllerObj = new Controller();

            DataTable dt = controllerObj.AllDrivers();
            DriverID.DataSource = dt;
            DriverID.DisplayMember = "D_ID";
            DriverID.ValueMember = "D_ID";
        }

        private void Update_driver_salary_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DriverID.SelectedValue.ToString()))
            {
                MessageBox.Show("Please, choose Driver ID");
            }
            else
            {
                int r = controllerObj.UpdateDriversalary(Convert.ToInt16(DriverID.SelectedValue), Convert.ToInt32(NewSalary.Value));
                if (r != 0)
                    MessageBox.Show("Salary Updated successfully");
                else
                    MessageBox.Show("Update Failed");
            }

        }
    }
}
