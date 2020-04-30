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
    public partial class ViewTrips : Form
    {
        Controller controllerobj;
        int D_ID;

        public ViewTrips(int D_id)
        {
            InitializeComponent();
            D_ID = D_id;
            controllerobj = new Controller();
            //ID = Int16.Parse(controllerobj.GetDriversID().ToString());
            DataTable dt = controllerobj.GetDriversTrips(D_ID);  //fills combobox of trips of chosen driver 
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Trip_Code";
            comboBox1.ValueMember = "Trip_Code";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrvTripDate PrvTD = new PrvTripDate();
            PrvTD.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpTripDate UpTD = new UpTripDate();
            UpTD.Show();
        }
    }
}
