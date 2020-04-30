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
    public partial class RidersComplaints : Form
    {
        int ID;
        Controller controllerobj;
        public RidersComplaints(int id)
        {
            InitializeComponent();
            ID = id;

            controllerobj = new Controller();
            string reg = controllerobj.getCSregion(ID).ToString();
            DataTable dt = controllerobj.GetRComplaints(reg);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "comp_no";
            comboBox1.ValueMember = "comp_no";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ComplainR r = new ComplainR(Int16.Parse(comboBox1.Text));
            r.Show();
        }
    }
}
