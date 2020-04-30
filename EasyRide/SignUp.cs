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
    public partial class SignUp : Form
    {
        Controller controllerObj = new Controller();
        public SignUp()
        {
            InitializeComponent();
        }

        private void buttonJoin_Click(object sender, EventArgs e)
        {
            if (textBoxN.Text == "" || textBoxPh.Text == "" || textBoxPs.Text == "")
            {
                MessageBox.Show("Please fill all required information!");
            }
            else
            {
                int r = controllerObj.AddRider(textBoxN.Text, textBoxPh.Text, textBoxPs.Text);
                if (r != 0)
                    MessageBox.Show("Congratulations! You have joined Esay Ride Family!");
                else
                    MessageBox.Show("Insertion Failed");
            }
        }
    }
}
