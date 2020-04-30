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
    public partial class NewC : Form
    {
        Controller controllerObj;
        public NewC()
        {
            
            InitializeComponent();
            controllerObj = new Controller();

            DataTable dt1 = controllerObj.AllRegions();
            C_S_A_Region.DataSource = dt1;
            C_S_A_Region.DisplayMember = "Reg_name";
            C_S_A_Region.ValueMember = "Reg_name";
        }

        private void Add_C_S_A_Click(object sender, EventArgs e)
        {
            if (C_S_A_ID.Text == "" || C_S_A_Name.Text == "" || Password.Text == "" || string.IsNullOrEmpty(C_S_A_Region.SelectedValue.ToString()))//validation part
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                int r = controllerObj.InsertCSA(Convert.ToInt32(C_S_A_ID.Text), C_S_A_Name.Text.ToString(), Convert.ToInt32(C_S_A_salary.Value), C_S_A_Region.SelectedValue.ToString(), Password.Text);
                if (r != 0)
                    MessageBox.Show("Customer Service Agent inserted successfully");
                else
                    MessageBox.Show("Insertion Failed");
            }
        }
    }
}
