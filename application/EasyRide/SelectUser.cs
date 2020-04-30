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
    public partial class SelectUser : Form
    {
        public SelectUser()
        {
            InitializeComponent();
        }

        private void buttonRider_Click(object sender, EventArgs e)
        {
            LogIn w = new LogIn('R');
            w.Show();
        }

        private void buttonDriver_Click(object sender, EventArgs e)
        {
            LogIn w = new LogIn('D');
            w.Show();

        }

        private void buttonCS_Click(object sender, EventArgs e)
        {
            LogIn w = new LogIn('C');
            w.Show();
        }

        private void buttonManager_Click(object sender, EventArgs e)
        {
            LogIn w = new LogIn('M');
            w.Show();
        }
    }
}
