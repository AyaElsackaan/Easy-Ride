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
    public partial class ComplainR : Form
    {
        int Cno;
        Controller controllerobj;
        public ComplainR(int n)
        {
            Cno = n;
            InitializeComponent();
            controllerobj = new Controller();
            string msg = controllerobj.GetContent(n).ToString();
            richTextBox1.Text = msg;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Mail")
            {
                mail m = new mail(Cno);
                m.Show();
            }
            if (comboBox1.Text == "Promo")
            {
                int id = Int32.Parse(controllerobj.GetSender(Cno).ToString());
                int r = controllerobj.SetPromo(id);
                if (r != 0)
                    MessageBox.Show("Promo set");
                else
                    MessageBox.Show("No Promo");
            }
            if (comboBox1.Text == "Refund")
            {
                int Tid = Int32.Parse(controllerobj.GetTripID(Cno).ToString());
                int price = Int32.Parse(controllerobj.GetTripPrice(Tid).ToString());
                int id = Int32.Parse(controllerobj.GetSender(Cno).ToString());
                int r = controllerobj.Refund(id, price);
                if (r != 0)
                    MessageBox.Show("Refunded");
                else
                    MessageBox.Show("Refund failed");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(controllerobj.GetAbout(Cno).ToString());
            int Salary = Int32.Parse(controllerobj.GetDriverSalary(id).ToString());
            int newsal = Salary - 100;
            int r = controllerobj.UpdateDriversalary(id, newsal);
            if (r != 0)
                MessageBox.Show("Driver Penalized");
            else
                MessageBox.Show("Salary not Updated");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
