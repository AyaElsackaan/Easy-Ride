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
    public partial class ManagerView : Form
    {
        int ID;
        public ManagerView(int id)
        {
            InitializeComponent();
            ID = id;
        }

       

       
        private void AddTrip_Click_1(object sender, EventArgs e)
        {
            AddTripForm addTrip = new AddTripForm();
            addTrip.Show();
        }

        private void AddCustomerServiceAgent_Click_1(object sender, EventArgs e)
        {
            NewC CSA = new NewC();
            CSA.Show();
        }

        private void RemoveTrip_Click(object sender, EventArgs e)
        {
            RemovingTrip rm = new RemovingTrip();
            rm.Show();


        }

        private void Update_CSAsalary_Click(object sender, EventArgs e)
        {
            CSAsalary csas = new CSAsalary();
            csas.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UpdateDriverSalary ds = new UpdateDriverSalary();
            ds.Show();
        }

        private void AddDriver_Click(object sender, EventArgs e)
        {
            AddNewDriver nd = new AddNewDriver();
            nd.Show();
        }

        private void buttonPass_Click(object sender, EventArgs e)
        {
            ChangePassword c = new ChangePassword(ID,'M');
            c.Show();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            LogIn l = new LogIn('M');
            l.Show();
        }

        private void buttonTotIncome_Click(object sender, EventArgs e)
        {
            RidersNo r = new RidersNo();
            r.Show();
            capacityPerR c = new capacityPerR();
            c.Load();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Region_Income_Report r = new Region_Income_Report();
            r.Show();
            CS cs = new CS();
            cs.Load();
        }
    }
}
