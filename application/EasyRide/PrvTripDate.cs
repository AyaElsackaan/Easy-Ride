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
    public partial class PrvTripDate : Form
    {
        int R_ID;
        public PrvTripDate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrvRiders PrvR = new PrvRiders(R_ID);
            PrvR.Show();
        }
    }
}
