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
    public partial class RemovingTrip : Form
    {
        Controller controllerObj;
        public RemovingTrip()
        {
            InitializeComponent();
            controllerObj = new Controller();

            DataTable dt = controllerObj.GetAllTrips();
            TripIDs.DataSource = dt;
            TripIDs.DisplayMember = "T_code";
            TripIDs.ValueMember = "T_code";
        }

        private void RemoveTrip_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TripIDs.SelectedValue.ToString()))
            {
                MessageBox.Show("Please Select the Trip ID");
            }
            else
            {
                int r = controllerObj.RemoveTrip(Convert.ToInt16(TripIDs.SelectedValue));
                if (r != 0)
                    MessageBox.Show("Trip Removed successfully");
                else
                    MessageBox.Show("Deletion Failed");
            }
        }
    }
}
