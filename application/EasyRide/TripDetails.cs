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
    public partial class TripDetails : Form
    {
        int ID;
        int CODE;
        string DATE;
        public TripDetails(int code, int id, string date, string time, string reg)
        {
            InitializeComponent();
            ID = id;
            CODE = code;
            DATE = date;
            Controller controllerObj = new Controller();
            labelCode.Text = code.ToString();
            textBoxID.Text = ID.ToString();
            textBoxbus.Text = controllerObj.getBusNumber(code).ToString();
            textBoxname.Text = controllerObj.getDriverName(code).ToString();
            textBoxphone.Text = controllerObj.getDriverPhone(code).ToString();
            textBoxDepTime.Text = time;

            DateTime t1 = Convert.ToDateTime(textBoxDepTime.Text);
            TimeSpan dur = TimeSpan.FromMinutes( Convert.ToInt32(controllerObj.getTripDuration(reg)));
            DateTime t2 = t1.Add(dur);
            textBoxArrTime.Text = t2.ToShortTimeString();

            textBoxPrice.Text = controllerObj.getTripPrice(code).ToString();

        }

        public TripDetails(int code, int id)
        {
            InitializeComponent();
            ID = id;
            Controller controllerObj = new Controller();
            labelCode.Text = code.ToString();
            textBoxID.Text = ID.ToString();
            textBoxbus.Text = controllerObj.getBusNumber(code).ToString();
            textBoxname.Text = controllerObj.getDriverName(code).ToString();
            textBoxphone.Text = controllerObj.getDriverPhone(code).ToString();
            textBoxDepTime.Text =controllerObj.getStTime(code).ToString();

            DateTime t1 = Convert.ToDateTime(textBoxDepTime.Text);
            TimeSpan dur = TimeSpan.FromMinutes(Convert.ToInt32(controllerObj.getDurationFromCode(code)));
            DateTime t2 = t1.Add(dur);
            textBoxArrTime.Text = t2.ToShortTimeString();

            textBoxPrice.Text = controllerObj.getTripPrice(code).ToString();

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Controller controllerObj = new Controller();
            int n=controllerObj.CancelTrip(ID, CODE, DATE);
            if (n==0)
            {
                MessageBox.Show("Trip cancelled successfully!");
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
