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
    public partial class book : Form
    {
        int ID;
        public book(int id)
        {
            InitializeComponent();
            ID = id;

            Controller controllerObj = new Controller();

            comboBoxReg.DataSource = controllerObj.getAllRegions();
            comboBoxReg.DisplayMember = "Reg";


            monthCalendar1.MinDate = DateTime.Now;


        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            Controller controllerObj = new Controller();
            int code = Convert.ToInt32(controllerObj.getTripCode(comboBoxReg.Text, comboBoxDirection.Text, comboBoxTime.Text));
           string date= monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");
            string time = comboBoxTime.Text.ToString();
            int n = controllerObj.BookTrip(code, ID, date);
            if (n == 0)
            {
                TripDetails t = new TripDetails(code, ID, date, time, comboBoxReg.Text);
                t.Show();
            }
        }

        private void book_Load(object sender, EventArgs e)
        {

        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            Controller controllerObj = new Controller();
            comboBoxDirection.DataSource = controllerObj.getRegionDirections(comboBoxReg.Text);
            comboBoxDirection.ValueMember = "direction";
            comboBoxDirection.DisplayMember = "direction";
            comboBoxDirection.Refresh();

            label4.Visible = true;
            comboBoxDirection.Visible = true;
            button2.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            monthCalendar1.Visible = true;
            button3.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Controller controllerObj = new Controller();
            comboBoxTime.DataSource = controllerObj.GetTrip(comboBoxReg.Text, comboBoxDirection.Text);
            comboBoxTime.DisplayMember = "start_time";
            comboBoxTime.ValueMember = "start_time";
            comboBoxTime.Refresh();

            label3.Visible = true;
            comboBoxTime.Visible = true;
            buttonFind.Visible = true;

        }
    }
}

