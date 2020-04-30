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
    public partial class CSAsalary : Form
    {
        Controller controllerObj;
        public CSAsalary()
        {
            InitializeComponent();
            controllerObj = new Controller();

            DataTable dt = controllerObj.GetAllCSA();
            CSA_IDs.DataSource = dt;
            CSA_IDs.DisplayMember = "CS_ID";
            CSA_IDs.ValueMember = "CS_ID";
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CSA_IDs.SelectedValue.ToString()))
            {
                MessageBox.Show("Please, choose Customer Service ID");
            }
            else
            {
                int r = controllerObj.UpdateCSsalary(Convert.ToInt16(CSA_IDs.SelectedValue), Convert.ToInt32(NewSalary.Value));
                if (r != 0)
                    MessageBox.Show("Salary Updated successfully");
                else
                    MessageBox.Show("Update Failed");
            }
        }
    }
}
