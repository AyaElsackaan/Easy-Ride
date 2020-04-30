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
    public partial class mail : Form
    {
        int Cno;
        Controller controllerobj;
        public mail(int n)
        {
            Cno = n;
            InitializeComponent();
            controllerobj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg = richTextBox1.Text;
            int r = controllerobj.Reply(Cno, msg);
            if (r != 0)
                MessageBox.Show("Message sent");
            else
                MessageBox.Show("Send failed");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
