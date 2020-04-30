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
    public partial class UpRiders : Form
    {
        Controller controllerobj;
        //string Namee;
        string date;
        public UpRiders(string d)
        {
            InitializeComponent();
            //Namee = name;
            //date = d;
            controllerobj = new Controller();

            //DataTable dt = controllerobj.GetUpcomingRider(d);  //fills combobox of trips of chosen driver 
            //ComboRidersInfo.DataSource = dt;
            //ComboRidersInfo.DisplayMember = "name";
            //ComboRidersInfo.ValueMember = "name";


        }

        private void button1_Click(object sender, EventArgs e)
        {

            //int T_id=Int16.Parse(controllerobj.GetTripCode(R_ID));
            RiderInfo RI = new RiderInfo(Int16.Parse(ComboRidersInfo.Text));
            RI.Show();
        }
    }
}
