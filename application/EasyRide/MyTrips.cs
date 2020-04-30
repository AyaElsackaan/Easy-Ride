using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyRide
{
    public partial class MyTrips : Form
    {
        int ID;
        public MyTrips(int id)
        {
            InitializeComponent();
            ID = id;

            Controller controllerObj = new Controller();
            
            comboBoxUpcoming.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPrevious.DropDownStyle = ComboBoxStyle.DropDownList;
             comboBoxRating.DropDownStyle = ComboBoxStyle.DropDownList;

            string time = DateTime.Now.ToString("HH:mm:ss");
            string date = DateTime.Now.ToString("yyyy-MM-dd");

            comboBoxUpcoming.DataSource = controllerObj.getUpcomingTrips(ID,date,time);
            comboBoxUpcoming.DisplayMember = "trip_code";

            comboBoxPrevious.DataSource = controllerObj.getPreviousTrips(ID, date, time);
            comboBoxPrevious.DisplayMember = "trip_code";


        }

        private void buttonRate_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            label3.Visible = true;
            comboBoxRating.Visible = true;
            buttonSubmit.Visible = true;
        }

        private void buttonComplain_Click(object sender, EventArgs e)
        {
            label5.Visible = true;
            richTextBox1.Visible = true;
            buttonSend.Visible = true;

        }

        private void buttonDetails_Click(object sender, EventArgs e)
        {
            int code = Convert.ToInt32(comboBoxUpcoming.Text);
            TripDetails t = new TripDetails(code,ID);
            t.Show();
        }

        private void MyTrips_Load(object sender, EventArgs e)
        {

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            Controller controllerObj = new Controller();
            int code = Convert.ToInt32(comboBoxPrevious.Text);
            int driver = Convert.ToInt32(controllerObj.getDriverID(code));
            int n = controllerObj.InsertRating(ID, driver, code, Convert.ToInt32(comboBoxRating.Text));
            if (n!=0)
            {
                MessageBox.Show("Your rating was submitted.Thank you for your feedback!");
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            Controller controllerObj = new Controller();
            int driver = Convert.ToInt32(controllerObj.getDriverID(Convert.ToInt32(comboBoxPrevious.Text)));
            int n = controllerObj.InsertComp(ID, Convert.ToInt32(comboBoxPrevious.Text), driver, richTextBox1.Text);
            if (n != 0)
            {
                MessageBox.Show("Your complaint was submitted.Thank you for your feedback!");
            }
           
        }
    }
}
