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
    public partial class AddTripForm : Form
    {
        Controller controllerObj;
        public AddTripForm()
        {
            InitializeComponent();
            controllerObj = new Controller();
            
            DataTable dt = controllerObj.AllBuses();
            addtrip_bus_no.DataSource = dt;
            addtrip_bus_no.DisplayMember = "Bus_no";
            addtrip_bus_no.ValueMember = "Bus_no";

            DataTable dt1 = controllerObj.AllRegions();
            trip_Region.DataSource = dt1;
            trip_Region.DisplayMember = "Reg_name";
            trip_Region.ValueMember = "Reg_name";

            DataTable dt2 = controllerObj.AllDrivers();
            addtrip_driver_id.DataSource = dt2;
            addtrip_driver_id.DisplayMember = "D_ID";
            addtrip_driver_id.ValueMember = "D_ID";

        }

        private void AddTripForm_Load(object sender, EventArgs e)
        {

        }

      

        private void AddTripWithData_Click_1(object sender, EventArgs e)
        {

            char d = 'N';
            if (tripCode.Text == "" || string.IsNullOrEmpty(trip_Region.SelectedValue.ToString()) || string.IsNullOrEmpty(Direction.SelectedItem.ToString()) || string.IsNullOrEmpty(addtrip_bus_no.SelectedValue.ToString()) || string.IsNullOrEmpty(addtrip_driver_id.SelectedValue.ToString()))//validation part
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                int h = Convert.ToInt16(triptime_hour.Value);
                int m = Convert.ToInt16(triptime_minute.Value);
                string time = h + ":" + m + ":" + 00;
                if (Direction.SelectedItem.ToString() == "From")
                {
                    d = 'F';
                }
                else if (Direction.SelectedItem.ToString() == "To")
                {
                    d = 'T';
                }
                DateTime pip = Convert.ToDateTime(time);


                int r = controllerObj.InsertTrip(Convert.ToInt16(tripCode.Text), 0, Convert.ToInt32(trip_price.Value), pip.ToShortTimeString(), trip_Region.SelectedValue.ToString(), d, Convert.ToInt16(addtrip_bus_no.SelectedValue), Convert.ToInt16(addtrip_driver_id.SelectedValue));
                if (r != 0)
                    MessageBox.Show("Trip inserted successfully");
                else
                    MessageBox.Show("Insertion Failed");
            
        }
        }
    }
}
