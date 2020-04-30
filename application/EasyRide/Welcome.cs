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
    public partial class Welcome : Form
    {
        int ID;
        public Welcome(int id )
        {
            InitializeComponent();
            ID = id;
            Controller controllerObj = new Controller();
            textBoxName.Text = controllerObj.getRiderName(ID).ToString();
            textBoxPhone.Text = controllerObj.getRiderPhone(ID).ToString();
        }


        private void buttonFrom_Click(object sender, EventArgs e)
        {
            book b = new book(ID);
            b.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonInbox_Click(object sender, EventArgs e)
        {
            Inbox i = new Inbox(ID);
            i.Show();
        }

        private void buttonTrips_Click(object sender, EventArgs e)
        {
            MyTrips m = new MyTrips(ID);
            m.Show();
        }

        private void buttonWallet_Click(object sender, EventArgs e)
        {
            MyWallet w = new MyWallet(ID);
            w.Show();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            SelectUser l = new SelectUser();
            l.Show();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void buttonPassword_Click(object sender, EventArgs e)
        {
            ChangePassword c = new ChangePassword(ID,'R');
            c.Show();
        }
    }
}
