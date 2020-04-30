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
    public partial class UpTripDate : Form
    {
        Controller controllerobj;
        string date;
        public UpTripDate()
        {
            InitializeComponent();
            string d = DateTime.Now.ToString("yyyy-mm-dd");
            controllerobj = new Controller();
            DataTable dt = controllerobj.GetUpcomingRider(d);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpRiders UpR = new UpRiders(date);
            UpR.Show();
        }
    }
}
