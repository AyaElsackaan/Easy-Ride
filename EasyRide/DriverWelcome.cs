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
    public partial class DriverWelcome : Form
    {
        int ID;
        public DriverWelcome(int id)
        {
            InitializeComponent();
            ID = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewTrips v = new ViewTrips(ID);
            v.Show();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            LogIn l = new LogIn('D');
            l.Show();
        }

        private void buttonPass_Click(object sender, EventArgs e)
        {
            ChangePassword c = new ChangePassword(ID, 'D');
            c.Show();

        }
    }
}
