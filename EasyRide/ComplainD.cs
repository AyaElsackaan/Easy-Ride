using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EasyRide
{
    public partial class ComplainD : Form
    {
        int Cno;
        Controller controllerobj;
        public ComplainD(int n)
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

            if (comboBox1.Text == "Compensate")
            {
                int id = Int16.Parse(controllerobj.GetSender(Cno).ToString());
                int sal = Int32.Parse(controllerobj.GetDriverSalary(id).ToString());
                int newsal = sal + 100;
                int r = controllerobj.UpdateDriversalary(id, newsal);
                if (r != 0)
                    MessageBox.Show("Compensated");
                else
                    MessageBox.Show("Compensation failed");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int id = Int16.Parse(controllerobj.GetAbout(Cno).ToString());
            int r = controllerobj.PenaltyRider(id);
            if (r != 0)
                MessageBox.Show("Rider Penalized");
            else
                MessageBox.Show("Penalty failed");
        }
    }
}
