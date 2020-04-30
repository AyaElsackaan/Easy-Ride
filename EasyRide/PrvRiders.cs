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
    public partial class PrvRiders : Form
    {
        Controller controllerobj;
        //string Namee;
        //int R_ID;
        public PrvRiders(int R_id)
        {
            InitializeComponent();
            //Namee = name;
            //R_ID = R_id;
            controllerobj = new Controller();

            //DataTable dt = controllerobj.GetPreviousRider();  //fills combobox of trips of chosen driver 
            //ComboRidersInfo.DataSource = dt;
            //ComboRidersInfo.DisplayMember = "name";
            //ComboRidersInfo.ValueMember = "name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DriverComplaint DC = new DriverComplaint(6);
            DC.Show();
        }
    }
}
