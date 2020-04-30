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
    public partial class Customer_Service : Form
    {
        int ID;
        public Customer_Service(int id)
        {
            InitializeComponent();
            ID = id;
           
        }

        private void Customer_Service_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RidersComplaints rc = new RidersComplaints(ID);
            rc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DriversComplaints dc = new DriversComplaints(ID);
            dc.Show();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            LogIn l = new LogIn('C');
            l.Show();
        }

        private void buttonPass_Click(object sender, EventArgs e)
        {
            ChangePassword c = new ChangePassword(ID,'C');
            c.Show();
        }
    }
}
