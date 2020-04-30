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
    public partial class RiderInfo : Form
    {
        int R_ID;

        Controller controllerobj;

        public RiderInfo(int R_id)
        {

            InitializeComponent();
            R_ID = R_id;

            controllerobj = new Controller();
            string name = Convert.ToString(controllerobj.GetRidersName(R_id));
            textBox3.Text = name;
            textBox3.Refresh();

            string phone = Convert.ToString(controllerobj.GetRidersPhone(R_id));
            textBox4.Text = phone;
            textBox4.Refresh();

            string price = Convert.ToString(controllerobj.GetPrice(R_id));
            textBox5.Text = price;
            textBox5.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controllerobj = new Controller();
            int T_ID = Int32.Parse(controllerobj.GetTripCode(R_ID).ToString());
            int price = Int32.Parse(controllerobj.GetTripPrice(T_ID).ToString());
            int cash = Int32.Parse(textBox1.Text);
            int change = cash - price;

            int r = controllerobj.UpdateRiderWallet(change, R_ID);
            if (r == 0)
                MessageBox.Show("Wallet Updated Succcessfully");
            else
                MessageBox.Show("Wallet Failed to Update");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            controllerobj = new Controller();
            int T_ID = Convert.ToInt16(controllerobj.GetTripCode(R_ID).ToString());
            int price = Convert.ToInt16(controllerobj.GetTripPrice(T_ID).ToString());
            int cashh = Int16.Parse(textBox1.Text);
            int change = cashh - price;
            textBox2.Text = Convert.ToString(change);
            textBox2.Refresh();
        }
    }
}
