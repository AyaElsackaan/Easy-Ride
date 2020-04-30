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
    public partial class DriverComplaint : Form
    {
        int Cno;
        Controller controllerobj;
        public DriverComplaint(int n)
        {
            InitializeComponent();
            Cno = n;
            controllerobj = new Controller();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg = richTextBox1.Text;
            int r = controllerobj.Complain(Cno, msg);
            //if (r != 0)
            MessageBox.Show("Message sent");
            //else
            //MessageBox.Show("Send failed");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
