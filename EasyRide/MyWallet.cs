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
    public partial class MyWallet : Form
    {
        int ID;
        public MyWallet(int id)
        {
            InitializeComponent();
            ID = id;

            Controller controllerObj = new Controller();
            textBoxCredit.Text = controllerObj.getCredit(ID).ToString();
            string s = controllerObj.getPromo(ID).ToString();
            if (s=="T")
            {
                textBoxPromo.Text = "Promotion applied";

            }
            else
            {
                textBoxPromo.Text = "No Promotion applied";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxAddPromo.Text=="")
            {
                MessageBox.Show("Please insert a code ");
            }
            else if(textBoxAddPromo.Text == "xyz")
            {
                Controller controllerObj = new Controller();
                int x = controllerObj.AddPromo(ID);
                if (x != 0)
                {
                    textBoxPromo.Text = "Promotion applied";
                }
            }
            else
            {
                MessageBox.Show("Invalid Code!");
            }
        }
    }
}
